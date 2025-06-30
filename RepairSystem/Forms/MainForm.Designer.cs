namespace RepairSystem.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonMaintenance = new System.Windows.Forms.Button();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.buttonCustomer = new System.Windows.Forms.Button();
            this.buttonRepair = new System.Windows.Forms.Button();
            this.labelTopTitle = new System.Windows.Forms.Label();
            this.dataGridViewMainForm = new System.Windows.Forms.DataGridView();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.buttonAbout);
            this.panelLeft.Controls.Add(this.buttonMaintenance);
            this.panelLeft.Controls.Add(this.buttonQuery);
            this.panelLeft.Controls.Add(this.buttonCustomer);
            this.panelLeft.Controls.Add(this.buttonRepair);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(210, 661);
            this.panelLeft.TabIndex = 0;
            // 
            // buttonAbout
            // 
            this.buttonAbout.AutoEllipsis = true;
            this.buttonAbout.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonAbout.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonAbout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAbout.Location = new System.Drawing.Point(0, 510);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(210, 70);
            this.buttonAbout.TabIndex = 4;
            this.buttonAbout.Text = "關於RepairSystem";
            this.buttonAbout.UseVisualStyleBackColor = false;
            // 
            // buttonMaintenance
            // 
            this.buttonMaintenance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonMaintenance.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonMaintenance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMaintenance.Location = new System.Drawing.Point(0, 410);
            this.buttonMaintenance.Name = "buttonMaintenance";
            this.buttonMaintenance.Size = new System.Drawing.Size(210, 70);
            this.buttonMaintenance.TabIndex = 3;
            this.buttonMaintenance.Text = "資料維護";
            this.buttonMaintenance.UseVisualStyleBackColor = false;
            // 
            // buttonQuery
            // 
            this.buttonQuery.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonQuery.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonQuery.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonQuery.Location = new System.Drawing.Point(0, 310);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(210, 70);
            this.buttonQuery.TabIndex = 2;
            this.buttonQuery.Text = "查詢";
            this.buttonQuery.UseVisualStyleBackColor = false;
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonCustomer.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCustomer.Location = new System.Drawing.Point(0, 210);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Size = new System.Drawing.Size(210, 70);
            this.buttonCustomer.TabIndex = 1;
            this.buttonCustomer.Text = "客戶管理";
            this.buttonCustomer.UseVisualStyleBackColor = false;
            // 
            // buttonRepair
            // 
            this.buttonRepair.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonRepair.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonRepair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRepair.Location = new System.Drawing.Point(0, 110);
            this.buttonRepair.Name = "buttonRepair";
            this.buttonRepair.Size = new System.Drawing.Size(210, 70);
            this.buttonRepair.TabIndex = 0;
            this.buttonRepair.Text = "報修";
            this.buttonRepair.UseVisualStyleBackColor = false;
            // 
            // labelTopTitle
            // 
            this.labelTopTitle.AutoSize = true;
            this.labelTopTitle.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTopTitle.Location = new System.Drawing.Point(260, 20);
            this.labelTopTitle.Name = "labelTopTitle";
            this.labelTopTitle.Size = new System.Drawing.Size(311, 36);
            this.labelTopTitle.TabIndex = 1;
            this.labelTopTitle.Text = "資訊設備報修系統";
            // 
            // dataGridViewMainForm
            // 
            this.dataGridViewMainForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMainForm.Location = new System.Drawing.Point(220, 80);
            this.dataGridViewMainForm.Name = "dataGridViewMainForm";
            this.dataGridViewMainForm.RowHeadersWidth = 62;
            this.dataGridViewMainForm.RowTemplate.Height = 31;
            this.dataGridViewMainForm.Size = new System.Drawing.Size(1020, 570);
            this.dataGridViewMainForm.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.dataGridViewMainForm);
            this.Controls.Add(this.labelTopTitle);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "資訊設備報修系統";
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label labelTopTitle;
        private System.Windows.Forms.DataGridView dataGridViewMainForm;
        private System.Windows.Forms.Button buttonRepair;
        private System.Windows.Forms.Button buttonCustomer;
        private System.Windows.Forms.Button buttonMaintenance;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.Button buttonAbout;
    }
}

