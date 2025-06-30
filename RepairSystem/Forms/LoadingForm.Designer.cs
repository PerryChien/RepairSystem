namespace RepairSystem.Forms
{
    partial class LoadingForm
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
            this.labelRepairSystem = new System.Windows.Forms.Label();
            this.labeltechSupport = new System.Windows.Forms.Label();
            this.progressBarLoading = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // labelRepairSystem
            // 
            this.labelRepairSystem.AutoSize = true;
            this.labelRepairSystem.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelRepairSystem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelRepairSystem.Location = new System.Drawing.Point(120, 80);
            this.labelRepairSystem.Name = "labelRepairSystem";
            this.labelRepairSystem.Size = new System.Drawing.Size(385, 36);
            this.labelRepairSystem.TabIndex = 0;
            this.labelRepairSystem.Text = "資訊設備報修管理系統";
            // 
            // labeltechSupport
            // 
            this.labeltechSupport.AutoSize = true;
            this.labeltechSupport.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labeltechSupport.Location = new System.Drawing.Point(200, 171);
            this.labeltechSupport.Name = "labeltechSupport";
            this.labeltechSupport.Size = new System.Drawing.Size(210, 24);
            this.labeltechSupport.TabIndex = 1;
            this.labeltechSupport.Text = "技術支援服務中心";
            // 
            // progressBarLoading
            // 
            this.progressBarLoading.Location = new System.Drawing.Point(71, 257);
            this.progressBarLoading.Name = "progressBarLoading";
            this.progressBarLoading.Size = new System.Drawing.Size(486, 23);
            this.progressBarLoading.TabIndex = 2;
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(618, 424);
            this.Controls.Add(this.progressBarLoading);
            this.Controls.Add(this.labeltechSupport);
            this.Controls.Add(this.labelRepairSystem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LoadingForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "LoadingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRepairSystem;
        private System.Windows.Forms.Label labeltechSupport;
        private System.Windows.Forms.ProgressBar progressBarLoading;
    }
}