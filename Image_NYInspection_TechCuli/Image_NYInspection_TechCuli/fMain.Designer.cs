namespace Image_NYInspection_TechCuli
{
    partial class fMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.pModeTime = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.stop_datetime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.str_datetime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDSearch = new System.Windows.Forms.TextBox();
            this.cbbSelectMode = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pToolMain = new System.Windows.Forms.Panel();
            this.btnSaveLimit = new System.Windows.Forms.Button();
            this.Limit = new System.Windows.Forms.Label();
            this.nmShowLimit = new System.Windows.Forms.NumericUpDown();
            this.btnSnipt = new System.Windows.Forms.Button();
            this.btnFindLink = new System.Windows.Forms.Button();
            this.btnLinkSave = new System.Windows.Forms.Button();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbLine = new System.Windows.Forms.ComboBox();
            this.pModeConfig = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfig = new System.Windows.Forms.TextBox();
            this.pModeID = new System.Windows.Forms.Panel();
            this.txtShowID = new System.Windows.Forms.TextBox();
            this.pDataShow = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblSumPage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.DtgShowData = new System.Windows.Forms.DataGridView();
            this.lblPageNow = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMachine = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblquyenhan = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlTool3 = new System.Windows.Forms.Panel();
            this.pModeTime.SuspendLayout();
            this.pToolMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmShowLimit)).BeginInit();
            this.pModeConfig.SuspendLayout();
            this.pModeID.SuspendLayout();
            this.pDataShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgShowData)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlTool3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 91;
            this.label7.Text = "MODE";
            // 
            // pModeTime
            // 
            this.pModeTime.Controls.Add(this.label6);
            this.pModeTime.Controls.Add(this.stop_datetime);
            this.pModeTime.Controls.Add(this.label5);
            this.pModeTime.Controls.Add(this.str_datetime);
            this.pModeTime.Enabled = false;
            this.pModeTime.Location = new System.Drawing.Point(4, 201);
            this.pModeTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pModeTime.Name = "pModeTime";
            this.pModeTime.Size = new System.Drawing.Size(281, 82);
            this.pModeTime.TabIndex = 89;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 85;
            this.label6.Text = "End";
            // 
            // stop_datetime
            // 
            this.stop_datetime.CustomFormat = "  yyyy-MM-dd HH:mm:ss";
            this.stop_datetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_datetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.stop_datetime.Location = new System.Drawing.Point(61, 43);
            this.stop_datetime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stop_datetime.MaximumSize = new System.Drawing.Size(250, 22);
            this.stop_datetime.Name = "stop_datetime";
            this.stop_datetime.Size = new System.Drawing.Size(184, 22);
            this.stop_datetime.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 84;
            this.label5.Text = "Start";
            // 
            // str_datetime
            // 
            this.str_datetime.CustomFormat = "  yyyy-MM-dd HH:mm:ss";
            this.str_datetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.str_datetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.str_datetime.Location = new System.Drawing.Point(61, 4);
            this.str_datetime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.str_datetime.MaximumSize = new System.Drawing.Size(250, 22);
            this.str_datetime.Name = "str_datetime";
            this.str_datetime.Size = new System.Drawing.Size(184, 22);
            this.str_datetime.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 15);
            this.label4.TabIndex = 79;
            this.label4.Text = "ID";
            // 
            // txtIDSearch
            // 
            this.txtIDSearch.Location = new System.Drawing.Point(61, 8);
            this.txtIDSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDSearch.Multiline = true;
            this.txtIDSearch.Name = "txtIDSearch";
            this.txtIDSearch.Size = new System.Drawing.Size(184, 21);
            this.txtIDSearch.TabIndex = 78;
            this.txtIDSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIDSearch_KeyDown);
            // 
            // cbbSelectMode
            // 
            this.cbbSelectMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbSelectMode.DropDownHeight = 200;
            this.cbbSelectMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSelectMode.FormattingEnabled = true;
            this.cbbSelectMode.IntegralHeight = false;
            this.cbbSelectMode.Items.AddRange(new object[] {
            "Config",
            "ID",
            "Time"});
            this.cbbSelectMode.Location = new System.Drawing.Point(64, 17);
            this.cbbSelectMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbSelectMode.MaximumSize = new System.Drawing.Size(205, 0);
            this.cbbSelectMode.Name = "cbbSelectMode";
            this.cbbSelectMode.Size = new System.Drawing.Size(184, 23);
            this.cbbSelectMode.TabIndex = 86;
            this.cbbSelectMode.SelectedIndexChanged += new System.EventHandler(this.cbbSelectMode_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(4, 292);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(77, 44);
            this.btnSearch.TabIndex = 72;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pToolMain
            // 
            this.pToolMain.Controls.Add(this.btnSnipt);
            this.pToolMain.Controls.Add(this.btnFindLink);
            this.pToolMain.Controls.Add(this.btnLinkSave);
            this.pToolMain.Controls.Add(this.txtLink);
            this.pToolMain.Controls.Add(this.label7);
            this.pToolMain.Controls.Add(this.btnSearch);
            this.pToolMain.Controls.Add(this.pModeTime);
            this.pToolMain.Controls.Add(this.cbbSelectMode);
            this.pToolMain.Controls.Add(this.label2);
            this.pToolMain.Controls.Add(this.cbbLine);
            this.pToolMain.Controls.Add(this.pModeConfig);
            this.pToolMain.Controls.Add(this.pModeID);
            this.pToolMain.Controls.Add(this.panel2);
            this.pToolMain.Controls.Add(this.pnlTool3);
            this.pToolMain.Location = new System.Drawing.Point(14, 31);
            this.pToolMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pToolMain.Name = "pToolMain";
            this.pToolMain.Size = new System.Drawing.Size(288, 934);
            this.pToolMain.TabIndex = 94;
            // 
            // btnSaveLimit
            // 
            this.btnSaveLimit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSaveLimit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveLimit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveLimit.Location = new System.Drawing.Point(229, 6);
            this.btnSaveLimit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveLimit.Name = "btnSaveLimit";
            this.btnSaveLimit.Size = new System.Drawing.Size(44, 22);
            this.btnSaveLimit.TabIndex = 98;
            this.btnSaveLimit.Text = "Save";
            this.btnSaveLimit.UseVisualStyleBackColor = false;
            this.btnSaveLimit.Click += new System.EventHandler(this.btnSaveLimit_Click);
            // 
            // Limit
            // 
            this.Limit.AutoSize = true;
            this.Limit.Location = new System.Drawing.Point(4, 10);
            this.Limit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Limit.Name = "Limit";
            this.Limit.Size = new System.Drawing.Size(33, 15);
            this.Limit.TabIndex = 97;
            this.Limit.Text = "Limit";
            // 
            // nmShowLimit
            // 
            this.nmShowLimit.Location = new System.Drawing.Point(56, 7);
            this.nmShowLimit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nmShowLimit.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nmShowLimit.Name = "nmShowLimit";
            this.nmShowLimit.Size = new System.Drawing.Size(166, 22);
            this.nmShowLimit.TabIndex = 96;
            // 
            // btnSnipt
            // 
            this.btnSnipt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSnipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSnipt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSnipt.Location = new System.Drawing.Point(88, 292);
            this.btnSnipt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSnipt.Name = "btnSnipt";
            this.btnSnipt.Size = new System.Drawing.Size(77, 44);
            this.btnSnipt.TabIndex = 95;
            this.btnSnipt.Text = "Snipt";
            this.btnSnipt.UseVisualStyleBackColor = false;
            this.btnSnipt.Click += new System.EventHandler(this.btnSnipt_Click);
            // 
            // btnFindLink
            // 
            this.btnFindLink.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFindLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindLink.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFindLink.Location = new System.Drawing.Point(237, 345);
            this.btnFindLink.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFindLink.Name = "btnFindLink";
            this.btnFindLink.Size = new System.Drawing.Size(44, 22);
            this.btnFindLink.TabIndex = 94;
            this.btnFindLink.Text = "Find";
            this.btnFindLink.UseVisualStyleBackColor = false;
            this.btnFindLink.Click += new System.EventHandler(this.btnFindLink_Click);
            // 
            // btnLinkSave
            // 
            this.btnLinkSave.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLinkSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLinkSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLinkSave.Location = new System.Drawing.Point(4, 377);
            this.btnLinkSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLinkSave.Name = "btnLinkSave";
            this.btnLinkSave.Size = new System.Drawing.Size(77, 31);
            this.btnLinkSave.TabIndex = 93;
            this.btnLinkSave.Text = "Save";
            this.btnLinkSave.UseVisualStyleBackColor = false;
            this.btnLinkSave.Click += new System.EventHandler(this.btnLinkSave_Click);
            // 
            // txtLink
            // 
            this.txtLink.Enabled = false;
            this.txtLink.Location = new System.Drawing.Point(4, 345);
            this.txtLink.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLink.Name = "txtLink";
            this.txtLink.ReadOnly = true;
            this.txtLink.Size = new System.Drawing.Size(226, 22);
            this.txtLink.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 77;
            this.label2.Text = "Line";
            // 
            // cbbLine
            // 
            this.cbbLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbLine.DropDownHeight = 200;
            this.cbbLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLine.FormattingEnabled = true;
            this.cbbLine.IntegralHeight = false;
            this.cbbLine.Location = new System.Drawing.Point(64, 62);
            this.cbbLine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbLine.MaximumSize = new System.Drawing.Size(205, 0);
            this.cbbLine.Name = "cbbLine";
            this.cbbLine.Size = new System.Drawing.Size(184, 23);
            this.cbbLine.TabIndex = 74;
            this.cbbLine.SelectedIndexChanged += new System.EventHandler(this.cbbLine_SelectedIndexChanged);
            // 
            // pModeConfig
            // 
            this.pModeConfig.BackColor = System.Drawing.Color.IndianRed;
            this.pModeConfig.Controls.Add(this.label1);
            this.pModeConfig.Controls.Add(this.txtConfig);
            this.pModeConfig.Location = new System.Drawing.Point(4, 98);
            this.pModeConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pModeConfig.Name = "pModeConfig";
            this.pModeConfig.Size = new System.Drawing.Size(281, 45);
            this.pModeConfig.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 80;
            this.label1.Text = "Config";
            // 
            // txtConfig
            // 
            this.txtConfig.Location = new System.Drawing.Point(61, 10);
            this.txtConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfig.Name = "txtConfig";
            this.txtConfig.Size = new System.Drawing.Size(184, 22);
            this.txtConfig.TabIndex = 75;
            // 
            // pModeID
            // 
            this.pModeID.Controls.Add(this.label4);
            this.pModeID.Controls.Add(this.txtIDSearch);
            this.pModeID.Enabled = false;
            this.pModeID.Location = new System.Drawing.Point(4, 150);
            this.pModeID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pModeID.Name = "pModeID";
            this.pModeID.Size = new System.Drawing.Size(281, 44);
            this.pModeID.TabIndex = 88;
            // 
            // txtShowID
            // 
            this.txtShowID.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtShowID.ForeColor = System.Drawing.Color.Lime;
            this.txtShowID.HideSelection = false;
            this.txtShowID.Location = new System.Drawing.Point(309, 48);
            this.txtShowID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtShowID.Multiline = true;
            this.txtShowID.Name = "txtShowID";
            this.txtShowID.ReadOnly = true;
            this.txtShowID.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtShowID.Size = new System.Drawing.Size(433, 916);
            this.txtShowID.TabIndex = 92;
            // 
            // pDataShow
            // 
            this.pDataShow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pDataShow.Controls.Add(this.label8);
            this.pDataShow.Controls.Add(this.lblCount);
            this.pDataShow.Controls.Add(this.lblSumPage);
            this.pDataShow.Controls.Add(this.label3);
            this.pDataShow.Controls.Add(this.btnNext);
            this.pDataShow.Controls.Add(this.DtgShowData);
            this.pDataShow.Controls.Add(this.lblPageNow);
            this.pDataShow.Controls.Add(this.btnBack);
            this.pDataShow.Location = new System.Drawing.Point(750, 30);
            this.pDataShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pDataShow.Name = "pDataShow";
            this.pDataShow.Size = new System.Drawing.Size(750, 935);
            this.pDataShow.TabIndex = 93;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(89, -3);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 71;
            this.label8.Text = "Count:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCount.Location = new System.Drawing.Point(140, -3);
            this.lblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(19, 15);
            this.lblCount.TabIndex = 70;
            this.lblCount.Text = "00";
            // 
            // lblSumPage
            // 
            this.lblSumPage.AutoSize = true;
            this.lblSumPage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSumPage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSumPage.Location = new System.Drawing.Point(59, 9);
            this.lblSumPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSumPage.Name = "lblSumPage";
            this.lblSumPage.Size = new System.Drawing.Size(19, 15);
            this.lblSumPage.TabIndex = 69;
            this.lblSumPage.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(40, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 15);
            this.label3.TabIndex = 68;
            this.label3.Text = "/";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(6, 31);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(77, 44);
            this.btnNext.TabIndex = 66;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // DtgShowData
            // 
            this.DtgShowData.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgShowData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgShowData.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgShowData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtgShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgShowData.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgShowData.DefaultCellStyle = dataGridViewCellStyle3;
            this.DtgShowData.Location = new System.Drawing.Point(90, 18);
            this.DtgShowData.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DtgShowData.Name = "DtgShowData";
            this.DtgShowData.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgShowData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DtgShowData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DtgShowData.Size = new System.Drawing.Size(646, 900);
            this.DtgShowData.TabIndex = 63;
            // 
            // lblPageNow
            // 
            this.lblPageNow.AutoSize = true;
            this.lblPageNow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPageNow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPageNow.Location = new System.Drawing.Point(7, 9);
            this.lblPageNow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPageNow.Name = "lblPageNow";
            this.lblPageNow.Size = new System.Drawing.Size(19, 15);
            this.lblPageNow.TabIndex = 67;
            this.lblPageNow.Text = "00";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(6, 86);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(77, 44);
            this.btnBack.TabIndex = 65;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(10, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1490, 939);
            this.panel1.TabIndex = 95;
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.Location = new System.Drawing.Point(82, 210);
            this.lblMachine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(54, 15);
            this.lblMachine.TabIndex = 109;
            this.lblMachine.Text = "Machine";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 210);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 15);
            this.label15.TabIndex = 108;
            this.label15.Text = "Machine";
            // 
            // lblTime1
            // 
            this.lblTime1.AutoSize = true;
            this.lblTime1.Location = new System.Drawing.Point(82, 168);
            this.lblTime1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(37, 15);
            this.lblTime1.TabIndex = 104;
            this.lblTime1.Text = "Timer";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 168);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 15);
            this.label13.TabIndex = 102;
            this.label13.Text = "Timer ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 125);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 15);
            this.label11.TabIndex = 107;
            this.label11.Text = "Power";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(80, 84);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 15);
            this.lblName.TabIndex = 106;
            this.lblName.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 84);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 103;
            this.label10.Text = "Name";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(80, 48);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(32, 15);
            this.lblUser.TabIndex = 105;
            this.lblUser.Text = "User";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 48);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 15);
            this.label12.TabIndex = 101;
            this.label12.Text = "User";
            // 
            // lblquyenhan
            // 
            this.lblquyenhan.AutoSize = true;
            this.lblquyenhan.Location = new System.Drawing.Point(78, 125);
            this.lblquyenhan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblquyenhan.Name = "lblquyenhan";
            this.lblquyenhan.Size = new System.Drawing.Size(13, 15);
            this.lblquyenhan.TabIndex = 100;
            this.lblquyenhan.Text = "0";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.lblMachine);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.lblTime1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lblUser);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lblquyenhan);
            this.panel2.Location = new System.Drawing.Point(4, 449);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 241);
            this.panel2.TabIndex = 110;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.IndianRed;
            this.label9.Location = new System.Drawing.Point(180, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 15);
            this.label9.TabIndex = 110;
            this.label9.Text = "User Infomation";
            // 
            // pnlTool3
            // 
            this.pnlTool3.Controls.Add(this.Limit);
            this.pnlTool3.Controls.Add(this.btnSaveLimit);
            this.pnlTool3.Controls.Add(this.nmShowLimit);
            this.pnlTool3.Location = new System.Drawing.Point(8, 411);
            this.pnlTool3.Name = "pnlTool3";
            this.pnlTool3.Size = new System.Drawing.Size(279, 38);
            this.pnlTool3.TabIndex = 111;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1500, 971);
            this.Controls.Add(this.txtShowID);
            this.Controls.Add(this.pDataShow);
            this.Controls.Add(this.pToolMain);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1516, 1010);
            this.MinimumSize = new System.Drawing.Size(1516, 1010);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snipt_TTP";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.pModeTime.ResumeLayout(false);
            this.pModeTime.PerformLayout();
            this.pToolMain.ResumeLayout(false);
            this.pToolMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmShowLimit)).EndInit();
            this.pModeConfig.ResumeLayout(false);
            this.pModeConfig.PerformLayout();
            this.pModeID.ResumeLayout(false);
            this.pModeID.PerformLayout();
            this.pDataShow.ResumeLayout(false);
            this.pDataShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgShowData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlTool3.ResumeLayout(false);
            this.pnlTool3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pModeTime;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.DateTimePicker stop_datetime;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.DateTimePicker str_datetime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDSearch;
        private System.Windows.Forms.ComboBox cbbSelectMode;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pToolMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbLine;
        private System.Windows.Forms.Panel pModeConfig;
        private System.Windows.Forms.TextBox txtConfig;
        private System.Windows.Forms.Panel pModeID;
        private System.Windows.Forms.TextBox txtShowID;
        private System.Windows.Forms.Panel pDataShow;
        private System.Windows.Forms.Label lblSumPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridView DtgShowData;
        private System.Windows.Forms.Label lblPageNow;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFindLink;
        private System.Windows.Forms.Button btnLinkSave;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Button btnSnipt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Limit;
        private System.Windows.Forms.NumericUpDown nmShowLimit;
        private System.Windows.Forms.Button btnSaveLimit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblquyenhan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlTool3;
    }
}