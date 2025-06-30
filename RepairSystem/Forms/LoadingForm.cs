using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using RepairSystem.Helpers;

namespace RepairSystem.Forms
{
    public partial class LoadingForm : Form
    {
        private Timer timer;
        private int progress = 0;
        private static MainForm _mainForm;
        private static readonly string LogPath = Path.Combine(Application.StartupPath, "Logs");

        public LoadingForm()
        {
            try
            {
                InitializeComponent();
                InitializeTimer();
                SetupForm();
                LogMessage("LoadingForm 初始化完成");
            }
            catch (Exception ex)
            {
                LogError("LoadingForm 初始化失敗", ex);
                MessageBox.Show($"系統初始化失敗：{ex.Message}\n請檢查系統日誌。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void SetupForm()
        {
            // 設定表單屬性
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "載入中...";

            // 設定進度條屬性
            progressBarLoading.Minimum = 0;
            progressBarLoading.Maximum = 100;
            progressBarLoading.Value = 0;
            progressBarLoading.Style = ProgressBarStyle.Continuous;
        }

        private void InitializeTimer()
        {
            timer = new Timer
            {
                Interval = 50
            };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                progress += 2;
                progressBarLoading.Value = Math.Min(progress, 100);

                labeltechSupport.Text = progress < 30 ? "正在初始化系統..."
                    : progress < 60 ? "正在載入資料庫..."
                    : progress < 90 ? "正在載入介面..."
                    : "載入完成！";

                if (progress >= 100)
                {
                    timer.Stop();
                    LogMessage("進度條完成，準備關閉載入畫面");

                    try
                    {
                        if (DatabaseHelper.Instance.IsFirstTimeSetup())
                        {
                            LogMessage("首次使用，顯示初始設定畫面");
                            using (InitialSetupForm setupForm = new InitialSetupForm())
                            {
                                var result = setupForm.ShowDialog();
                                LogMessage($"初始設定畫面結果: {result}");

                                if (result == DialogResult.OK)
                                {
                                    ShowMainForm();
                                }
                                else
                                {
                                    LogMessage("使用者取消初始設定，重新啟動程式");
                                    Application.Restart();
                                }
                            }
                        }
                        else
                        {
                            LogMessage("非首次使用，直接顯示主畫面");
                            ShowMainForm();
                        }
                    }
                    catch (Exception ex)
                    {
                        LogError("顯示主畫面時發生錯誤", ex);
                        MessageBox.Show($"系統啟動失敗：{ex.Message}\n請檢查系統日誌。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    finally
                    {
                        // 移除這裡的 this.Close()，因為會在 ShowMainForm() 中處理
                        // this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                LogError("進度條更新時發生錯誤", ex);
                MessageBox.Show($"載入時發生錯誤: {ex.Message}\n請檢查系統日誌。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void ShowMainForm()
        {
            try
            {
                if (_mainForm == null || _mainForm.IsDisposed)
                {
                    LogMessage("建立新的主畫面");
                    _mainForm = new MainForm();
                }

                LogMessage("顯示主畫面");

                // 隱藏載入畫面但不關閉
                this.Hide();

                // 使用 ShowDialog() 讓 MainForm 成為主要視窗
                // 這樣當 MainForm 關閉時，整個應用程式才會結束
                _mainForm.ShowDialog();

                // 當 MainForm 關閉後，關閉 LoadingForm
                this.Close();
            }
            catch (Exception ex)
            {
                LogError("顯示主畫面時發生錯誤", ex);
                throw;
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            try
            {
                timer?.Stop();
                timer?.Dispose();
                LogMessage("載入畫面已關閉");
            }
            catch (Exception ex)
            {
                LogError("關閉載入畫面時發生錯誤", ex);
            }
            base.OnFormClosed(e);
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
                string logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [INFO] {message}";
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
    }
}