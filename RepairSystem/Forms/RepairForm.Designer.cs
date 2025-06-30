namespace RepairSystem.Forms
{
    partial class RepairForm
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
            this.labelContactName = new System.Windows.Forms.Label();
            this.textBoxContactName = new System.Windows.Forms.TextBox();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.dateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.labelFaultDescription = new System.Windows.Forms.Label();
            this.comboBoxFaultDescription = new System.Windows.Forms.ComboBox();
            this.labelWorkRecord = new System.Windows.Forms.Label();
            this.textBoxWorkRecord = new System.Windows.Forms.TextBox();
            this.labelEngineer = new System.Windows.Forms.Label();
            this.textBoxEngineer = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.comboBoxCustomerName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelType.Location = new System.Drawing.Point(40, 30);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(60, 24);
            this.labelType.TabIndex = 0;
            this.labelType.Text = "類型";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(220, 27);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(220, 32);
            this.comboBoxType.TabIndex = 1;
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelCustomerName.Location = new System.Drawing.Point(40, 80);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(110, 24);
            this.labelCustomerName.TabIndex = 2;
            this.labelCustomerName.Text = "客戶名稱";
            // 
            // labelContactName
            // 
            this.labelContactName.AutoSize = true;
            this.labelContactName.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelContactName.Location = new System.Drawing.Point(40, 130);
            this.labelContactName.Name = "labelContactName";
            this.labelContactName.Size = new System.Drawing.Size(135, 24);
            this.labelContactName.TabIndex = 4;
            this.labelContactName.Text = "叫修人姓名";
            // 
            // textBoxContactName
            // 
            this.textBoxContactName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxContactName.Location = new System.Drawing.Point(220, 127);
            this.textBoxContactName.Name = "textBoxContactName";
            this.textBoxContactName.Size = new System.Drawing.Size(220, 36);
            this.textBoxContactName.TabIndex = 5;
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelStartTime.Location = new System.Drawing.Point(40, 233);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(110, 24);
            this.labelStartTime.TabIndex = 6;
            this.labelStartTime.Text = "叫修時間";
            // 
            // dateTimePickerStartTime
            // 
            this.dateTimePickerStartTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePickerStartTime.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStartTime.Location = new System.Drawing.Point(220, 225);
            this.dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            this.dateTimePickerStartTime.ShowUpDown = true;
            this.dateTimePickerStartTime.Size = new System.Drawing.Size(350, 36);
            this.dateTimePickerStartTime.TabIndex = 7;
            // 
            // labelFaultDescription
            // 
            this.labelFaultDescription.AutoSize = true;
            this.labelFaultDescription.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelFaultDescription.Location = new System.Drawing.Point(40, 325);
            this.labelFaultDescription.Name = "labelFaultDescription";
            this.labelFaultDescription.Size = new System.Drawing.Size(110, 24);
            this.labelFaultDescription.TabIndex = 11;
            this.labelFaultDescription.Text = "故障現象";
            // 
            // comboBoxFaultDescription
            // 
            this.comboBoxFaultDescription.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxFaultDescription.FormattingEnabled = true;
            this.comboBoxFaultDescription.Location = new System.Drawing.Point(220, 322);
            this.comboBoxFaultDescription.Name = "comboBoxFaultDescription";
            this.comboBoxFaultDescription.Size = new System.Drawing.Size(220, 32);
            this.comboBoxFaultDescription.TabIndex = 12;
            // 
            // labelWorkRecord
            // 
            this.labelWorkRecord.AutoSize = true;
            this.labelWorkRecord.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelWorkRecord.Location = new System.Drawing.Point(40, 370);
            this.labelWorkRecord.Name = "labelWorkRecord";
            this.labelWorkRecord.Size = new System.Drawing.Size(110, 24);
            this.labelWorkRecord.TabIndex = 13;
            this.labelWorkRecord.Text = "工作紀錄";
            // 
            // textBoxWorkRecord
            // 
            this.textBoxWorkRecord.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxWorkRecord.Location = new System.Drawing.Point(220, 367);
            this.textBoxWorkRecord.Multiline = true;
            this.textBoxWorkRecord.Name = "textBoxWorkRecord";
            this.textBoxWorkRecord.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxWorkRecord.Size = new System.Drawing.Size(416, 96);
            this.textBoxWorkRecord.TabIndex = 14;
            // 
            // labelEngineer
            // 
            this.labelEngineer.AutoSize = true;
            this.labelEngineer.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelEngineer.Location = new System.Drawing.Point(40, 480);
            this.labelEngineer.Name = "labelEngineer";
            this.labelEngineer.Size = new System.Drawing.Size(85, 24);
            this.labelEngineer.TabIndex = 17;
            this.labelEngineer.Text = "工程師";
            // 
            // textBoxEngineer
            // 
            this.textBoxEngineer.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxEngineer.Location = new System.Drawing.Point(220, 477);
            this.textBoxEngineer.Name = "textBoxEngineer";
            this.textBoxEngineer.Size = new System.Drawing.Size(300, 36);
            this.textBoxEngineer.TabIndex = 18;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSave.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSave.Location = new System.Drawing.Point(220, 530);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 40);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonCancel.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancel.Location = new System.Drawing.Point(400, 530);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 40);
            this.buttonCancel.TabIndex = 20;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelPhone.Location = new System.Drawing.Point(40, 178);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(110, 24);
            this.labelPhone.TabIndex = 21;
            this.labelPhone.Text = "連絡電話";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxPhone.Location = new System.Drawing.Point(220, 175);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(300, 36);
            this.textBoxPhone.TabIndex = 22;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelModel.Location = new System.Drawing.Point(40, 275);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(110, 24);
            this.labelModel.TabIndex = 23;
            this.labelModel.Text = "報修機型";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxModel.Location = new System.Drawing.Point(220, 272);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(350, 36);
            this.textBoxModel.TabIndex = 24;
            // 
            // comboBoxCustomerName
            // 
            this.comboBoxCustomerName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxCustomerName.FormattingEnabled = true;
            this.comboBoxCustomerName.Location = new System.Drawing.Point(220, 77);
            this.comboBoxCustomerName.Name = "comboBoxCustomerName";
            this.comboBoxCustomerName.Size = new System.Drawing.Size(300, 32);
            this.comboBoxCustomerName.TabIndex = 25;
            // 
            // RepairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(708, 594);
            this.Controls.Add(this.comboBoxCustomerName);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxEngineer);
            this.Controls.Add(this.labelEngineer);
            this.Controls.Add(this.textBoxWorkRecord);
            this.Controls.Add(this.labelWorkRecord);
            this.Controls.Add(this.comboBoxFaultDescription);
            this.Controls.Add(this.labelFaultDescription);
            this.Controls.Add(this.dateTimePickerStartTime);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.textBoxContactName);
            this.Controls.Add(this.labelContactName);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelType);
            this.Name = "RepairForm";
            this.Text = "新增報修單";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelContactName;
        private System.Windows.Forms.TextBox textBoxContactName;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartTime;
        private System.Windows.Forms.Label labelFaultDescription;
        private System.Windows.Forms.ComboBox comboBoxFaultDescription;
        private System.Windows.Forms.Label labelWorkRecord;
        private System.Windows.Forms.TextBox textBoxWorkRecord;
        private System.Windows.Forms.Label labelEngineer;
        private System.Windows.Forms.TextBox textBoxEngineer;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.ComboBox comboBoxCustomerName;
    }
}