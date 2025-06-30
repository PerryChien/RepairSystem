namespace RepairSystem.Forms
{
    partial class QueryForm
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
            this.panelQueryTop = new System.Windows.Forms.Panel();
            this.labelQueryForm = new System.Windows.Forms.Label();
            this.tabControlQuery = new System.Windows.Forms.TabControl();
            this.tabPageCustomerQuery = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelTaxId = new System.Windows.Forms.Label();
            this.button1Cancel = new System.Windows.Forms.Button();
            this.buttonCustomerQuery = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBox1CustomerName = new System.Windows.Forms.TextBox();
            this.label1CustomerName = new System.Windows.Forms.Label();
            this.tabPageRepairQuery = new System.Windows.Forms.TabPage();
            this.dateTimePickerEndTimeRange = new System.Windows.Forms.DateTimePicker();
            this.labelSim1 = new System.Windows.Forms.Label();
            this.labelSim = new System.Windows.Forms.Label();
            this.dateTimePickerStartTimeRange = new System.Windows.Forms.DateTimePicker();
            this.button2Cancel = new System.Windows.Forms.Button();
            this.buttonRepairQuery = new System.Windows.Forms.Button();
            this.dateTimePickerEndTime = new System.Windows.Forms.DateTimePicker();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.dateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.textBoxEngineer = new System.Windows.Forms.TextBox();
            this.labelEngineer = new System.Windows.Forms.Label();
            this.comboBoxFaultDescription = new System.Windows.Forms.ComboBox();
            this.labelFaultDescription = new System.Windows.Forms.Label();
            this.textBoxContactName = new System.Windows.Forms.TextBox();
            this.labelContactName = new System.Windows.Forms.Label();
            this.textBox2CustomerName = new System.Windows.Forms.TextBox();
            this.label2CustomerName = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.checkBoxEnableStartTime = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableEndTime = new System.Windows.Forms.CheckBox();
            this.tabPageQueryResult = new System.Windows.Forms.TabPage();
            this.panelQueryResult = new System.Windows.Forms.Panel();
            this.buttonGo = new System.Windows.Forms.Button();
            this.textBoxPage = new System.Windows.Forms.TextBox();
            this.labelPageInfo = new System.Windows.Forms.Label();
            this.comboBoxLine = new System.Windows.Forms.ComboBox();
            this.labelLine = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.dataGridViewQuery = new System.Windows.Forms.DataGridView();
            this.buttonExportExcel = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.panelQueryTop.SuspendLayout();
            this.tabControlQuery.SuspendLayout();
            this.tabPageCustomerQuery.SuspendLayout();
            this.tabPageRepairQuery.SuspendLayout();
            this.tabPageQueryResult.SuspendLayout();
            this.panelQueryResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // panelQueryTop
            // 
            this.panelQueryTop.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelQueryTop.Controls.Add(this.labelQueryForm);
            this.panelQueryTop.Location = new System.Drawing.Point(0, 0);
            this.panelQueryTop.Name = "panelQueryTop";
            this.panelQueryTop.Size = new System.Drawing.Size(1178, 80);
            this.panelQueryTop.TabIndex = 0;
            // 
            // labelQueryForm
            // 
            this.labelQueryForm.AutoSize = true;
            this.labelQueryForm.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelQueryForm.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelQueryForm.Location = new System.Drawing.Point(360, 25);
            this.labelQueryForm.Name = "labelQueryForm";
            this.labelQueryForm.Size = new System.Drawing.Size(163, 36);
            this.labelQueryForm.TabIndex = 0;
            this.labelQueryForm.Text = "查詢表單";
            // 
            // tabControlQuery
            // 
            this.tabControlQuery.Controls.Add(this.tabPageCustomerQuery);
            this.tabControlQuery.Controls.Add(this.tabPageRepairQuery);
            this.tabControlQuery.Controls.Add(this.tabPageQueryResult);
            this.tabControlQuery.Location = new System.Drawing.Point(0, 80);
            this.tabControlQuery.Name = "tabControlQuery";
            this.tabControlQuery.SelectedIndex = 0;
            this.tabControlQuery.Size = new System.Drawing.Size(1178, 626);
            this.tabControlQuery.TabIndex = 1;
            // 
            // tabPageCustomerQuery
            // 
            this.tabPageCustomerQuery.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPageCustomerQuery.Controls.Add(this.textBox1);
            this.tabPageCustomerQuery.Controls.Add(this.labelTaxId);
            this.tabPageCustomerQuery.Controls.Add(this.button1Cancel);
            this.tabPageCustomerQuery.Controls.Add(this.buttonCustomerQuery);
            this.tabPageCustomerQuery.Controls.Add(this.textBoxEmail);
            this.tabPageCustomerQuery.Controls.Add(this.labelEmail);
            this.tabPageCustomerQuery.Controls.Add(this.textBoxAddress);
            this.tabPageCustomerQuery.Controls.Add(this.labelAddress);
            this.tabPageCustomerQuery.Controls.Add(this.textBoxPhone);
            this.tabPageCustomerQuery.Controls.Add(this.labelPhone);
            this.tabPageCustomerQuery.Controls.Add(this.textBox1CustomerName);
            this.tabPageCustomerQuery.Controls.Add(this.label1CustomerName);
            this.tabPageCustomerQuery.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPageCustomerQuery.Location = new System.Drawing.Point(4, 28);
            this.tabPageCustomerQuery.Name = "tabPageCustomerQuery";
            this.tabPageCustomerQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomerQuery.Size = new System.Drawing.Size(1170, 594);
            this.tabPageCustomerQuery.TabIndex = 0;
            this.tabPageCustomerQuery.Text = "客戶查詢";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 36);
            this.textBox1.TabIndex = 13;
            // 
            // labelTaxId
            // 
            this.labelTaxId.AutoSize = true;
            this.labelTaxId.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTaxId.Location = new System.Drawing.Point(24, 67);
            this.labelTaxId.Name = "labelTaxId";
            this.labelTaxId.Size = new System.Drawing.Size(110, 24);
            this.labelTaxId.TabIndex = 12;
            this.labelTaxId.Text = "統一編號";
            // 
            // button1Cancel
            // 
            this.button1Cancel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1Cancel.Location = new System.Drawing.Point(270, 270);
            this.button1Cancel.Name = "button1Cancel";
            this.button1Cancel.Size = new System.Drawing.Size(100, 36);
            this.button1Cancel.TabIndex = 11;
            this.button1Cancel.Text = "取消";
            this.button1Cancel.UseVisualStyleBackColor = false;
            // 
            // buttonCustomerQuery
            // 
            this.buttonCustomerQuery.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonCustomerQuery.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCustomerQuery.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCustomerQuery.Location = new System.Drawing.Point(136, 270);
            this.buttonCustomerQuery.Name = "buttonCustomerQuery";
            this.buttonCustomerQuery.Size = new System.Drawing.Size(100, 36);
            this.buttonCustomerQuery.TabIndex = 10;
            this.buttonCustomerQuery.Text = "查詢";
            this.buttonCustomerQuery.UseVisualStyleBackColor = false;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(136, 217);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(350, 36);
            this.textBoxEmail.TabIndex = 9;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelEmail.Location = new System.Drawing.Point(20, 220);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(110, 24);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "電子郵件";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(136, 167);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(350, 36);
            this.textBoxAddress.TabIndex = 7;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelAddress.Location = new System.Drawing.Point(20, 170);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(110, 24);
            this.labelAddress.TabIndex = 6;
            this.labelAddress.Text = "聯絡地址";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(136, 117);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(350, 36);
            this.textBoxPhone.TabIndex = 5;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelPhone.Location = new System.Drawing.Point(20, 120);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(110, 24);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "連絡電話";
            // 
            // textBox1CustomerName
            // 
            this.textBox1CustomerName.Location = new System.Drawing.Point(136, 17);
            this.textBox1CustomerName.Name = "textBox1CustomerName";
            this.textBox1CustomerName.Size = new System.Drawing.Size(350, 36);
            this.textBox1CustomerName.TabIndex = 2;
            // 
            // label1CustomerName
            // 
            this.label1CustomerName.AutoSize = true;
            this.label1CustomerName.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1CustomerName.Location = new System.Drawing.Point(20, 20);
            this.label1CustomerName.Name = "label1CustomerName";
            this.label1CustomerName.Size = new System.Drawing.Size(110, 24);
            this.label1CustomerName.TabIndex = 1;
            this.label1CustomerName.Text = "客戶名稱";
            // 
            // tabPageRepairQuery
            // 
            this.tabPageRepairQuery.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPageRepairQuery.Controls.Add(this.dateTimePickerEndTimeRange);
            this.tabPageRepairQuery.Controls.Add(this.labelSim1);
            this.tabPageRepairQuery.Controls.Add(this.labelSim);
            this.tabPageRepairQuery.Controls.Add(this.dateTimePickerStartTimeRange);
            this.tabPageRepairQuery.Controls.Add(this.button2Cancel);
            this.tabPageRepairQuery.Controls.Add(this.buttonRepairQuery);
            this.tabPageRepairQuery.Controls.Add(this.dateTimePickerEndTime);
            this.tabPageRepairQuery.Controls.Add(this.labelEndTime);
            this.tabPageRepairQuery.Controls.Add(this.dateTimePickerStartTime);
            this.tabPageRepairQuery.Controls.Add(this.labelStartTime);
            this.tabPageRepairQuery.Controls.Add(this.textBoxEngineer);
            this.tabPageRepairQuery.Controls.Add(this.labelEngineer);
            this.tabPageRepairQuery.Controls.Add(this.comboBoxFaultDescription);
            this.tabPageRepairQuery.Controls.Add(this.labelFaultDescription);
            this.tabPageRepairQuery.Controls.Add(this.textBoxContactName);
            this.tabPageRepairQuery.Controls.Add(this.labelContactName);
            this.tabPageRepairQuery.Controls.Add(this.textBox2CustomerName);
            this.tabPageRepairQuery.Controls.Add(this.label2CustomerName);
            this.tabPageRepairQuery.Controls.Add(this.comboBoxType);
            this.tabPageRepairQuery.Controls.Add(this.labelType);
            this.tabPageRepairQuery.Controls.Add(this.checkBoxEnableStartTime);
            this.tabPageRepairQuery.Controls.Add(this.checkBoxEnableEndTime);
            this.tabPageRepairQuery.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPageRepairQuery.Location = new System.Drawing.Point(4, 28);
            this.tabPageRepairQuery.Name = "tabPageRepairQuery";
            this.tabPageRepairQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRepairQuery.Size = new System.Drawing.Size(1170, 594);
            this.tabPageRepairQuery.TabIndex = 1;
            this.tabPageRepairQuery.Text = "報修單查詢";
            // 
            // dateTimePickerEndTimeRange
            // 
            this.dateTimePickerEndTimeRange.Location = new System.Drawing.Point(490, 312);
            this.dateTimePickerEndTimeRange.Name = "dateTimePickerEndTimeRange";
            this.dateTimePickerEndTimeRange.Size = new System.Drawing.Size(270, 36);
            this.dateTimePickerEndTimeRange.TabIndex = 35;
            // 
            // labelSim1
            // 
            this.labelSim1.AutoSize = true;
            this.labelSim1.Location = new System.Drawing.Point(462, 320);
            this.labelSim1.Name = "labelSim1";
            this.labelSim1.Size = new System.Drawing.Size(22, 24);
            this.labelSim1.TabIndex = 34;
            this.labelSim1.Text = "~";
            // 
            // labelSim
            // 
            this.labelSim.AutoSize = true;
            this.labelSim.Location = new System.Drawing.Point(462, 270);
            this.labelSim.Name = "labelSim";
            this.labelSim.Size = new System.Drawing.Size(22, 24);
            this.labelSim.TabIndex = 33;
            this.labelSim.Text = "~";
            // 
            // dateTimePickerStartTimeRange
            // 
            this.dateTimePickerStartTimeRange.Location = new System.Drawing.Point(490, 263);
            this.dateTimePickerStartTimeRange.Name = "dateTimePickerStartTimeRange";
            this.dateTimePickerStartTimeRange.Size = new System.Drawing.Size(270, 36);
            this.dateTimePickerStartTimeRange.TabIndex = 32;
            // 
            // button2Cancel
            // 
            this.button2Cancel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2Cancel.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2Cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2Cancel.Location = new System.Drawing.Point(356, 370);
            this.button2Cancel.Name = "button2Cancel";
            this.button2Cancel.Size = new System.Drawing.Size(100, 36);
            this.button2Cancel.TabIndex = 27;
            this.button2Cancel.Text = "取消";
            this.button2Cancel.UseVisualStyleBackColor = false;
            // 
            // buttonRepairQuery
            // 
            this.buttonRepairQuery.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonRepairQuery.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonRepairQuery.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRepairQuery.Location = new System.Drawing.Point(186, 370);
            this.buttonRepairQuery.Name = "buttonRepairQuery";
            this.buttonRepairQuery.Size = new System.Drawing.Size(100, 36);
            this.buttonRepairQuery.TabIndex = 26;
            this.buttonRepairQuery.Text = "查詢";
            this.buttonRepairQuery.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerEndTime
            // 
            this.dateTimePickerEndTime.Location = new System.Drawing.Point(186, 312);
            this.dateTimePickerEndTime.Name = "dateTimePickerEndTime";
            this.dateTimePickerEndTime.Size = new System.Drawing.Size(270, 36);
            this.dateTimePickerEndTime.TabIndex = 25;
            // 
            // labelEndTime
            // 
            this.labelEndTime.AutoSize = true;
            this.labelEndTime.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelEndTime.Location = new System.Drawing.Point(20, 320);
            this.labelEndTime.Name = "labelEndTime";
            this.labelEndTime.Size = new System.Drawing.Size(160, 24);
            this.labelEndTime.TabIndex = 24;
            this.labelEndTime.Text = "完修時間查詢";
            // 
            // dateTimePickerStartTime
            // 
            this.dateTimePickerStartTime.Location = new System.Drawing.Point(186, 263);
            this.dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            this.dateTimePickerStartTime.Size = new System.Drawing.Size(270, 36);
            this.dateTimePickerStartTime.TabIndex = 23;
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelStartTime.Location = new System.Drawing.Point(20, 271);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(160, 24);
            this.labelStartTime.TabIndex = 22;
            this.labelStartTime.Text = "報修時間查詢";
            // 
            // textBoxEngineer
            // 
            this.textBoxEngineer.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxEngineer.Location = new System.Drawing.Point(186, 207);
            this.textBoxEngineer.Name = "textBoxEngineer";
            this.textBoxEngineer.Size = new System.Drawing.Size(240, 36);
            this.textBoxEngineer.TabIndex = 19;
            // 
            // labelEngineer
            // 
            this.labelEngineer.AutoSize = true;
            this.labelEngineer.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelEngineer.Location = new System.Drawing.Point(95, 210);
            this.labelEngineer.Name = "labelEngineer";
            this.labelEngineer.Size = new System.Drawing.Size(85, 24);
            this.labelEngineer.TabIndex = 18;
            this.labelEngineer.Text = "工程師";
            // 
            // comboBoxFaultDescription
            // 
            this.comboBoxFaultDescription.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxFaultDescription.FormattingEnabled = true;
            this.comboBoxFaultDescription.Location = new System.Drawing.Point(186, 157);
            this.comboBoxFaultDescription.Name = "comboBoxFaultDescription";
            this.comboBoxFaultDescription.Size = new System.Drawing.Size(240, 32);
            this.comboBoxFaultDescription.TabIndex = 13;
            // 
            // labelFaultDescription
            // 
            this.labelFaultDescription.AutoSize = true;
            this.labelFaultDescription.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelFaultDescription.Location = new System.Drawing.Point(70, 160);
            this.labelFaultDescription.Name = "labelFaultDescription";
            this.labelFaultDescription.Size = new System.Drawing.Size(110, 24);
            this.labelFaultDescription.TabIndex = 12;
            this.labelFaultDescription.Text = "故障現象";
            // 
            // textBoxContactName
            // 
            this.textBoxContactName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxContactName.Location = new System.Drawing.Point(186, 107);
            this.textBoxContactName.Name = "textBoxContactName";
            this.textBoxContactName.Size = new System.Drawing.Size(240, 36);
            this.textBoxContactName.TabIndex = 6;
            // 
            // labelContactName
            // 
            this.labelContactName.AutoSize = true;
            this.labelContactName.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelContactName.Location = new System.Drawing.Point(45, 110);
            this.labelContactName.Name = "labelContactName";
            this.labelContactName.Size = new System.Drawing.Size(135, 24);
            this.labelContactName.TabIndex = 5;
            this.labelContactName.Text = "叫修人姓名";
            // 
            // textBox2CustomerName
            // 
            this.textBox2CustomerName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2CustomerName.Location = new System.Drawing.Point(186, 61);
            this.textBox2CustomerName.Name = "textBox2CustomerName";
            this.textBox2CustomerName.Size = new System.Drawing.Size(350, 36);
            this.textBox2CustomerName.TabIndex = 4;
            // 
            // label2CustomerName
            // 
            this.label2CustomerName.AutoSize = true;
            this.label2CustomerName.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2CustomerName.Location = new System.Drawing.Point(70, 64);
            this.label2CustomerName.Name = "label2CustomerName";
            this.label2CustomerName.Size = new System.Drawing.Size(110, 24);
            this.label2CustomerName.TabIndex = 3;
            this.label2CustomerName.Text = "客戶名稱";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(186, 17);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(180, 32);
            this.comboBoxType.TabIndex = 2;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelType.Location = new System.Drawing.Point(95, 20);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(60, 24);
            this.labelType.TabIndex = 1;
            this.labelType.Text = "類型";
            // 
            // checkBoxEnableStartTime
            // 
            this.checkBoxEnableStartTime.AutoSize = true;
            this.checkBoxEnableStartTime.Location = new System.Drawing.Point(766, 270);
            this.checkBoxEnableStartTime.Name = "checkBoxEnableStartTime";
            this.checkBoxEnableStartTime.Size = new System.Drawing.Size(84, 28);
            this.checkBoxEnableStartTime.TabIndex = 30;
            this.checkBoxEnableStartTime.Text = "啟用";
            this.checkBoxEnableStartTime.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnableEndTime
            // 
            this.checkBoxEnableEndTime.AutoSize = true;
            this.checkBoxEnableEndTime.Location = new System.Drawing.Point(766, 319);
            this.checkBoxEnableEndTime.Name = "checkBoxEnableEndTime";
            this.checkBoxEnableEndTime.Size = new System.Drawing.Size(84, 28);
            this.checkBoxEnableEndTime.TabIndex = 31;
            this.checkBoxEnableEndTime.Text = "啟用";
            this.checkBoxEnableEndTime.UseVisualStyleBackColor = true;
            // 
            // tabPageQueryResult
            // 
            this.tabPageQueryResult.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPageQueryResult.Controls.Add(this.panelQueryResult);
            this.tabPageQueryResult.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPageQueryResult.Location = new System.Drawing.Point(4, 28);
            this.tabPageQueryResult.Name = "tabPageQueryResult";
            this.tabPageQueryResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQueryResult.Size = new System.Drawing.Size(1170, 594);
            this.tabPageQueryResult.TabIndex = 2;
            this.tabPageQueryResult.Text = "查詢結果";
            // 
            // panelQueryResult
            // 
            this.panelQueryResult.Controls.Add(this.buttonGo);
            this.panelQueryResult.Controls.Add(this.textBoxPage);
            this.panelQueryResult.Controls.Add(this.labelPageInfo);
            this.panelQueryResult.Controls.Add(this.comboBoxLine);
            this.panelQueryResult.Controls.Add(this.labelLine);
            this.panelQueryResult.Controls.Add(this.buttonNext);
            this.panelQueryResult.Controls.Add(this.buttonPrev);
            this.panelQueryResult.Controls.Add(this.buttonLast);
            this.panelQueryResult.Controls.Add(this.buttonFirst);
            this.panelQueryResult.Controls.Add(this.dataGridViewQuery);
            this.panelQueryResult.Controls.Add(this.buttonExportExcel);
            this.panelQueryResult.Controls.Add(this.labelResult);
            this.panelQueryResult.Location = new System.Drawing.Point(0, 20);
            this.panelQueryResult.Name = "panelQueryResult";
            this.panelQueryResult.Size = new System.Drawing.Size(1166, 566);
            this.panelQueryResult.TabIndex = 2;
            // 
            // buttonGo
            // 
            this.buttonGo.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonGo.Location = new System.Drawing.Point(570, 37);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(50, 30);
            this.buttonGo.TabIndex = 12;
            this.buttonGo.Text = "GO";
            this.buttonGo.UseVisualStyleBackColor = true;
            // 
            // textBoxPage
            // 
            this.textBoxPage.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxPage.Location = new System.Drawing.Point(510, 38);
            this.textBoxPage.Name = "textBoxPage";
            this.textBoxPage.Size = new System.Drawing.Size(50, 29);
            this.textBoxPage.TabIndex = 11;
            this.textBoxPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPageInfo
            // 
            this.labelPageInfo.AutoSize = true;
            this.labelPageInfo.Location = new System.Drawing.Point(470, 10);
            this.labelPageInfo.Name = "labelPageInfo";
            this.labelPageInfo.Size = new System.Drawing.Size(0, 24);
            this.labelPageInfo.TabIndex = 10;
            // 
            // comboBoxLine
            // 
            this.comboBoxLine.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxLine.FormattingEnabled = true;
            this.comboBoxLine.Location = new System.Drawing.Point(740, 38);
            this.comboBoxLine.Name = "comboBoxLine";
            this.comboBoxLine.Size = new System.Drawing.Size(80, 26);
            this.comboBoxLine.TabIndex = 8;
            // 
            // labelLine
            // 
            this.labelLine.AutoSize = true;
            this.labelLine.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelLine.Location = new System.Drawing.Point(650, 41);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(84, 18);
            this.labelLine.TabIndex = 7;
            this.labelLine.Text = "顯示列數";
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonNext.Location = new System.Drawing.Point(300, 35);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(80, 30);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "下一頁";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonPrev
            // 
            this.buttonPrev.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonPrev.Location = new System.Drawing.Point(200, 35);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(80, 30);
            this.buttonPrev.TabIndex = 5;
            this.buttonPrev.Text = "上一頁";
            this.buttonPrev.UseVisualStyleBackColor = true;
            // 
            // buttonLast
            // 
            this.buttonLast.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonLast.Location = new System.Drawing.Point(400, 35);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(80, 30);
            this.buttonLast.TabIndex = 4;
            this.buttonLast.Text = "尾頁";
            this.buttonLast.UseVisualStyleBackColor = true;
            // 
            // buttonFirst
            // 
            this.buttonFirst.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonFirst.Location = new System.Drawing.Point(110, 35);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(80, 30);
            this.buttonFirst.TabIndex = 3;
            this.buttonFirst.Text = "第一頁";
            this.buttonFirst.UseVisualStyleBackColor = true;
            // 
            // dataGridViewQuery
            // 
            this.dataGridViewQuery.AllowUserToAddRows = false;
            this.dataGridViewQuery.AllowUserToDeleteRows = false;
            this.dataGridViewQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuery.Location = new System.Drawing.Point(20, 75);
            this.dataGridViewQuery.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewQuery.Name = "dataGridViewQuery";
            this.dataGridViewQuery.RowHeadersWidth = 62;
            this.dataGridViewQuery.RowTemplate.Height = 31;
            this.dataGridViewQuery.Size = new System.Drawing.Size(1124, 474);
            this.dataGridViewQuery.TabIndex = 2;
            // 
            // buttonExportExcel
            // 
            this.buttonExportExcel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonExportExcel.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonExportExcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExportExcel.Location = new System.Drawing.Point(900, 37);
            this.buttonExportExcel.Name = "buttonExportExcel";
            this.buttonExportExcel.Size = new System.Drawing.Size(120, 30);
            this.buttonExportExcel.TabIndex = 1;
            this.buttonExportExcel.Text = "查詢匯出Excel";
            this.buttonExportExcel.UseVisualStyleBackColor = false;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(3, 3);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(112, 24);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "查詢結果:";
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 704);
            this.Controls.Add(this.tabControlQuery);
            this.Controls.Add(this.panelQueryTop);
            this.Name = "QueryForm";
            this.Text = "查詢表單";
            this.panelQueryTop.ResumeLayout(false);
            this.panelQueryTop.PerformLayout();
            this.tabControlQuery.ResumeLayout(false);
            this.tabPageCustomerQuery.ResumeLayout(false);
            this.tabPageCustomerQuery.PerformLayout();
            this.tabPageRepairQuery.ResumeLayout(false);
            this.tabPageRepairQuery.PerformLayout();
            this.tabPageQueryResult.ResumeLayout(false);
            this.panelQueryResult.ResumeLayout(false);
            this.panelQueryResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelQueryTop;
        private System.Windows.Forms.Label labelQueryForm;
        private System.Windows.Forms.TabControl tabControlQuery;
        private System.Windows.Forms.TabPage tabPageCustomerQuery;
        private System.Windows.Forms.TabPage tabPageQueryResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonExportExcel;
        private System.Windows.Forms.DataGridView dataGridViewQuery;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.ComboBox comboBoxLine;
        private System.Windows.Forms.Panel panelQueryResult;
        private System.Windows.Forms.Label labelPageInfo;
        private System.Windows.Forms.TextBox textBoxPage;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Label label1CustomerName;
        private System.Windows.Forms.TextBox textBox1CustomerName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonCustomerQuery;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button button1Cancel;
        private System.Windows.Forms.TabPage tabPageRepairQuery;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndTime;
        private System.Windows.Forms.Label labelEndTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartTime;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.TextBox textBoxEngineer;
        private System.Windows.Forms.Label labelEngineer;
        private System.Windows.Forms.ComboBox comboBoxFaultDescription;
        private System.Windows.Forms.Label labelFaultDescription;
        private System.Windows.Forms.TextBox textBoxContactName;
        private System.Windows.Forms.Label labelContactName;
        private System.Windows.Forms.TextBox textBox2CustomerName;
        private System.Windows.Forms.Label label2CustomerName;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Button button2Cancel;
        private System.Windows.Forms.Button buttonRepairQuery;
        private System.Windows.Forms.CheckBox checkBoxEnableStartTime;
        private System.Windows.Forms.CheckBox checkBoxEnableEndTime;
        private System.Windows.Forms.Label labelTaxId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelSim;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartTimeRange;
        private System.Windows.Forms.Label labelSim1;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndTimeRange;
    }
}