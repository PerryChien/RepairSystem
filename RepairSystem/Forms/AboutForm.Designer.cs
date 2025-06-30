namespace RepairSystem.Forms
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelCompany = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.labelEnCompany = new System.Windows.Forms.Label();
            this.tabPageDonate = new System.Windows.Forms.TabPage();
            this.pictureBoxQRCode = new System.Windows.Forms.PictureBox();
            this.labelDonateMessage = new System.Windows.Forms.Label();
            this.buttonDonatePayPal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            this.tabPageDonate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.InitialImage")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(20, 20);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(110, 110);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTitle.Location = new System.Drawing.Point(240, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(273, 40);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "資訊設備報修系統";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(240, 80);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(98, 18);
            this.labelVersion.TabIndex = 2;
            this.labelVersion.Text = "版本: 1.0.0.3";
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Location = new System.Drawing.Point(240, 110);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(117, 18);
            this.labelCopyright.TabIndex = 3;
            this.labelCopyright.Text = "版權所有 2025";
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Location = new System.Drawing.Point(240, 140);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(98, 18);
            this.labelCompany.TabIndex = 4;
            this.labelCompany.Text = "黑貓工作室";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonOK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOK.Location = new System.Drawing.Point(440, 320);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 35);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "確定";
            this.buttonOK.UseVisualStyleBackColor = false;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxDescription.Location = new System.Drawing.Point(20, 210);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.ReadOnly = true;
            this.richTextBoxDescription.Size = new System.Drawing.Size(518, 180);
            this.richTextBoxDescription.TabIndex = 6;
            this.richTextBoxDescription.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageAbout);
            this.tabControl1.Controls.Add(this.tabPageDonate);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(660, 480);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPageAbout.Controls.Add(this.labelEnCompany);
            this.tabPageAbout.Controls.Add(this.pictureBoxLogo);
            this.tabPageAbout.Controls.Add(this.labelTitle);
            this.tabPageAbout.Controls.Add(this.labelVersion);
            this.tabPageAbout.Controls.Add(this.labelCopyright);
            this.tabPageAbout.Controls.Add(this.labelCompany);
            this.tabPageAbout.Controls.Add(this.richTextBoxDescription);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 28);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbout.Size = new System.Drawing.Size(652, 448);
            this.tabPageAbout.TabIndex = 0;
            this.tabPageAbout.Text = "關於";
            // 
            // labelEnCompany
            // 
            this.labelEnCompany.AutoSize = true;
            this.labelEnCompany.Location = new System.Drawing.Point(244, 170);
            this.labelEnCompany.Name = "labelEnCompany";
            this.labelEnCompany.Size = new System.Drawing.Size(105, 18);
            this.labelEnCompany.TabIndex = 7;
            this.labelEnCompany.Text = "Ooniau Studio";
            // 
            // tabPageDonate
            // 
            this.tabPageDonate.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPageDonate.Controls.Add(this.pictureBoxQRCode);
            this.tabPageDonate.Controls.Add(this.labelDonateMessage);
            this.tabPageDonate.Controls.Add(this.buttonDonatePayPal);
            this.tabPageDonate.Location = new System.Drawing.Point(4, 28);
            this.tabPageDonate.Name = "tabPageDonate";
            this.tabPageDonate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDonate.Size = new System.Drawing.Size(652, 448);
            this.tabPageDonate.TabIndex = 1;
            this.tabPageDonate.Text = "贊助開發";
            // 
            // pictureBoxQRCode
            // 
            this.pictureBoxQRCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxQRCode.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxQRCode.Image")));
            this.pictureBoxQRCode.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxQRCode.InitialImage")));
            this.pictureBoxQRCode.Location = new System.Drawing.Point(200, 120);
            this.pictureBoxQRCode.Name = "pictureBoxQRCode";
            this.pictureBoxQRCode.Size = new System.Drawing.Size(202, 202);
            this.pictureBoxQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxQRCode.TabIndex = 2;
            this.pictureBoxQRCode.TabStop = false;
            // 
            // labelDonateMessage
            // 
            this.labelDonateMessage.AutoEllipsis = true;
            this.labelDonateMessage.AutoSize = true;
            this.labelDonateMessage.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelDonateMessage.Location = new System.Drawing.Point(100, 40);
            this.labelDonateMessage.Name = "labelDonateMessage";
            this.labelDonateMessage.Size = new System.Drawing.Size(397, 60);
            this.labelDonateMessage.TabIndex = 1;
            this.labelDonateMessage.Text = "感謝您的支持是我們的開發的動力！\r\n黑貓工作室謝謝您\r\n";
            this.labelDonateMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDonatePayPal
            // 
            this.buttonDonatePayPal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDonatePayPal.BackColor = System.Drawing.Color.Honeydew;
            this.buttonDonatePayPal.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonDonatePayPal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream;
            this.buttonDonatePayPal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDonatePayPal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonDonatePayPal.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonDonatePayPal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDonatePayPal.Location = new System.Drawing.Point(200, 350);
            this.buttonDonatePayPal.Name = "buttonDonatePayPal";
            this.buttonDonatePayPal.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonDonatePayPal.Size = new System.Drawing.Size(200, 50);
            this.buttonDonatePayPal.TabIndex = 0;
            this.buttonDonatePayPal.Text = "  使用 PayPal 贊助";
            this.buttonDonatePayPal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDonatePayPal.UseVisualStyleBackColor = false;
            // 
            // AboutForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.CancelButton = this.buttonOK;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "關於 資訊設備報修系統";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageAbout.ResumeLayout(false);
            this.tabPageAbout.PerformLayout();
            this.tabPageDonate.ResumeLayout(false);
            this.tabPageDonate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelEnCompany;
    }
}