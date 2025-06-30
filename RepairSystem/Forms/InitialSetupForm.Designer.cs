namespace RepairSystem.Forms
{
    partial class InitialSetupForm
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
            this.labelWelcom = new System.Windows.Forms.Label();
            this.labelInputUniName = new System.Windows.Forms.Label();
            this.textBoxUniName = new System.Windows.Forms.TextBox();
            this.buttonUniNameSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWelcom
            // 
            this.labelWelcom.AutoSize = true;
            this.labelWelcom.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelWelcom.ForeColor = System.Drawing.Color.Red;
            this.labelWelcom.Location = new System.Drawing.Point(60, 40);
            this.labelWelcom.Name = "labelWelcom";
            this.labelWelcom.Size = new System.Drawing.Size(410, 32);
            this.labelWelcom.TabIndex = 0;
            this.labelWelcom.Text = "歡迎使用資訊設備報修系統";
            // 
            // labelInputUniName
            // 
            this.labelInputUniName.AutoSize = true;
            this.labelInputUniName.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelInputUniName.Location = new System.Drawing.Point(150, 100);
            this.labelInputUniName.Name = "labelInputUniName";
            this.labelInputUniName.Size = new System.Drawing.Size(235, 24);
            this.labelInputUniName.TabIndex = 1;
            this.labelInputUniName.Text = "請輸入工作單位名稱";
            // 
            // textBoxUniName
            // 
            this.textBoxUniName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxUniName.Location = new System.Drawing.Point(120, 150);
            this.textBoxUniName.Name = "textBoxUniName";
            this.textBoxUniName.Size = new System.Drawing.Size(300, 36);
            this.textBoxUniName.TabIndex = 2;
            // 
            // buttonUniNameSave
            // 
            this.buttonUniNameSave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonUniNameSave.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonUniNameSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUniNameSave.Location = new System.Drawing.Point(154, 210);
            this.buttonUniNameSave.Name = "buttonUniNameSave";
            this.buttonUniNameSave.Size = new System.Drawing.Size(88, 36);
            this.buttonUniNameSave.TabIndex = 3;
            this.buttonUniNameSave.Text = "確定";
            this.buttonUniNameSave.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonCancel.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancel.Location = new System.Drawing.Point(297, 210);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(88, 36);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // InitialSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(538, 284);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonUniNameSave);
            this.Controls.Add(this.textBoxUniName);
            this.Controls.Add(this.labelInputUniName);
            this.Controls.Add(this.labelWelcom);
            this.Name = "InitialSetupForm";
            this.Text = "初始設定";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcom;
        private System.Windows.Forms.Label labelInputUniName;
        private System.Windows.Forms.TextBox textBoxUniName;
        private System.Windows.Forms.Button buttonUniNameSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}