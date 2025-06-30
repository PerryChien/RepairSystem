using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace RepairSystem.Forms
{
    public partial class AboutForm : Form
    {
        // Tab 控制項
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.TabPage tabPageDonate;
        
        // 關於頁籤控制項
        private PictureBox pictureBoxLogo;
        private Label labelTitle;
        private Label labelVersion;
        private Label labelCopyright;
        private Label labelCompany;
        private RichTextBox richTextBoxDescription;
        
        // 贊助頁籤控制項
        private System.Windows.Forms.PictureBox pictureBoxQRCode;
        private System.Windows.Forms.Label labelDonateMessage;
        private System.Windows.Forms.Button buttonDonatePayPal;
        
        // 共用控制項
        private Button buttonOK;

        public AboutForm()
        {
            InitializeComponent();
            
            // 初始化贊助按鈕點擊事件
            if (buttonDonatePayPal != null)
            {
                buttonDonatePayPal.Click += (sender, e) =>
                {
                    try
                    {
                        string paypalUrl = "https://www.paypal.com/ncp/payment/UWDY4H8BDAADS";
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = paypalUrl,
                            UseShellExecute = true
                        });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"無法開啟捐贈頁面: {ex.Message}", "錯誤", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };
            }
            InitializeAboutForm();
        }

        private void InitializeAboutForm()
        {
            try
            {
                // 設定視窗屬性
                this.Text = "關於 資訊設備報修系統";
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.StartPosition = FormStartPosition.CenterParent;
                this.ClientSize = new Size(520, 480);

                // 設定應用程式標題
                labelTitle.Text = "資訊設備報修系統";
                
                // 設定版本資訊
                var version = Assembly.GetExecutingAssembly().GetName().Version;
                labelVersion.Text = $"版本: {version.Major}.{version.Minor}.{version.Build}";
                
                // 設定版權資訊
                labelCopyright.Text = $"版權所有 {DateTime.Now.Year} 公司名稱";
                
                // 設定公司名稱
                labelCompany.Text = "黑貓工作室";
                
                // 設定描述文字
                richTextBoxDescription.Text = "資訊設備報修系統\n\n" +
                    "本系統用於管理公司內部資訊設備的報修流程，\n" +
                    "提供完整的報修單管理、客戶資料維護、維修記錄追蹤等功能。\n\n" +
                    "如有任何問題，請聯絡黑貓工作室。";
                
                // 設定按鈕事件
                buttonOK.Click += (s, e) => this.Close();
                
                // 設定圖片
                try
                {
                    // 嘗試從內嵌資源載入圖片
                    using (var stream = GetType().Assembly.GetManifestResourceStream("RepairSystem.Resources.About.png"))
                    {
                        if (stream != null)
                        {
                            // 載入圖片
                            var image = new Bitmap(stream);
                            
                            // 設定 PictureBox 大小與圖片相同
                            pictureBoxLogo.Size = image.Size;
                            
                            // 設定 PictureBox 位置（保持左側和頂部間距不變）
                            int leftMargin = 30;
                            int topMargin = 30;
                            pictureBoxLogo.Location = new Point(leftMargin, topMargin);
                            
                            // 設定圖片
                            pictureBoxLogo.Image = image;
                            
                            // 調整表單大小以容納更大的圖片（如果需要）
                            int minFormWidth = pictureBoxLogo.Right + 50;
                            if (this.Width < minFormWidth)
                            {
                                this.Width = minFormWidth;
                            }
                        }
                        else
                        {
                            // 如果找不到圖片，使用預設圖示
                            Debug.WriteLine("找不到內嵌資源圖片，使用預設圖示");
                            pictureBoxLogo.Image = SystemIcons.Information.ToBitmap();
                            
                            // 設定預設大小
                            pictureBoxLogo.Size = new Size(110, 110);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // 如果載入圖片失敗，使用預設圖示
                    Debug.WriteLine($"載入標誌圖片失敗: {ex.Message}");
                    pictureBoxLogo.Image = SystemIcons.Information.ToBitmap();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"初始化關於視窗時發生錯誤: {ex}");
                MessageBox.Show($"初始化關於視窗時發生錯誤: {ex.Message}", "錯誤", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
