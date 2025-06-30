using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using RepairSystem.Helpers;

namespace RepairSystem.Forms
{
    public partial class MainForm : Form
    {
        private static readonly string LogPath = Path.Combine(Application.StartupPath, "Logs");

        public MainForm()
        {
            try
            {
                LogMessage("開始初始化主畫面");
                InitializeComponent();
                
                // 設定視窗圖示
                string iconPath = Path.Combine(Application.StartupPath, "Resources", "RepairSystem.ico");
                if (File.Exists(iconPath))
                {
                    this.Icon = new Icon(iconPath);
                }
                
                SetupForm();
                LoadRepairOrders();
                LogMessage("主畫面初始化完成");
            }
            catch (Exception ex)
            {
                LogError("主畫面初始化失敗", ex);
                MessageBox.Show($"主畫面初始化失敗：{ex.Message}\n請檢查系統日誌。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void SetupForm()
        {
            try
            {
                LogMessage("開始設定主畫面");
                // 設定表單屬性
                this.StartPosition = FormStartPosition.CenterScreen;
                this.MaximizeBox = false;

                // 讀取系統名稱
                string uniName = DatabaseHelper.Instance.GetConfig("UniName");
                if (string.IsNullOrEmpty(uniName))
                {
                    throw new Exception("無法讀取工作單位名稱");
                }
                labelTopTitle.Text = $"{uniName} 資訊設備報修系統";
                LogMessage($"已設定工作單位名稱: {uniName}");

                // 設定按鈕事件
                buttonRepair.Click += (s, e) => OpenForm(new RepairForm());
                buttonCustomer.Click += (s, e) => OpenForm(new CustomerForm());
                buttonQuery.Click += (s, e) => OpenForm(new QueryForm());
                buttonMaintenance.Click += (s, e) => OpenForm(new MaintenanceForm());
                buttonAbout.Click += ButtonAbout_Click;
                LogMessage("按鈕事件設定完成");
            }
            catch (Exception ex)
            {
                LogError("設定主畫面時發生錯誤", ex);
                throw;
            }
        }

        private void ButtonRepair_Click(object sender, EventArgs e)
        {
            try
            {
                LogMessage("開啟報修表單");
                OpenForm(new RepairForm());
            }
            catch (Exception ex)
            {
                LogError("開啟報修表單時發生錯誤", ex);
                MessageBox.Show($"開啟報修表單失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenForm(Form form)
        {
            try
            {
                LogMessage($"開啟表單: {form.GetType().Name}");
                form.ShowDialog();
                LoadRepairOrders(); // 確保更新報修單
            }
            catch (Exception ex)
            {
                LogError($"開啟表單 {form.GetType().Name} 時發生錯誤", ex);
                MessageBox.Show($"開啟表單失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRepairOrders()
        {
            try
            {
                LogMessage("開始載入報修單");
                using (var connection = DatabaseHelper.Instance.GetConnection())
                {
                    connection.Open();
                    string query = @"
                        SELECT Type, CustomerName, Phone, StartTime, EndTime, Model, FaultDescription, Engineer
                        FROM RepairOrder
                        ORDER BY StartTime DESC
                        LIMIT 20";

                    using (var adapter = new System.Data.SQLite.SQLiteDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewMainForm.DataSource = dt;

                        // 設定欄位標題為中文
                        if (dataGridViewMainForm.Columns.Contains("Type"))
                            dataGridViewMainForm.Columns["Type"].HeaderText = "類型";
                        if (dataGridViewMainForm.Columns.Contains("CustomerName"))
                            dataGridViewMainForm.Columns["CustomerName"].HeaderText = "客戶名稱";
                        if (dataGridViewMainForm.Columns.Contains("Phone"))
                            dataGridViewMainForm.Columns["Phone"].HeaderText = "連絡電話";
                        if (dataGridViewMainForm.Columns.Contains("StartTime"))
                            dataGridViewMainForm.Columns["StartTime"].HeaderText = "叫修時間";
                        if (dataGridViewMainForm.Columns.Contains("EndTime"))
                            dataGridViewMainForm.Columns["EndTime"].HeaderText = "完修時間";
                        if (dataGridViewMainForm.Columns.Contains("Model"))
                            dataGridViewMainForm.Columns["Model"].HeaderText = "報修機型";
                        if (dataGridViewMainForm.Columns.Contains("FaultDescription"))
                            dataGridViewMainForm.Columns["FaultDescription"].HeaderText = "故障現象";
                        if (dataGridViewMainForm.Columns.Contains("Engineer"))
                            dataGridViewMainForm.Columns["Engineer"].HeaderText = "工程師";

                        LogMessage($"已載入 {dt.Rows.Count} 筆報修單");
                    }
                }
            }
            catch (Exception ex)
            {
                LogError("載入報修單時發生錯誤", ex);
                MessageBox.Show($"載入報修單失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void LogMessage(string message)
        {
            try
            {
                if (!Directory.Exists(LogPath))
                {
                    Directory.CreateDirectory(LogPath);
                }

                string logFile = Path.Combine(LogPath, $"System_{DateTime.Now:yyyyMMdd}.log");
                string logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm} [INFO] {message}";
                File.AppendAllText(logFile, logMessage + Environment.NewLine);
            }
            catch
            {
                // 忽略日誌記錄錯誤
            }
        }

        private static void LogError(string message, Exception ex)
        {
            try
            {
                if (!Directory.Exists(LogPath))
                {
                    Directory.CreateDirectory(LogPath);
                }

                string logFile = Path.Combine(LogPath, $"System_{DateTime.Now:yyyyMMdd}.log");
                string logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [ERROR] {message}\nException: {ex}\nStackTrace: {ex.StackTrace}";
                File.AppendAllText(logFile, logMessage + Environment.NewLine);
            }
            catch
            {
                // 忽略日誌記錄錯誤
            }
        }

        private void ButtonAbout_Click(object sender, EventArgs e)
        {
            try
            {
                LogMessage("開啟關於視窗");
                using (var aboutForm = new AboutForm())
                {
                    aboutForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                LogError("開啟關於視窗時發生錯誤", ex);
                MessageBox.Show($"開啟關於視窗失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}