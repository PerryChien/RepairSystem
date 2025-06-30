namespace RepairSystem.Forms
{
    partial class RepairUpdateForm
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
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.labelContactName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.dateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.dateTimePickerEndTime = new System.Windows.Forms.DateTimePicker();
            this.checkBoxFinish = new System.Windows.Forms.CheckBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.labelFaultDescription = new System.Windows.Forms.Label();
            this.comboBoxFaultDescription = new System.Windows.Forms.ComboBox();
            this.labelWorkRecord = new System.Windows.Forms.Label();
            this.textBoxWorkRecord = new System.Windows.Forms.TextBox();
            this.labelEngineer = new System.Windows.Forms.Label();
            this.textBoxEngineer = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelHardwareSpecs = new System.Windows.Forms.Label();
            this.textBoxHardwareSpecs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelType.Location = new System.Drawing.Point(130, 20);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(60, 24);
            this.labelType.TabIndex = 0;
            this.labelType.Text = "類型";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(196, 20);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(220, 32);
            this.comboBoxType.TabIndex = 1;
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelCustomerName.Location = new System.Drawing.Point(80, 65);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(110, 24);
            this.labelCustomerName.TabIndex = 2;
            this.labelCustomerName.Text = "客戶名稱";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxCustomerName.Location = new System.Drawing.Point(196, 62);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(350, 36);
            this.textBoxCustomerName.TabIndex = 3;
            // 
            // labelContactName
            // 
            this.labelContactName.AutoSize = true;
            this.labelContactName.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelContactName.Location = new System.Drawing.Point(55, 110);
            this.labelContactName.Name = "labelContactName";
            this.labelContactName.Size = new System.Drawing.Size(135, 24);
            this.labelContactName.TabIndex = 4;
            this.labelContactName.Text = "叫修人姓名";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(196, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 36);
            this.textBox1.TabIndex = 5;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelPhone.Location = new System.Drawing.Point(80, 160);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(110, 24);
            this.labelPhone.TabIndex = 6;
            this.labelPhone.Text = "連絡電話";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxPhone.Location = new System.Drawing.Point(196, 157);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(300, 36);
            this.textBoxPhone.TabIndex = 7;
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelStartTime.Location = new System.Drawing.Point(80, 215);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(110, 24);
            this.labelStartTime.TabIndex = 8;
            this.labelStartTime.Text = "叫修時間";
            // 
            // dateTimePickerStartTime
            // 
            this.dateTimePickerStartTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePickerStartTime.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStartTime.Location = new System.Drawing.Point(196, 207);
            this.dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            this.dateTimePickerStartTime.Size = new System.Drawing.Size(300, 36);
            this.dateTimePickerStartTime.TabIndex = 9;
            // 
            // labelEndTime
            // 
            this.labelEndTime.AutoSize = true;
            this.labelEndTime.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelEndTime.Location = new System.Drawing.Point(80, 265);
            this.labelEndTime.Name = "labelEndTime";
            this.labelEndTime.Size = new System.Drawing.Size(110, 24);
            this.labelEndTime.TabIndex = 10;
            this.labelEndTime.Text = "完修時間";
            // 
            // dateTimePickerEndTime
            // 
            this.dateTimePickerEndTime.CalendarFont = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePickerEndTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePickerEndTime.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePickerEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEndTime.Location = new System.Drawing.Point(196, 257);
            this.dateTimePickerEndTime.Name = "dateTimePickerEndTime";
            this.dateTimePickerEndTime.Size = new System.Drawing.Size(300, 36);
            this.dateTimePickerEndTime.TabIndex = 11;
            // 
            // checkBoxFinish
            // 
            this.checkBoxFinish.AutoSize = true;
            this.checkBoxFinish.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBoxFinish.ForeColor = System.Drawing.Color.Red;
            this.checkBoxFinish.Location = new System.Drawing.Point(502, 264);
            this.checkBoxFinish.Name = "checkBoxFinish";
            this.checkBoxFinish.Size = new System.Drawing.Size(86, 28);
            this.checkBoxFinish.TabIndex = 12;
            this.checkBoxFinish.Text = "完修";
            this.checkBoxFinish.UseVisualStyleBackColor = true;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelModel.Location = new System.Drawing.Point(80, 310);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(110, 24);
            this.labelModel.TabIndex = 13;
            this.labelModel.Text = "叫修機型";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxModel.Location = new System.Drawing.Point(196, 307);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(350, 36);
            this.textBoxModel.TabIndex = 14;
            // 
            // labelFaultDescription
            // 
            this.labelFaultDescription.AutoSize = true;
            this.labelFaultDescription.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelFaultDescription.Location = new System.Drawing.Point(80, 360);
            this.labelFaultDescription.Name = "labelFaultDescription";
            this.labelFaultDescription.Size = new System.Drawing.Size(110, 24);
            this.labelFaultDescription.TabIndex = 15;
            this.labelFaultDescription.Text = "故障現象";
            // 
            // comboBoxFaultDescription
            // 
            this.comboBoxFaultDescription.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxFaultDescription.FormattingEnabled = true;
            this.comboBoxFaultDescription.Location = new System.Drawing.Point(196, 357);
            this.comboBoxFaultDescription.Name = "comboBoxFaultDescription";
            this.comboBoxFaultDescription.Size = new System.Drawing.Size(220, 32);
            this.comboBoxFaultDescription.TabIndex = 16;
            // 
            // labelWorkRecord
            // 
            this.labelWorkRecord.AutoSize = true;
            this.labelWorkRecord.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelWorkRecord.Location = new System.Drawing.Point(80, 405);
            this.labelWorkRecord.Name = "labelWorkRecord";
            this.labelWorkRecord.Size = new System.Drawing.Size(110, 24);
            this.labelWorkRecord.TabIndex = 17;
            this.labelWorkRecord.Text = "工作紀錄";
            // 
            // textBoxWorkRecord
            // 
            this.textBoxWorkRecord.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxWorkRecord.Location = new System.Drawing.Point(196, 402);
            this.textBoxWorkRecord.Multiline = true;
            this.textBoxWorkRecord.Name = "textBoxWorkRecord";
            this.textBoxWorkRecord.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxWorkRecord.Size = new System.Drawing.Size(416, 96);
            this.textBoxWorkRecord.TabIndex = 18;
            // 
            // labelEngineer
            // 
            this.labelEngineer.AutoSize = true;
            this.labelEngineer.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelEngineer.Location = new System.Drawing.Point(80, 565);
            this.labelEngineer.Name = "labelEngineer";
            this.labelEngineer.Size = new System.Drawing.Size(85, 24);
            this.labelEngineer.TabIndex = 19;
            this.labelEngineer.Text = "工程師";
            // 
            // textBoxEngineer
            // 
            this.textBoxEngineer.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxEngineer.Location = new System.Drawing.Point(197, 562);
            this.textBoxEngineer.Name = "textBoxEngineer";
            this.textBoxEngineer.Size = new System.Drawing.Size(300, 36);
            this.textBoxEngineer.TabIndex = 20;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonUpdate.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdate.Location = new System.Drawing.Point(196, 610);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 36);
            this.buttonUpdate.TabIndex = 21;
            this.buttonUpdate.Text = "更新";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonCancel.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancel.Location = new System.Drawing.Point(316, 610);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 36);
            this.buttonCancel.TabIndex = 22;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelHardwareSpecs
            // 
            this.labelHardwareSpecs.AutoSize = true;
            this.labelHardwareSpecs.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelHardwareSpecs.Location = new System.Drawing.Point(30, 515);
            this.labelHardwareSpecs.Name = "labelHardwareSpecs";
            this.labelHardwareSpecs.Size = new System.Drawing.Size(160, 24);
            this.labelHardwareSpecs.TabIndex = 23;
            this.labelHardwareSpecs.Text = "更換硬體規格";
            // 
            // textBoxHardwareSpecs
            // 
            this.textBoxHardwareSpecs.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxHardwareSpecs.Location = new System.Drawing.Point(196, 512);
            this.textBoxHardwareSpecs.Name = "textBoxHardwareSpecs";
            this.textBoxHardwareSpecs.Size = new System.Drawing.Size(301, 36);
            this.textBoxHardwareSpecs.TabIndex = 24;
            // 
            // RepairUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(668, 664);
            this.Controls.Add(this.textBoxHardwareSpecs);
            this.Controls.Add(this.labelHardwareSpecs);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxEngineer);
            this.Controls.Add(this.labelEngineer);
            this.Controls.Add(this.textBoxWorkRecord);
            this.Controls.Add(this.labelWorkRecord);
            this.Controls.Add(this.comboBoxFaultDescription);
            this.Controls.Add(this.labelFaultDescription);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.checkBoxFinish);
            this.Controls.Add(this.dateTimePickerEndTime);
            this.Controls.Add(this.labelEndTime);
            this.Controls.Add(this.dateTimePickerStartTime);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelContactName);
            this.Controls.Add(this.textBoxCustomerName);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelType);
            this.Name = "RepairUpdateForm";
            this.Text = "RepairUpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label labelContactName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartTime;
        private System.Windows.Forms.Label labelEndTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndTime;
        private System.Windows.Forms.CheckBox checkBoxFinish;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label labelFaultDescription;
        private System.Windows.Forms.ComboBox comboBoxFaultDescription;
        private System.Windows.Forms.Label labelWorkRecord;
        private System.Windows.Forms.TextBox textBoxWorkRecord;
        private System.Windows.Forms.Label labelEngineer;
        private System.Windows.Forms.TextBox textBoxEngineer;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelHardwareSpecs;
        private System.Windows.Forms.TextBox textBoxHardwareSpecs;
    }
}