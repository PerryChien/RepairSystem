using System;
using System.Windows.Forms;
using RepairSystem.Helpers;

namespace RepairSystem.Forms
{
    public partial class InitialSetupForm : Form
    {
        private bool isClosing = false;

        public InitialSetupForm()
        {
            InitializeComponent();

            // 綁定事件
            buttonUniNameSave.Click += ButtonUniNameSave_Click;
            buttonCancel.Click += (s, e) => 
            {
                isClosing = true;
                this.Close();
            };

            // 設定表單屬性
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            // 設定預設按鈕和焦點
            this.AcceptButton = buttonUniNameSave;
            textBoxUniName.Focus();
        }

        private void ButtonUniNameSave_Click(object sender, EventArgs e)
        {
            string uniName = textBoxUniName.Text.Trim();

            if (string.IsNullOrWhiteSpace(uniName))
            {
                MessageBox.Show("請輸入工作單位名稱！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxUniName.Focus();
                return;
            }

            try
            {
                DatabaseHelper.Instance.SetConfig("UniName", uniName);
                MessageBox.Show("設定完成！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"設定失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!isClosing && this.DialogResult != DialogResult.OK)
            {
                if (MessageBox.Show("尚未完成初始設定，確定要關閉嗎？", "確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }

            if (this.DialogResult != DialogResult.OK)
            {
                this.DialogResult = DialogResult.Cancel;
            }

            base.OnFormClosing(e);
        }
    }
}