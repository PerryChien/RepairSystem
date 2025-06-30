using System;
using System.Data;
using System.Windows.Forms;
using RepairSystem.Helpers;

namespace RepairSystem.Forms
{
    public partial class RepairForm : Form
    {
        public RepairForm()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            // 載入報修類型與故障現象
            LoadDropdownData(comboBoxType, "RepairType", "TypeName");
            LoadDropdownData(comboBoxFaultDescription, "FaultType", "FaultName");
            LoadCustomerData(); // 載入客戶資料

            // 設定時間選擇器預設值
            dateTimePickerStartTime.Value = DateTime.Now;

            // 設定按鈕事件
            buttonSave.Click += ButtonSave_Click;
            buttonCancel.Click += (s, e) => this.Close();

            // 設定客戶選擇事件
            comboBoxCustomerName.SelectedIndexChanged += ComboBoxCustomerName_SelectedIndexChanged;
        }

        private void LoadCustomerData()
        {
            try
            {
                using (var connection = DatabaseHelper.Instance.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT CustomerName FROM Customer ORDER BY CustomerName ASC";

                    using (var adapter = new System.Data.SQLite.SQLiteDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        comboBoxCustomerName.DataSource = dt;
                        comboBoxCustomerName.DisplayMember = "CustomerName";
                        comboBoxCustomerName.ValueMember = "CustomerName";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入客戶資料失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBoxCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 清空聯絡人姓名和電話，讓使用者手動輸入
            textBoxPhone.Text = string.Empty;
            textBoxContactName.Text = string.Empty;
        }

        private void LoadDropdownData(ComboBox comboBox, string tableName, string columnName)
        {
            try
            {
                using (var connection = DatabaseHelper.Instance.GetConnection())
                {
                    connection.Open();
                    string query = $"SELECT {columnName} FROM {tableName}";

                    using (var adapter = new System.Data.SQLite.SQLiteDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        foreach (DataRow row in dt.Rows)
                        {
                            comboBox.Items.Add(row[columnName].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入 {tableName} 失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            // 取得輸入值
            string type = comboBoxType.Text.Trim();
            string customerName = comboBoxCustomerName.Text.Trim();
            string contactName = textBoxContactName.Text.Trim();
            string phone = textBoxPhone.Text.Trim();
            DateTime startTime = dateTimePickerStartTime.Value;
            string model = textBoxModel.Text.Trim();
            string faultDescription = comboBoxFaultDescription.Text.Trim();
            string workRecord = textBoxWorkRecord.Text.Trim();
            string engineer = textBoxEngineer.Text.Trim();

            // 簡單驗證
            if (string.IsNullOrWhiteSpace(type) || string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("類型、客戶名稱與電話為必填項目！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 呼叫 Helper 寫入資料庫
                RepairOrderHelper.AddRepairOrder(
                    type,
                    customerName,
                    contactName, // 修正：加入報修人姓名
                    phone,
                    startTime.ToString("yyyy-MM-dd HH:mm"),
                    model,
                    faultDescription,
                    workRecord,
                    null, // hardwareSpecs 若有對應欄位請補上
                    engineer
                );

                MessageBox.Show("報修單已儲存！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"儲存報修單失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}