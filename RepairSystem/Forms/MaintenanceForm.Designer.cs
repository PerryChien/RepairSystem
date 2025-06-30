namespace RepairSystem.Forms
{
    partial class MaintenanceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMaintenanceTop = new System.Windows.Forms.Panel();
            this.labelMantenance = new System.Windows.Forms.Label();
            this.tabControlMantenance = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxUniName = new System.Windows.Forms.TextBox();
            this.labelUniName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonTypeCancel = new System.Windows.Forms.Button();
            this.buttonAddType = new System.Windows.Forms.Button();
            this.dataGridViewType = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewFaultDescription = new System.Windows.Forms.DataGridView();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddFaultDescription = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonCustomerExcelImport = new System.Windows.Forms.Button();
            this.buttonExcelImport = new System.Windows.Forms.Button();
            this.buttonDbImport = new System.Windows.Forms.Button();
            this.buttonDbBackup = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.buttonRecovery = new System.Windows.Forms.Button();
            this.panelMaintenanceTop.SuspendLayout();
            this.tabControlMantenance.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewType)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFaultDescription)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMaintenanceTop
            // 
            this.panelMaintenanceTop.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelMaintenanceTop.Controls.Add(this.labelMantenance);
            this.panelMaintenanceTop.Location = new System.Drawing.Point(0, 0);
            this.panelMaintenanceTop.Name = "panelMaintenanceTop";
            this.panelMaintenanceTop.Size = new System.Drawing.Size(848, 80);
            this.panelMaintenanceTop.TabIndex = 0;
            // 
            // labelMantenance
            // 
            this.labelMantenance.AutoSize = true;
            this.labelMantenance.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelMantenance.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelMantenance.Location = new System.Drawing.Point(350, 25);
            this.labelMantenance.Name = "labelMantenance";
            this.labelMantenance.Size = new System.Drawing.Size(163, 36);
            this.labelMantenance.TabIndex = 0;
            this.labelMantenance.Text = "資料維護";
            // 
            // tabControlMantenance
            // 
            this.tabControlMantenance.Controls.Add(this.tabPage1);
            this.tabControlMantenance.Controls.Add(this.tabPage2);
            this.tabControlMantenance.Controls.Add(this.tabPage3);
            this.tabControlMantenance.Controls.Add(this.tabPage4);
            this.tabControlMantenance.Controls.Add(this.tabPage5);
            this.tabControlMantenance.ItemSize = new System.Drawing.Size(200, 36);
            this.tabControlMantenance.Location = new System.Drawing.Point(0, 80);
            this.tabControlMantenance.Name = "tabControlMantenance";
            this.tabControlMantenance.SelectedIndex = 0;
            this.tabControlMantenance.Size = new System.Drawing.Size(848, 542);
            this.tabControlMantenance.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage1.Controls.Add(this.buttonSave);
            this.tabPage1.Controls.Add(this.textBoxUniName);
            this.tabPage1.Controls.Add(this.labelUniName);
            this.tabPage1.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(840, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "工作單位名稱";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSave.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSave.Location = new System.Drawing.Point(120, 190);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(88, 36);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // textBoxUniName
            // 
            this.textBoxUniName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxUniName.Location = new System.Drawing.Point(120, 130);
            this.textBoxUniName.Name = "textBoxUniName";
            this.textBoxUniName.Size = new System.Drawing.Size(420, 36);
            this.textBoxUniName.TabIndex = 1;
            // 
            // labelUniName
            // 
            this.labelUniName.AutoSize = true;
            this.labelUniName.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelUniName.Location = new System.Drawing.Point(120, 90);
            this.labelUniName.Name = "labelUniName";
            this.labelUniName.Size = new System.Drawing.Size(173, 24);
            this.labelUniName.TabIndex = 0;
            this.labelUniName.Text = "工作單位名稱:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage2.Controls.Add(this.buttonTypeCancel);
            this.tabPage2.Controls.Add(this.buttonAddType);
            this.tabPage2.Controls.Add(this.dataGridViewType);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(840, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "類型管理";
            // 
            // buttonTypeCancel
            // 
            this.buttonTypeCancel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonTypeCancel.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonTypeCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTypeCancel.Location = new System.Drawing.Point(50, 200);
            this.buttonTypeCancel.Name = "buttonTypeCancel";
            this.buttonTypeCancel.Size = new System.Drawing.Size(88, 36);
            this.buttonTypeCancel.TabIndex = 4;
            this.buttonTypeCancel.Text = "取消";
            this.buttonTypeCancel.UseVisualStyleBackColor = false;
            // 
            // buttonAddType
            // 
            this.buttonAddType.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonAddType.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonAddType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddType.Location = new System.Drawing.Point(50, 120);
            this.buttonAddType.Name = "buttonAddType";
            this.buttonAddType.Size = new System.Drawing.Size(88, 36);
            this.buttonAddType.TabIndex = 3;
            this.buttonAddType.Text = "新增";
            this.buttonAddType.UseVisualStyleBackColor = false;
            // 
            // dataGridViewType
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewType.Location = new System.Drawing.Point(160, 30);
            this.dataGridViewType.Name = "dataGridViewType";
            this.dataGridViewType.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewType.RowTemplate.Height = 31;
            this.dataGridViewType.Size = new System.Drawing.Size(600, 300);
            this.dataGridViewType.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage3.Controls.Add(this.dataGridViewFaultDescription);
            this.tabPage3.Controls.Add(this.buttonCancel);
            this.tabPage3.Controls.Add(this.buttonAddFaultDescription);
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(840, 498);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "故障現象管理";
            // 
            // dataGridViewFaultDescription
            // 
            this.dataGridViewFaultDescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFaultDescription.Location = new System.Drawing.Point(160, 30);
            this.dataGridViewFaultDescription.Name = "dataGridViewFaultDescription";
            this.dataGridViewFaultDescription.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewFaultDescription.RowTemplate.Height = 31;
            this.dataGridViewFaultDescription.Size = new System.Drawing.Size(640, 380);
            this.dataGridViewFaultDescription.TabIndex = 4;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonCancel.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancel.Location = new System.Drawing.Point(40, 200);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(88, 36);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonAddFaultDescription
            // 
            this.buttonAddFaultDescription.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonAddFaultDescription.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonAddFaultDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddFaultDescription.Location = new System.Drawing.Point(40, 120);
            this.buttonAddFaultDescription.Name = "buttonAddFaultDescription";
            this.buttonAddFaultDescription.Size = new System.Drawing.Size(88, 36);
            this.buttonAddFaultDescription.TabIndex = 2;
            this.buttonAddFaultDescription.Text = "新增";
            this.buttonAddFaultDescription.UseVisualStyleBackColor = false;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage4.Controls.Add(this.buttonCustomerExcelImport);
            this.tabPage4.Controls.Add(this.buttonExcelImport);
            this.tabPage4.Controls.Add(this.buttonDbImport);
            this.tabPage4.Controls.Add(this.buttonDbBackup);
            this.tabPage4.Location = new System.Drawing.Point(4, 40);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(840, 498);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "備份與還原";
            // 
            // buttonCustomerExcelImport
            // 
            this.buttonCustomerExcelImport.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonCustomerExcelImport.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCustomerExcelImport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCustomerExcelImport.Location = new System.Drawing.Point(70, 200);
            this.buttonCustomerExcelImport.Name = "buttonCustomerExcelImport";
            this.buttonCustomerExcelImport.Size = new System.Drawing.Size(280, 60);
            this.buttonCustomerExcelImport.TabIndex = 3;
            this.buttonCustomerExcelImport.Text = "從Excel匯入客戶資料";
            this.buttonCustomerExcelImport.UseVisualStyleBackColor = false;
            // 
            // buttonExcelImport
            // 
            this.buttonExcelImport.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonExcelImport.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonExcelImport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExcelImport.Location = new System.Drawing.Point(70, 280);
            this.buttonExcelImport.Name = "buttonExcelImport";
            this.buttonExcelImport.Size = new System.Drawing.Size(280, 60);
            this.buttonExcelImport.TabIndex = 2;
            this.buttonExcelImport.Text = "從Excel匯入報修單";
            this.buttonExcelImport.UseVisualStyleBackColor = false;
            // 
            // buttonDbImport
            // 
            this.buttonDbImport.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonDbImport.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonDbImport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDbImport.Location = new System.Drawing.Point(70, 120);
            this.buttonDbImport.Name = "buttonDbImport";
            this.buttonDbImport.Size = new System.Drawing.Size(280, 60);
            this.buttonDbImport.TabIndex = 1;
            this.buttonDbImport.Text = "資料庫匯入";
            this.buttonDbImport.UseVisualStyleBackColor = false;
            // 
            // buttonDbBackup
            // 
            this.buttonDbBackup.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonDbBackup.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonDbBackup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDbBackup.Location = new System.Drawing.Point(70, 40);
            this.buttonDbBackup.Name = "buttonDbBackup";
            this.buttonDbBackup.Size = new System.Drawing.Size(280, 60);
            this.buttonDbBackup.TabIndex = 0;
            this.buttonDbBackup.Text = "資料庫備份";
            this.buttonDbBackup.UseVisualStyleBackColor = false;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage5.Controls.Add(this.buttonRecovery);
            this.tabPage5.Location = new System.Drawing.Point(4, 40);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(840, 498);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "系統重置";
            // 
            // buttonRecovery
            // 
            this.buttonRecovery.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonRecovery.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonRecovery.ForeColor = System.Drawing.Color.Red;
            this.buttonRecovery.Location = new System.Drawing.Point(70, 70);
            this.buttonRecovery.Name = "buttonRecovery";
            this.buttonRecovery.Size = new System.Drawing.Size(200, 50);
            this.buttonRecovery.TabIndex = 0;
            this.buttonRecovery.Text = "系統重置";
            this.buttonRecovery.UseVisualStyleBackColor = false;
            // 
            // MaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 624);
            this.Controls.Add(this.tabControlMantenance);
            this.Controls.Add(this.panelMaintenanceTop);
            this.Name = "MaintenanceForm";
            this.Text = "資料維護";
            this.panelMaintenanceTop.ResumeLayout(false);
            this.panelMaintenanceTop.PerformLayout();
            this.tabControlMantenance.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewType)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFaultDescription)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMaintenanceTop;
        private System.Windows.Forms.Label labelMantenance;
        private System.Windows.Forms.TabControl tabControlMantenance;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxUniName;
        private System.Windows.Forms.Label labelUniName;
        private System.Windows.Forms.DataGridView dataGridViewType;
        private System.Windows.Forms.Button buttonTypeCancel;
        private System.Windows.Forms.Button buttonAddType;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button buttonAddFaultDescription;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DataGridView dataGridViewFaultDescription;
        private System.Windows.Forms.Button buttonExcelImport;
        private System.Windows.Forms.Button buttonDbImport;
        private System.Windows.Forms.Button buttonDbBackup;
        private System.Windows.Forms.Button buttonRecovery;
        private System.Windows.Forms.Button buttonCustomerExcelImport;
    }
}