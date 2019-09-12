namespace LowerApplication.Forms
{
    partial class frmCase
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCases = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colCaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCaseSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchKeyword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cbxCaseParameters = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.AdminNumber = new DevComponents.Editors.ComboItem();
            this.FineNumber = new DevComponents.Editors.ComboItem();
            this.InvestigationNumber = new DevComponents.Editors.ComboItem();
            this.ImprisonmentNumber = new DevComponents.Editors.ComboItem();
            this.PartialNumber = new DevComponents.Editors.ComboItem();
            this.TotalNumber = new DevComponents.Editors.ComboItem();
            this.DelegationNumber = new DevComponents.Editors.ComboItem();
            this.CaseSubject = new DevComponents.Editors.ComboItem();
            this.DelegatorName = new DevComponents.Editors.ComboItem();
            this.DelegatorSSN = new DevComponents.Editors.ComboItem();
            this.DelegatorMobile = new DevComponents.Editors.ComboItem();
            this.tcCaseDetails = new DevComponents.DotNetBar.TabControl();
            this.tpDelegators = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanel9 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnAddDelegator = new DevComponents.DotNetBar.ButtonX();
            this.labelX32 = new DevComponents.DotNetBar.LabelX();
            this.labelX33 = new DevComponents.DotNetBar.LabelX();
            this.labelX34 = new DevComponents.DotNetBar.LabelX();
            this.labelX36 = new DevComponents.DotNetBar.LabelX();
            this.labelX35 = new DevComponents.DotNetBar.LabelX();
            this.labelX37 = new DevComponents.DotNetBar.LabelX();
            this.txtDelegatorDetails = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDelegatorSSN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDelegatorPhone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX38 = new DevComponents.DotNetBar.LabelX();
            this.txtCase_Del_Notes = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDelegatorMobile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDelegatorAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDelegatorName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel8 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvDelegators = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colDelegatorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelegatorAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelegatorSSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelegatorPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelegatorMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelegatorDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabItem4 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tpGeneralCaseData = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.iiadministrativeNumber = new DevComponents.Editors.IntegerInput();
            this.txtadministrativestring = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX17 = new DevComponents.DotNetBar.LabelX();
            this.txtfinestring = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtInvestigationString = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtImprisonString = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtPartialString = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.iiTotalNumber = new DevComponents.Editors.IntegerInput();
            this.txtTotalString = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.iiPartialNumber = new DevComponents.Editors.IntegerInput();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.iiImprisonmentNumber = new DevComponents.Editors.IntegerInput();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.iiInvestigationNumer = new DevComponents.Editors.IntegerInput();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.iifinenumber = new DevComponents.Editors.IntegerInput();
            this.labelX18 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnAddChamber = new DevComponents.DotNetBar.ButtonX();
            this.btnAddCourt = new DevComponents.DotNetBar.ButtonX();
            this.labelX19 = new DevComponents.DotNetBar.LabelX();
            this.dtRecievingDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cbxChamber = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX20 = new DevComponents.DotNetBar.LabelX();
            this.cbxCourt = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX21 = new DevComponents.DotNetBar.LabelX();
            this.labelX22 = new DevComponents.DotNetBar.LabelX();
            this.txtCaseDetails = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCaseSubject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblUseraName = new DevComponents.DotNetBar.LabelX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnAddDocumentationOffice = new DevComponents.DotNetBar.ButtonX();
            this.labelX23 = new DevComponents.DotNetBar.LabelX();
            this.labelX24 = new DevComponents.DotNetBar.LabelX();
            this.cbxDocumentationOffice = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX25 = new DevComponents.DotNetBar.LabelX();
            this.iiDelegationNumber = new DevComponents.Editors.IntegerInput();
            this.labelX26 = new DevComponents.DotNetBar.LabelX();
            this.txtDelegationString = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDelegationLetter = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tpSessions = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanel5 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnAddSession = new DevComponents.DotNetBar.ButtonX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.txtSessionNotes = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSessionOrders = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSessionDetails = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtRollNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX27 = new DevComponents.DotNetBar.LabelX();
            this.dtSessionDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.groupPanel4 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvSessions = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colSessionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSessionRollNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSessionDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSessionDecisions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSessionNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tpFees = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanel10 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.labelX39 = new DevComponents.DotNetBar.LabelX();
            this.labelX40 = new DevComponents.DotNetBar.LabelX();
            this.labelX41 = new DevComponents.DotNetBar.LabelX();
            this.labelX42 = new DevComponents.DotNetBar.LabelX();
            this.diTotalAmount = new DevComponents.Editors.DoubleInput();
            this.diInstallsAmount = new DevComponents.Editors.DoubleInput();
            this.diRetensionAmount = new DevComponents.Editors.DoubleInput();
            this.diPresentAmount = new DevComponents.Editors.DoubleInput();
            this.tabItem5 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tpCLowers = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanel7 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnAddCLower = new DevComponents.DotNetBar.ButtonX();
            this.labelX28 = new DevComponents.DotNetBar.LabelX();
            this.labelX31 = new DevComponents.DotNetBar.LabelX();
            this.labelX29 = new DevComponents.DotNetBar.LabelX();
            this.txtCLowerOtherDetails = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX30 = new DevComponents.DotNetBar.LabelX();
            this.txtCLowerOffice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCLowerPhone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCLowerName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel6 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvCLowers = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colClowerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClowerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClowerOffice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClowerDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabItem3 = new DevComponents.DotNetBar.TabItem(this.components);
            this.gpnlBody.SuspendLayout();
            this.ribnpnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._errorfrmProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcCaseDetails)).BeginInit();
            this.tcCaseDetails.SuspendLayout();
            this.tpDelegators.SuspendLayout();
            this.groupPanel9.SuspendLayout();
            this.groupPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelegators)).BeginInit();
            this.tpGeneralCaseData.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iiadministrativeNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iiTotalNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iiPartialNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iiImprisonmentNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iiInvestigationNumer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iifinenumber)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtRecievingDate)).BeginInit();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iiDelegationNumber)).BeginInit();
            this.tpSessions.SuspendLayout();
            this.groupPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtSessionDate)).BeginInit();
            this.groupPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).BeginInit();
            this.tpFees.SuspendLayout();
            this.groupPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diTotalAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diInstallsAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diRetensionAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diPresentAmount)).BeginInit();
            this.tpCLowers.SuspendLayout();
            this.groupPanel7.SuspendLayout();
            this.groupPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCLowers)).BeginInit();
            this.SuspendLayout();
            // 
            // gpnlBody
            // 
            this.gpnlBody.Controls.Add(this.tcCaseDetails);
            this.gpnlBody.Controls.Add(this.labelX4);
            this.gpnlBody.Controls.Add(this.cbxCaseParameters);
            this.gpnlBody.Controls.Add(this.dgvCases);
            this.gpnlBody.Controls.Add(this.labelX13);
            this.gpnlBody.Controls.Add(this.txtSearchKeyword);
            this.gpnlBody.Location = new System.Drawing.Point(5, 105);
            this.gpnlBody.Size = new System.Drawing.Size(1125, 623);
            // 
            // 
            // 
            this.gpnlBody.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpnlBody.Style.BackColorGradientAngle = 90;
            this.gpnlBody.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpnlBody.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpnlBody.Style.BorderBottomWidth = 1;
            this.gpnlBody.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpnlBody.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpnlBody.Style.BorderLeftWidth = 1;
            this.gpnlBody.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpnlBody.Style.BorderRightWidth = 1;
            this.gpnlBody.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpnlBody.Style.BorderTopWidth = 1;
            this.gpnlBody.Style.CornerDiameter = 4;
            this.gpnlBody.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpnlBody.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpnlBody.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpnlBody.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpnlBody.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpnlBody.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpnlBody.Controls.SetChildIndex(this.txtSearchKeyword, 0);
            this.gpnlBody.Controls.SetChildIndex(this.labelX13, 0);
            this.gpnlBody.Controls.SetChildIndex(this.barOperation, 0);
            this.gpnlBody.Controls.SetChildIndex(this.dgvCases, 0);
            this.gpnlBody.Controls.SetChildIndex(this.cbxCaseParameters, 0);
            this.gpnlBody.Controls.SetChildIndex(this.labelX4, 0);
            this.gpnlBody.Controls.SetChildIndex(this.tcCaseDetails, 0);
            // 
            // ribnpnlHeader
            // 
            this.ribnpnlHeader.Size = new System.Drawing.Size(1125, 104);
            // 
            // 
            // 
            this.ribnpnlHeader.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.ribnpnlHeader.Style.BackColorGradientAngle = 90;
            this.ribnpnlHeader.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.ribnpnlHeader.Style.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Tile;
            this.ribnpnlHeader.Style.BorderBottomWidth = 1;
            this.ribnpnlHeader.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.ribnpnlHeader.Style.BorderLeftWidth = 1;
            this.ribnpnlHeader.Style.BorderRightWidth = 1;
            this.ribnpnlHeader.Style.BorderTopWidth = 1;
            this.ribnpnlHeader.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribnpnlHeader.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.ribnpnlHeader.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            // 
            // 
            // 
            this.ribnpnlHeader.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribnpnlHeader.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // lblDetialsTitle
            // 
            // 
            // 
            // 
            this.lblDetialsTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDetialsTitle.Location = new System.Drawing.Point(260, 64);
            this.lblDetialsTitle.Size = new System.Drawing.Size(208, 16);
            this.lblDetialsTitle.Text = "تستخدم هذه النافـــذة في حفظ بيانات القضايا";
            // 
            // lblFormTitle
            // 
            // 
            // 
            // 
            this.lblFormTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblFormTitle.Location = new System.Drawing.Point(331, 24);
            this.lblFormTitle.Size = new System.Drawing.Size(64, 32);
            this.lblFormTitle.Text = "القضايا";
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = global::LowerApplication.Properties.Resources.Judge_icon;
            this.picBoxLogo.Location = new System.Drawing.Point(704, 8);
            this.picBoxLogo.Size = new System.Drawing.Size(115, 89);
            // 
            // barOperation
            // 
            this.barOperation.Size = new System.Drawing.Size(1119, 30);
            // 
            // btnNew
            // 
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // _errorfrmSuperValidator
            // 
            this._errorfrmSuperValidator.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // _errorfrmHighlighter
            // 
            this._errorfrmHighlighter.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // dgvCases
            // 
            this.dgvCases.AllowUserToAddRows = false;
            this.dgvCases.AllowUserToDeleteRows = false;
            this.dgvCases.AllowUserToOrderColumns = true;
            this.dgvCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCaseID,
            this.colCaseDate,
            this.colCaseSubject});
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCases.DefaultCellStyle = dataGridViewCellStyle28;
            this.dgvCases.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvCases.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCases.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCases.Location = new System.Drawing.Point(789, 30);
            this.dgvCases.MultiSelect = false;
            this.dgvCases.Name = "dgvCases";
            this.dgvCases.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvCases.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvCases.RowHeadersVisible = false;
            this.dgvCases.SelectAllSignVisible = false;
            this.dgvCases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCases.ShowCellErrors = false;
            this.dgvCases.ShowEditingIcon = false;
            this.dgvCases.ShowRowErrors = false;
            this.dgvCases.Size = new System.Drawing.Size(330, 587);
            this.dgvCases.TabIndex = 40;
            this.dgvCases.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCases_CellContentClick);
            this.dgvCases.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvCases_DataError);
            this.dgvCases.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCases_RowEnter);
            this.dgvCases.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvCases_MouseDoubleClick);
            // 
            // colCaseID
            // 
            this.colCaseID.HeaderText = "كود القضية";
            this.colCaseID.Name = "colCaseID";
            // 
            // colCaseDate
            // 
            this.colCaseDate.HeaderText = "تاريخ الورود";
            this.colCaseDate.Name = "colCaseDate";
            // 
            // colCaseSubject
            // 
            this.colCaseSubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCaseSubject.HeaderText = "موضوع القضية";
            this.colCaseSubject.Name = "colCaseSubject";
            // 
            // txtSearchKeyword
            // 
            // 
            // 
            // 
            this.txtSearchKeyword.Border.Class = "TextBoxBorder";
            this.txtSearchKeyword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearchKeyword.Location = new System.Drawing.Point(9, 44);
            this.txtSearchKeyword.Name = "txtSearchKeyword";
            this.txtSearchKeyword.Size = new System.Drawing.Size(179, 20);
            this.txtSearchKeyword.TabIndex = 22;
            this.txtSearchKeyword.TextChanged += new System.EventHandler(this.txtSearchKeyword_TextChanged);
            // 
            // labelX13
            // 
            this.labelX13.AutoSize = true;
            this.labelX13.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX13.Location = new System.Drawing.Point(194, 44);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(56, 20);
            this.labelX13.TabIndex = 23;
            this.labelX13.Text = "كلمة البحث";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(428, 44);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(62, 20);
            this.labelX4.TabIndex = 65;
            this.labelX4.Text = "فلتر بواسطة";
            // 
            // cbxCaseParameters
            // 
            this.cbxCaseParameters.DisplayMember = "Text";
            this.cbxCaseParameters.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxCaseParameters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCaseParameters.FormattingEnabled = true;
            this.cbxCaseParameters.ItemHeight = 15;
            this.cbxCaseParameters.Items.AddRange(new object[] {
            this.AdminNumber,
            this.FineNumber,
            this.InvestigationNumber,
            this.ImprisonmentNumber,
            this.PartialNumber,
            this.TotalNumber,
            this.DelegationNumber,
            this.CaseSubject,
            this.DelegatorName,
            this.DelegatorSSN,
            this.DelegatorMobile});
            this.cbxCaseParameters.Location = new System.Drawing.Point(267, 44);
            this.cbxCaseParameters.Name = "cbxCaseParameters";
            this.cbxCaseParameters.Size = new System.Drawing.Size(155, 21);
            this.cbxCaseParameters.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxCaseParameters.TabIndex = 64;
            // 
            // AdminNumber
            // 
            this.AdminNumber.Text = "الرقم الإداري";
            // 
            // FineNumber
            // 
            this.FineNumber.Text = "رقم حصر الغرامات";
            // 
            // InvestigationNumber
            // 
            this.InvestigationNumber.Text = "رقم حصر التحقيق";
            // 
            // ImprisonmentNumber
            // 
            this.ImprisonmentNumber.Text = "رقم حصر الحبس";
            // 
            // PartialNumber
            // 
            this.PartialNumber.Text = "رقم القضية الجزئي";
            // 
            // TotalNumber
            // 
            this.TotalNumber.Text = "رقم القضية الكلي";
            // 
            // DelegationNumber
            // 
            this.DelegationNumber.Text = "رقم التوكيل";
            // 
            // CaseSubject
            // 
            this.CaseSubject.Text = "موضوع القضية";
            // 
            // DelegatorName
            // 
            this.DelegatorName.Text = "اسم الموكل";
            // 
            // DelegatorSSN
            // 
            this.DelegatorSSN.Text = "الرقم القومي للموكل";
            // 
            // DelegatorMobile
            // 
            this.DelegatorMobile.Text = "رقم جوال الموكل";
            // 
            // tcCaseDetails
            // 
            this.tcCaseDetails.BackColor = System.Drawing.Color.White;
            this.tcCaseDetails.CanReorderTabs = true;
            this.tcCaseDetails.Controls.Add(this.tpSessions);
            this.tcCaseDetails.Controls.Add(this.tpFees);
            this.tcCaseDetails.Controls.Add(this.tpCLowers);
            this.tcCaseDetails.Controls.Add(this.tpDelegators);
            this.tcCaseDetails.Controls.Add(this.tpGeneralCaseData);
            this.tcCaseDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tcCaseDetails.Location = new System.Drawing.Point(0, 71);
            this.tcCaseDetails.Name = "tcCaseDetails";
            this.tcCaseDetails.SelectedTabFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.tcCaseDetails.SelectedTabIndex = 4;
            this.tcCaseDetails.Size = new System.Drawing.Size(789, 546);
            this.tcCaseDetails.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document;
            this.tcCaseDetails.TabIndex = 66;
            this.tcCaseDetails.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tcCaseDetails.Tabs.Add(this.tabItem1);
            this.tcCaseDetails.Tabs.Add(this.tabItem4);
            this.tcCaseDetails.Tabs.Add(this.tabItem3);
            this.tcCaseDetails.Tabs.Add(this.tabItem2);
            this.tcCaseDetails.Tabs.Add(this.tabItem5);
            this.tcCaseDetails.Text = "tabControl1";
            // 
            // tpDelegators
            // 
            this.tpDelegators.Controls.Add(this.groupPanel9);
            this.tpDelegators.Controls.Add(this.groupPanel8);
            this.tpDelegators.DisabledBackColor = System.Drawing.Color.Empty;
            this.tpDelegators.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpDelegators.Location = new System.Drawing.Point(0, 22);
            this.tpDelegators.Name = "tpDelegators";
            this.tpDelegators.Padding = new System.Windows.Forms.Padding(1);
            this.tpDelegators.Size = new System.Drawing.Size(789, 524);
            this.tpDelegators.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tpDelegators.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tpDelegators.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tpDelegators.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tpDelegators.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tpDelegators.Style.GradientAngle = 90;
            this.tpDelegators.TabIndex = 13;
            this.tpDelegators.TabItem = this.tabItem4;
            // 
            // groupPanel9
            // 
            this.groupPanel9.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel9.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel9.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel9.Controls.Add(this.btnAddDelegator);
            this.groupPanel9.Controls.Add(this.labelX32);
            this.groupPanel9.Controls.Add(this.labelX33);
            this.groupPanel9.Controls.Add(this.labelX34);
            this.groupPanel9.Controls.Add(this.labelX36);
            this.groupPanel9.Controls.Add(this.labelX35);
            this.groupPanel9.Controls.Add(this.labelX37);
            this.groupPanel9.Controls.Add(this.txtDelegatorDetails);
            this.groupPanel9.Controls.Add(this.txtDelegatorSSN);
            this.groupPanel9.Controls.Add(this.txtDelegatorPhone);
            this.groupPanel9.Controls.Add(this.labelX38);
            this.groupPanel9.Controls.Add(this.txtCase_Del_Notes);
            this.groupPanel9.Controls.Add(this.txtDelegatorMobile);
            this.groupPanel9.Controls.Add(this.txtDelegatorAddress);
            this.groupPanel9.Controls.Add(this.txtDelegatorName);
            this.groupPanel9.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel9.Location = new System.Drawing.Point(11, 81);
            this.groupPanel9.Name = "groupPanel9";
            this.groupPanel9.Size = new System.Drawing.Size(528, 289);
            // 
            // 
            // 
            this.groupPanel9.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel9.Style.BackColorGradientAngle = 90;
            this.groupPanel9.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel9.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel9.Style.BorderBottomWidth = 1;
            this.groupPanel9.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel9.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel9.Style.BorderLeftWidth = 1;
            this.groupPanel9.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel9.Style.BorderRightWidth = 1;
            this.groupPanel9.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel9.Style.BorderTopWidth = 1;
            this.groupPanel9.Style.CornerDiameter = 4;
            this.groupPanel9.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel9.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel9.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel9.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel9.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel9.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel9.TabIndex = 35;
            this.groupPanel9.Text = "تفاصيل الموكل";
            // 
            // btnAddDelegator
            // 
            this.btnAddDelegator.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddDelegator.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddDelegator.Image = global::LowerApplication.Properties.Resources.Add;
            this.btnAddDelegator.Location = new System.Drawing.Point(3, 237);
            this.btnAddDelegator.Name = "btnAddDelegator";
            this.btnAddDelegator.Size = new System.Drawing.Size(86, 28);
            this.btnAddDelegator.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddDelegator.TabIndex = 57;
            this.btnAddDelegator.Text = "اضافة الموكل";
            this.btnAddDelegator.Click += new System.EventHandler(this.btnAddDelegator_Click);
            // 
            // labelX32
            // 
            this.labelX32.AutoSize = true;
            this.labelX32.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX32.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX32.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX32.Location = new System.Drawing.Point(441, 198);
            this.labelX32.Name = "labelX32";
            this.labelX32.Size = new System.Drawing.Size(68, 20);
            this.labelX32.TabIndex = 41;
            this.labelX32.Text = "تفاصيل أخري";
            // 
            // labelX33
            // 
            this.labelX33.AutoSize = true;
            this.labelX33.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX33.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX33.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX33.Location = new System.Drawing.Point(441, 81);
            this.labelX33.Name = "labelX33";
            this.labelX33.Size = new System.Drawing.Size(63, 20);
            this.labelX33.TabIndex = 41;
            this.labelX33.Text = "الرقم القومي";
            // 
            // labelX34
            // 
            this.labelX34.AutoSize = true;
            this.labelX34.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX34.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX34.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX34.Location = new System.Drawing.Point(441, 55);
            this.labelX34.Name = "labelX34";
            this.labelX34.Size = new System.Drawing.Size(61, 20);
            this.labelX34.TabIndex = 41;
            this.labelX34.Text = "رقم التليفون";
            // 
            // labelX36
            // 
            this.labelX36.AutoSize = true;
            this.labelX36.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX36.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX36.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX36.Location = new System.Drawing.Point(441, 152);
            this.labelX36.Name = "labelX36";
            this.labelX36.Size = new System.Drawing.Size(46, 20);
            this.labelX36.TabIndex = 41;
            this.labelX36.Text = "ملاحظات";
            // 
            // labelX35
            // 
            this.labelX35.AutoSize = true;
            this.labelX35.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX35.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX35.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX35.Location = new System.Drawing.Point(441, 107);
            this.labelX35.Name = "labelX35";
            this.labelX35.Size = new System.Drawing.Size(54, 20);
            this.labelX35.TabIndex = 41;
            this.labelX35.Text = "رقم الجوال";
            // 
            // labelX37
            // 
            this.labelX37.AutoSize = true;
            this.labelX37.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX37.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX37.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX37.Location = new System.Drawing.Point(441, 29);
            this.labelX37.Name = "labelX37";
            this.labelX37.Size = new System.Drawing.Size(37, 20);
            this.labelX37.TabIndex = 41;
            this.labelX37.Text = "العنوان";
            // 
            // txtDelegatorDetails
            // 
            // 
            // 
            // 
            this.txtDelegatorDetails.Border.Class = "TextBoxBorder";
            this.txtDelegatorDetails.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDelegatorDetails.Location = new System.Drawing.Point(3, 187);
            this.txtDelegatorDetails.Multiline = true;
            this.txtDelegatorDetails.Name = "txtDelegatorDetails";
            this.txtDelegatorDetails.Size = new System.Drawing.Size(428, 42);
            this.txtDelegatorDetails.TabIndex = 40;
            // 
            // txtDelegatorSSN
            // 
            // 
            // 
            // 
            this.txtDelegatorSSN.Border.Class = "TextBoxBorder";
            this.txtDelegatorSSN.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDelegatorSSN.Location = new System.Drawing.Point(3, 81);
            this.txtDelegatorSSN.Name = "txtDelegatorSSN";
            this.txtDelegatorSSN.Size = new System.Drawing.Size(428, 20);
            this.txtDelegatorSSN.TabIndex = 40;
            // 
            // txtDelegatorPhone
            // 
            // 
            // 
            // 
            this.txtDelegatorPhone.Border.Class = "TextBoxBorder";
            this.txtDelegatorPhone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDelegatorPhone.Location = new System.Drawing.Point(3, 55);
            this.txtDelegatorPhone.Name = "txtDelegatorPhone";
            this.txtDelegatorPhone.Size = new System.Drawing.Size(428, 20);
            this.txtDelegatorPhone.TabIndex = 40;
            // 
            // labelX38
            // 
            this.labelX38.AutoSize = true;
            this.labelX38.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX38.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX38.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX38.Location = new System.Drawing.Point(441, 3);
            this.labelX38.Name = "labelX38";
            this.labelX38.Size = new System.Drawing.Size(56, 20);
            this.labelX38.TabIndex = 41;
            this.labelX38.Text = "اسم الموكل";
            // 
            // txtCase_Del_Notes
            // 
            // 
            // 
            // 
            this.txtCase_Del_Notes.Border.Class = "TextBoxBorder";
            this.txtCase_Del_Notes.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCase_Del_Notes.Location = new System.Drawing.Point(3, 144);
            this.txtCase_Del_Notes.Multiline = true;
            this.txtCase_Del_Notes.Name = "txtCase_Del_Notes";
            this.txtCase_Del_Notes.Size = new System.Drawing.Size(428, 37);
            this.txtCase_Del_Notes.TabIndex = 40;
            // 
            // txtDelegatorMobile
            // 
            // 
            // 
            // 
            this.txtDelegatorMobile.Border.Class = "TextBoxBorder";
            this.txtDelegatorMobile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDelegatorMobile.Location = new System.Drawing.Point(3, 107);
            this.txtDelegatorMobile.Name = "txtDelegatorMobile";
            this.txtDelegatorMobile.Size = new System.Drawing.Size(428, 20);
            this.txtDelegatorMobile.TabIndex = 40;
            // 
            // txtDelegatorAddress
            // 
            // 
            // 
            // 
            this.txtDelegatorAddress.Border.Class = "TextBoxBorder";
            this.txtDelegatorAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDelegatorAddress.Location = new System.Drawing.Point(3, 29);
            this.txtDelegatorAddress.Name = "txtDelegatorAddress";
            this.txtDelegatorAddress.Size = new System.Drawing.Size(428, 20);
            this.txtDelegatorAddress.TabIndex = 40;
            // 
            // txtDelegatorName
            // 
            // 
            // 
            // 
            this.txtDelegatorName.Border.Class = "TextBoxBorder";
            this.txtDelegatorName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDelegatorName.Location = new System.Drawing.Point(3, 3);
            this.txtDelegatorName.Name = "txtDelegatorName";
            this.txtDelegatorName.Size = new System.Drawing.Size(428, 20);
            this.txtDelegatorName.TabIndex = 40;
            // 
            // groupPanel8
            // 
            this.groupPanel8.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel8.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel8.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel8.Controls.Add(this.dgvDelegators);
            this.groupPanel8.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupPanel8.Location = new System.Drawing.Point(545, 1);
            this.groupPanel8.Name = "groupPanel8";
            this.groupPanel8.Size = new System.Drawing.Size(243, 522);
            // 
            // 
            // 
            this.groupPanel8.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel8.Style.BackColorGradientAngle = 90;
            this.groupPanel8.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel8.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel8.Style.BorderBottomWidth = 1;
            this.groupPanel8.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel8.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel8.Style.BorderLeftWidth = 1;
            this.groupPanel8.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel8.Style.BorderRightWidth = 1;
            this.groupPanel8.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel8.Style.BorderTopWidth = 1;
            this.groupPanel8.Style.CornerDiameter = 4;
            this.groupPanel8.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal;
            this.groupPanel8.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel8.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            // 
            // 
            // 
            this.groupPanel8.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel8.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel8.TabIndex = 34;
            this.groupPanel8.Text = "الموكلين";
            // 
            // dgvDelegators
            // 
            this.dgvDelegators.AllowUserToAddRows = false;
            this.dgvDelegators.AllowUserToDeleteRows = false;
            this.dgvDelegators.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelegators.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDelegatorName,
            this.colDelegatorAddress,
            this.colDelegatorSSN,
            this.colDelegatorPhone,
            this.colDelegatorMobile,
            this.colDelegatorDetails});
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDelegators.DefaultCellStyle = dataGridViewCellStyle27;
            this.dgvDelegators.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDelegators.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDelegators.Location = new System.Drawing.Point(0, 0);
            this.dgvDelegators.Name = "dgvDelegators";
            this.dgvDelegators.ReadOnly = true;
            this.dgvDelegators.RowHeadersVisible = false;
            this.dgvDelegators.Size = new System.Drawing.Size(237, 501);
            this.dgvDelegators.TabIndex = 32;
            this.dgvDelegators.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDelegators_DataError);
            this.dgvDelegators.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDelegators_RowEnter);
            // 
            // colDelegatorName
            // 
            this.colDelegatorName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDelegatorName.HeaderText = "اسم الموكل";
            this.colDelegatorName.Name = "colDelegatorName";
            this.colDelegatorName.ReadOnly = true;
            // 
            // colDelegatorAddress
            // 
            this.colDelegatorAddress.HeaderText = "العنوان";
            this.colDelegatorAddress.Name = "colDelegatorAddress";
            this.colDelegatorAddress.ReadOnly = true;
            this.colDelegatorAddress.Visible = false;
            // 
            // colDelegatorSSN
            // 
            this.colDelegatorSSN.HeaderText = "الرقم القومي";
            this.colDelegatorSSN.Name = "colDelegatorSSN";
            this.colDelegatorSSN.ReadOnly = true;
            // 
            // colDelegatorPhone
            // 
            this.colDelegatorPhone.HeaderText = "التليفون الأرضي";
            this.colDelegatorPhone.Name = "colDelegatorPhone";
            this.colDelegatorPhone.ReadOnly = true;
            this.colDelegatorPhone.Visible = false;
            // 
            // colDelegatorMobile
            // 
            this.colDelegatorMobile.HeaderText = "رقم الجوال";
            this.colDelegatorMobile.Name = "colDelegatorMobile";
            this.colDelegatorMobile.ReadOnly = true;
            this.colDelegatorMobile.Visible = false;
            // 
            // colDelegatorDetails
            // 
            this.colDelegatorDetails.HeaderText = "تفاصيل أخرى";
            this.colDelegatorDetails.Name = "colDelegatorDetails";
            this.colDelegatorDetails.ReadOnly = true;
            this.colDelegatorDetails.Visible = false;
            // 
            // tabItem4
            // 
            this.tabItem4.AttachedControl = this.tpDelegators;
            this.tabItem4.Name = "tabItem4";
            this.tabItem4.Text = "الموكـــــلبن";
            // 
            // tpGeneralCaseData
            // 
            this.tpGeneralCaseData.Controls.Add(this.groupPanel3);
            this.tpGeneralCaseData.Controls.Add(this.groupPanel1);
            this.tpGeneralCaseData.Controls.Add(this.groupPanel2);
            this.tpGeneralCaseData.DisabledBackColor = System.Drawing.Color.Empty;
            this.tpGeneralCaseData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpGeneralCaseData.Location = new System.Drawing.Point(0, 22);
            this.tpGeneralCaseData.Name = "tpGeneralCaseData";
            this.tpGeneralCaseData.Padding = new System.Windows.Forms.Padding(1);
            this.tpGeneralCaseData.Size = new System.Drawing.Size(789, 524);
            this.tpGeneralCaseData.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tpGeneralCaseData.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tpGeneralCaseData.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tpGeneralCaseData.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tpGeneralCaseData.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tpGeneralCaseData.Style.GradientAngle = 90;
            this.tpGeneralCaseData.TabIndex = 1;
            this.tpGeneralCaseData.TabItem = this.tabItem1;
            // 
            // groupPanel3
            // 
            this.groupPanel3.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.iiadministrativeNumber);
            this.groupPanel3.Controls.Add(this.txtadministrativestring);
            this.groupPanel3.Controls.Add(this.labelX17);
            this.groupPanel3.Controls.Add(this.txtfinestring);
            this.groupPanel3.Controls.Add(this.labelX15);
            this.groupPanel3.Controls.Add(this.labelX2);
            this.groupPanel3.Controls.Add(this.labelX3);
            this.groupPanel3.Controls.Add(this.txtInvestigationString);
            this.groupPanel3.Controls.Add(this.labelX1);
            this.groupPanel3.Controls.Add(this.txtImprisonString);
            this.groupPanel3.Controls.Add(this.labelX5);
            this.groupPanel3.Controls.Add(this.labelX6);
            this.groupPanel3.Controls.Add(this.labelX7);
            this.groupPanel3.Controls.Add(this.txtPartialString);
            this.groupPanel3.Controls.Add(this.iiTotalNumber);
            this.groupPanel3.Controls.Add(this.txtTotalString);
            this.groupPanel3.Controls.Add(this.iiPartialNumber);
            this.groupPanel3.Controls.Add(this.labelX12);
            this.groupPanel3.Controls.Add(this.iiImprisonmentNumber);
            this.groupPanel3.Controls.Add(this.labelX14);
            this.groupPanel3.Controls.Add(this.iiInvestigationNumer);
            this.groupPanel3.Controls.Add(this.labelX16);
            this.groupPanel3.Controls.Add(this.iifinenumber);
            this.groupPanel3.Controls.Add(this.labelX18);
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Location = new System.Drawing.Point(54, 211);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(605, 192);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 69;
            this.groupPanel3.Text = "أرقام القضية";
            // 
            // iiadministrativeNumber
            // 
            // 
            // 
            // 
            this.iiadministrativeNumber.BackgroundStyle.Class = "DateTimeInputBackground";
            this.iiadministrativeNumber.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.iiadministrativeNumber.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.iiadministrativeNumber.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.iiadministrativeNumber.Location = new System.Drawing.Point(320, 3);
            this.iiadministrativeNumber.MinValue = 0;
            this.iiadministrativeNumber.Name = "iiadministrativeNumber";
            this.iiadministrativeNumber.ShowUpDown = true;
            this.iiadministrativeNumber.Size = new System.Drawing.Size(136, 20);
            this.iiadministrativeNumber.TabIndex = 55;
            // 
            // txtadministrativestring
            // 
            // 
            // 
            // 
            this.txtadministrativestring.Border.Class = "TextBoxBorder";
            this.txtadministrativestring.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtadministrativestring.Location = new System.Drawing.Point(98, 3);
            this.txtadministrativestring.Name = "txtadministrativestring";
            this.txtadministrativestring.Size = new System.Drawing.Size(179, 20);
            this.txtadministrativestring.TabIndex = 38;
            // 
            // labelX17
            // 
            this.labelX17.AutoSize = true;
            this.labelX17.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX17.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX17.Location = new System.Drawing.Point(296, 134);
            this.labelX17.Name = "labelX17";
            this.labelX17.Size = new System.Drawing.Size(7, 19);
            this.labelX17.TabIndex = 56;
            this.labelX17.Text = "\\";
            // 
            // txtfinestring
            // 
            // 
            // 
            // 
            this.txtfinestring.Border.Class = "TextBoxBorder";
            this.txtfinestring.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtfinestring.Location = new System.Drawing.Point(98, 29);
            this.txtfinestring.Name = "txtfinestring";
            this.txtfinestring.Size = new System.Drawing.Size(179, 20);
            this.txtfinestring.TabIndex = 38;
            // 
            // labelX15
            // 
            this.labelX15.AutoSize = true;
            this.labelX15.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX15.Location = new System.Drawing.Point(296, 108);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(7, 19);
            this.labelX15.TabIndex = 56;
            this.labelX15.Text = "\\";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(477, 3);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(82, 20);
            this.labelX2.TabIndex = 39;
            this.labelX2.Text = "الرقــــــم الإداري";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(296, 82);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(7, 19);
            this.labelX3.TabIndex = 56;
            this.labelX3.Text = "\\";
            // 
            // txtInvestigationString
            // 
            // 
            // 
            // 
            this.txtInvestigationString.Border.Class = "TextBoxBorder";
            this.txtInvestigationString.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInvestigationString.Location = new System.Drawing.Point(98, 55);
            this.txtInvestigationString.Name = "txtInvestigationString";
            this.txtInvestigationString.Size = new System.Drawing.Size(179, 20);
            this.txtInvestigationString.TabIndex = 38;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(296, 56);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(7, 19);
            this.labelX1.TabIndex = 56;
            this.labelX1.Text = "\\";
            // 
            // txtImprisonString
            // 
            // 
            // 
            // 
            this.txtImprisonString.Border.Class = "TextBoxBorder";
            this.txtImprisonString.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtImprisonString.Location = new System.Drawing.Point(98, 81);
            this.txtImprisonString.Name = "txtImprisonString";
            this.txtImprisonString.Size = new System.Drawing.Size(179, 20);
            this.txtImprisonString.TabIndex = 38;
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(296, 30);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(7, 19);
            this.labelX5.TabIndex = 56;
            this.labelX5.Text = "\\";
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(465, 29);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(94, 20);
            this.labelX6.TabIndex = 39;
            this.labelX6.Text = "رقم حصر الغرامات";
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(296, 4);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(7, 19);
            this.labelX7.TabIndex = 56;
            this.labelX7.Text = "\\";
            // 
            // txtPartialString
            // 
            // 
            // 
            // 
            this.txtPartialString.Border.Class = "TextBoxBorder";
            this.txtPartialString.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPartialString.Location = new System.Drawing.Point(98, 107);
            this.txtPartialString.Name = "txtPartialString";
            this.txtPartialString.Size = new System.Drawing.Size(179, 20);
            this.txtPartialString.TabIndex = 38;
            // 
            // iiTotalNumber
            // 
            // 
            // 
            // 
            this.iiTotalNumber.BackgroundStyle.Class = "DateTimeInputBackground";
            this.iiTotalNumber.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.iiTotalNumber.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.iiTotalNumber.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.iiTotalNumber.Location = new System.Drawing.Point(320, 133);
            this.iiTotalNumber.MinValue = 0;
            this.iiTotalNumber.Name = "iiTotalNumber";
            this.iiTotalNumber.ShowUpDown = true;
            this.iiTotalNumber.Size = new System.Drawing.Size(136, 20);
            this.iiTotalNumber.TabIndex = 55;
            // 
            // txtTotalString
            // 
            // 
            // 
            // 
            this.txtTotalString.Border.Class = "TextBoxBorder";
            this.txtTotalString.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTotalString.Location = new System.Drawing.Point(98, 133);
            this.txtTotalString.Name = "txtTotalString";
            this.txtTotalString.Size = new System.Drawing.Size(179, 20);
            this.txtTotalString.TabIndex = 38;
            // 
            // iiPartialNumber
            // 
            // 
            // 
            // 
            this.iiPartialNumber.BackgroundStyle.Class = "DateTimeInputBackground";
            this.iiPartialNumber.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.iiPartialNumber.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.iiPartialNumber.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.iiPartialNumber.Location = new System.Drawing.Point(320, 107);
            this.iiPartialNumber.MinValue = 0;
            this.iiPartialNumber.Name = "iiPartialNumber";
            this.iiPartialNumber.ShowUpDown = true;
            this.iiPartialNumber.Size = new System.Drawing.Size(136, 20);
            this.iiPartialNumber.TabIndex = 55;
            // 
            // labelX12
            // 
            this.labelX12.AutoSize = true;
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX12.Location = new System.Drawing.Point(470, 55);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(89, 20);
            this.labelX12.TabIndex = 39;
            this.labelX12.Text = "رقم حصر التحقيق";
            // 
            // iiImprisonmentNumber
            // 
            // 
            // 
            // 
            this.iiImprisonmentNumber.BackgroundStyle.Class = "DateTimeInputBackground";
            this.iiImprisonmentNumber.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.iiImprisonmentNumber.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.iiImprisonmentNumber.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.iiImprisonmentNumber.Location = new System.Drawing.Point(320, 81);
            this.iiImprisonmentNumber.MinValue = 0;
            this.iiImprisonmentNumber.Name = "iiImprisonmentNumber";
            this.iiImprisonmentNumber.ShowUpDown = true;
            this.iiImprisonmentNumber.Size = new System.Drawing.Size(136, 20);
            this.iiImprisonmentNumber.TabIndex = 55;
            // 
            // labelX14
            // 
            this.labelX14.AutoSize = true;
            this.labelX14.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX14.Location = new System.Drawing.Point(466, 81);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(93, 20);
            this.labelX14.TabIndex = 39;
            this.labelX14.Text = "رقـــم حصر الحبس";
            // 
            // iiInvestigationNumer
            // 
            // 
            // 
            // 
            this.iiInvestigationNumer.BackgroundStyle.Class = "DateTimeInputBackground";
            this.iiInvestigationNumer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.iiInvestigationNumer.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.iiInvestigationNumer.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.iiInvestigationNumer.Location = new System.Drawing.Point(320, 55);
            this.iiInvestigationNumer.MinValue = 0;
            this.iiInvestigationNumer.Name = "iiInvestigationNumer";
            this.iiInvestigationNumer.ShowUpDown = true;
            this.iiInvestigationNumer.Size = new System.Drawing.Size(136, 20);
            this.iiInvestigationNumer.TabIndex = 55;
            // 
            // labelX16
            // 
            this.labelX16.AutoSize = true;
            this.labelX16.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX16.Location = new System.Drawing.Point(465, 107);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(94, 20);
            this.labelX16.TabIndex = 39;
            this.labelX16.Text = "رقم القضية الجزئي";
            // 
            // iifinenumber
            // 
            // 
            // 
            // 
            this.iifinenumber.BackgroundStyle.Class = "DateTimeInputBackground";
            this.iifinenumber.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.iifinenumber.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.iifinenumber.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.iifinenumber.Location = new System.Drawing.Point(320, 29);
            this.iifinenumber.MinValue = 0;
            this.iifinenumber.Name = "iifinenumber";
            this.iifinenumber.ShowUpDown = true;
            this.iifinenumber.Size = new System.Drawing.Size(136, 20);
            this.iifinenumber.TabIndex = 55;
            // 
            // labelX18
            // 
            this.labelX18.AutoSize = true;
            this.labelX18.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX18.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX18.Location = new System.Drawing.Point(475, 133);
            this.labelX18.Name = "labelX18";
            this.labelX18.Size = new System.Drawing.Size(84, 20);
            this.labelX18.TabIndex = 39;
            this.labelX18.Text = "رقم القضية الكلي";
            // 
            // groupPanel1
            // 
            this.groupPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnAddChamber);
            this.groupPanel1.Controls.Add(this.btnAddCourt);
            this.groupPanel1.Controls.Add(this.labelX19);
            this.groupPanel1.Controls.Add(this.dtRecievingDate);
            this.groupPanel1.Controls.Add(this.cbxChamber);
            this.groupPanel1.Controls.Add(this.labelX20);
            this.groupPanel1.Controls.Add(this.cbxCourt);
            this.groupPanel1.Controls.Add(this.labelX21);
            this.groupPanel1.Controls.Add(this.labelX22);
            this.groupPanel1.Controls.Add(this.txtCaseDetails);
            this.groupPanel1.Controls.Add(this.txtCaseSubject);
            this.groupPanel1.Controls.Add(this.lblUseraName);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(54, 9);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(605, 196);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 67;
            this.groupPanel1.Text = "بيانات عامة";
            // 
            // btnAddChamber
            // 
            this.btnAddChamber.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddChamber.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnAddChamber.Image = global::LowerApplication.Properties.Resources.Add;
            this.btnAddChamber.Location = new System.Drawing.Point(265, 40);
            this.btnAddChamber.Name = "btnAddChamber";
            this.btnAddChamber.Size = new System.Drawing.Size(27, 20);
            this.btnAddChamber.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddChamber.TabIndex = 54;
            this.btnAddChamber.Click += new System.EventHandler(this.btnAddChamber_Click_2);
            // 
            // btnAddCourt
            // 
            this.btnAddCourt.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddCourt.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnAddCourt.Image = global::LowerApplication.Properties.Resources.Add;
            this.btnAddCourt.Location = new System.Drawing.Point(2, 14);
            this.btnAddCourt.Name = "btnAddCourt";
            this.btnAddCourt.Size = new System.Drawing.Size(27, 20);
            this.btnAddCourt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddCourt.TabIndex = 53;
            this.btnAddCourt.Click += new System.EventHandler(this.btnAddCourt_Click_2);
            // 
            // labelX19
            // 
            this.labelX19.AutoSize = true;
            this.labelX19.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX19.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX19.Location = new System.Drawing.Point(510, 6);
            this.labelX19.Name = "labelX19";
            this.labelX19.Size = new System.Drawing.Size(65, 20);
            this.labelX19.TabIndex = 51;
            this.labelX19.Text = "تاريخ الورود";
            // 
            // dtRecievingDate
            // 
            // 
            // 
            // 
            this.dtRecievingDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtRecievingDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtRecievingDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtRecievingDate.ButtonDropDown.Visible = true;
            this._errorfrmHighlighter.SetHighlightColor(this.dtRecievingDate, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
            this.dtRecievingDate.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.dtRecievingDate.IsPopupCalendarOpen = false;
            this.dtRecievingDate.Location = new System.Drawing.Point(296, 6);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtRecievingDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtRecievingDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtRecievingDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtRecievingDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtRecievingDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtRecievingDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtRecievingDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtRecievingDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtRecievingDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtRecievingDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtRecievingDate.MonthCalendar.DisplayMonth = new System.DateTime(2016, 3, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtRecievingDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtRecievingDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtRecievingDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtRecievingDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtRecievingDate.MonthCalendar.TodayButtonVisible = true;
            this.dtRecievingDate.Name = "dtRecievingDate";
            this.dtRecievingDate.Size = new System.Drawing.Size(178, 20);
            this.dtRecievingDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtRecievingDate.TabIndex = 50;
            this.dtRecievingDate.TimeSelectorType = DevComponents.Editors.DateTimeAdv.eTimeSelectorType.TouchStyle;
            // 
            // cbxChamber
            // 
            this.cbxChamber.DisplayMember = "Text";
            this.cbxChamber.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxChamber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChamber.FormattingEnabled = true;
            this.cbxChamber.ItemHeight = 15;
            this.cbxChamber.Location = new System.Drawing.Point(293, 40);
            this.cbxChamber.Name = "cbxChamber";
            this.cbxChamber.Size = new System.Drawing.Size(181, 21);
            this.cbxChamber.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxChamber.TabIndex = 49;
            // 
            // labelX20
            // 
            this.labelX20.AutoSize = true;
            this.labelX20.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX20.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX20.Location = new System.Drawing.Point(190, 14);
            this.labelX20.Name = "labelX20";
            this.labelX20.Size = new System.Drawing.Size(74, 20);
            this.labelX20.TabIndex = 48;
            this.labelX20.Text = "المحكمـــــــــــة";
            // 
            // cbxCourt
            // 
            this.cbxCourt.DisplayMember = "Text";
            this.cbxCourt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxCourt.FormattingEnabled = true;
            this.cbxCourt.ItemHeight = 15;
            this.cbxCourt.Location = new System.Drawing.Point(29, 14);
            this.cbxCourt.Name = "cbxCourt";
            this.cbxCourt.Size = new System.Drawing.Size(155, 21);
            this.cbxCourt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxCourt.TabIndex = 47;
            this.cbxCourt.SelectedIndexChanged += new System.EventHandler(this.cbxCourt_SelectedIndexChanged);
            // 
            // labelX21
            // 
            this.labelX21.AutoSize = true;
            this.labelX21.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX21.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX21.Location = new System.Drawing.Point(510, 132);
            this.labelX21.Name = "labelX21";
            this.labelX21.Size = new System.Drawing.Size(75, 20);
            this.labelX21.TabIndex = 44;
            this.labelX21.Text = "تفاصيل القضية";
            // 
            // labelX22
            // 
            this.labelX22.AutoSize = true;
            this.labelX22.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX22.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX22.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX22.Location = new System.Drawing.Point(510, 81);
            this.labelX22.Name = "labelX22";
            this.labelX22.Size = new System.Drawing.Size(79, 20);
            this.labelX22.TabIndex = 43;
            this.labelX22.Text = "موضوغ القضية";
            // 
            // txtCaseDetails
            // 
            // 
            // 
            // 
            this.txtCaseDetails.Border.Class = "TextBoxBorder";
            this.txtCaseDetails.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCaseDetails.Location = new System.Drawing.Point(3, 120);
            this.txtCaseDetails.Multiline = true;
            this.txtCaseDetails.Name = "txtCaseDetails";
            this.txtCaseDetails.Size = new System.Drawing.Size(471, 45);
            this.txtCaseDetails.TabIndex = 42;
            // 
            // txtCaseSubject
            // 
            // 
            // 
            // 
            this.txtCaseSubject.Border.Class = "TextBoxBorder";
            this.txtCaseSubject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCaseSubject.Location = new System.Drawing.Point(2, 69);
            this.txtCaseSubject.Multiline = true;
            this.txtCaseSubject.Name = "txtCaseSubject";
            this.txtCaseSubject.Size = new System.Drawing.Size(472, 45);
            this.txtCaseSubject.TabIndex = 41;
            // 
            // lblUseraName
            // 
            this.lblUseraName.AutoSize = true;
            this.lblUseraName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblUseraName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblUseraName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseraName.Location = new System.Drawing.Point(510, 40);
            this.lblUseraName.Name = "lblUseraName";
            this.lblUseraName.Size = new System.Drawing.Size(72, 20);
            this.lblUseraName.TabIndex = 36;
            this.lblUseraName.Text = "الدائـــــــــــــرة";
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnAddDocumentationOffice);
            this.groupPanel2.Controls.Add(this.labelX23);
            this.groupPanel2.Controls.Add(this.labelX24);
            this.groupPanel2.Controls.Add(this.cbxDocumentationOffice);
            this.groupPanel2.Controls.Add(this.labelX25);
            this.groupPanel2.Controls.Add(this.iiDelegationNumber);
            this.groupPanel2.Controls.Add(this.labelX26);
            this.groupPanel2.Controls.Add(this.txtDelegationString);
            this.groupPanel2.Controls.Add(this.txtDelegationLetter);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(54, 410);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(605, 100);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 68;
            this.groupPanel2.Text = "بيانات التوكيل";
            // 
            // btnAddDocumentationOffice
            // 
            this.btnAddDocumentationOffice.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddDocumentationOffice.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnAddDocumentationOffice.Image = global::LowerApplication.Properties.Resources.Add;
            this.btnAddDocumentationOffice.Location = new System.Drawing.Point(257, 47);
            this.btnAddDocumentationOffice.Name = "btnAddDocumentationOffice";
            this.btnAddDocumentationOffice.Size = new System.Drawing.Size(27, 20);
            this.btnAddDocumentationOffice.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddDocumentationOffice.TabIndex = 53;
            this.btnAddDocumentationOffice.Click += new System.EventHandler(this.btnAddDocumentationOffice_Click_1);
            // 
            // labelX23
            // 
            this.labelX23.AutoSize = true;
            this.labelX23.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX23.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX23.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX23.Location = new System.Drawing.Point(516, 47);
            this.labelX23.Name = "labelX23";
            this.labelX23.Size = new System.Drawing.Size(60, 20);
            this.labelX23.TabIndex = 48;
            this.labelX23.Text = "مكتب توثيق";
            // 
            // labelX24
            // 
            this.labelX24.AutoSize = true;
            this.labelX24.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX24.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX24.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX24.Location = new System.Drawing.Point(97, 4);
            this.labelX24.Name = "labelX24";
            this.labelX24.Size = new System.Drawing.Size(7, 19);
            this.labelX24.TabIndex = 56;
            this.labelX24.Text = "\\";
            // 
            // cbxDocumentationOffice
            // 
            this.cbxDocumentationOffice.DisplayMember = "Text";
            this.cbxDocumentationOffice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxDocumentationOffice.FormattingEnabled = true;
            this.cbxDocumentationOffice.ItemHeight = 15;
            this.cbxDocumentationOffice.Location = new System.Drawing.Point(287, 47);
            this.cbxDocumentationOffice.Name = "cbxDocumentationOffice";
            this.cbxDocumentationOffice.Size = new System.Drawing.Size(181, 21);
            this.cbxDocumentationOffice.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxDocumentationOffice.TabIndex = 47;
            // 
            // labelX25
            // 
            this.labelX25.AutoSize = true;
            this.labelX25.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX25.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX25.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX25.Location = new System.Drawing.Point(308, 4);
            this.labelX25.Name = "labelX25";
            this.labelX25.Size = new System.Drawing.Size(7, 19);
            this.labelX25.TabIndex = 56;
            this.labelX25.Text = "\\";
            // 
            // iiDelegationNumber
            // 
            // 
            // 
            // 
            this.iiDelegationNumber.BackgroundStyle.Class = "DateTimeInputBackground";
            this.iiDelegationNumber.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.iiDelegationNumber.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.iiDelegationNumber.Location = new System.Drawing.Point(332, 3);
            this.iiDelegationNumber.Name = "iiDelegationNumber";
            this.iiDelegationNumber.ShowUpDown = true;
            this.iiDelegationNumber.Size = new System.Drawing.Size(136, 20);
            this.iiDelegationNumber.TabIndex = 55;
            // 
            // labelX26
            // 
            this.labelX26.AutoSize = true;
            this.labelX26.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX26.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX26.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX26.Location = new System.Drawing.Point(497, 3);
            this.labelX26.Name = "labelX26";
            this.labelX26.Size = new System.Drawing.Size(74, 20);
            this.labelX26.TabIndex = 40;
            this.labelX26.Text = "رقــم التوكيــــل";
            // 
            // txtDelegationString
            // 
            // 
            // 
            // 
            this.txtDelegationString.Border.Class = "TextBoxBorder";
            this.txtDelegationString.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDelegationString.Location = new System.Drawing.Point(110, 3);
            this.txtDelegationString.Name = "txtDelegationString";
            this.txtDelegationString.Size = new System.Drawing.Size(179, 20);
            this.txtDelegationString.TabIndex = 38;
            // 
            // txtDelegationLetter
            // 
            // 
            // 
            // 
            this.txtDelegationLetter.Border.Class = "TextBoxBorder";
            this.txtDelegationLetter.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDelegationLetter.Location = new System.Drawing.Point(16, 3);
            this.txtDelegationLetter.Name = "txtDelegationLetter";
            this.txtDelegationLetter.Size = new System.Drawing.Size(75, 20);
            this.txtDelegationLetter.TabIndex = 38;
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tpGeneralCaseData;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "بيانات القضية";
            // 
            // tpSessions
            // 
            this.tpSessions.Controls.Add(this.groupPanel5);
            this.tpSessions.Controls.Add(this.groupPanel4);
            this.tpSessions.DisabledBackColor = System.Drawing.Color.Empty;
            this.tpSessions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpSessions.Location = new System.Drawing.Point(0, 22);
            this.tpSessions.Name = "tpSessions";
            this.tpSessions.Padding = new System.Windows.Forms.Padding(1);
            this.tpSessions.Size = new System.Drawing.Size(789, 524);
            this.tpSessions.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tpSessions.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tpSessions.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tpSessions.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tpSessions.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tpSessions.Style.GradientAngle = 90;
            this.tpSessions.TabIndex = 5;
            this.tpSessions.TabItem = this.tabItem2;
            // 
            // groupPanel5
            // 
            this.groupPanel5.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel5.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel5.Controls.Add(this.btnAddSession);
            this.groupPanel5.Controls.Add(this.labelX8);
            this.groupPanel5.Controls.Add(this.labelX9);
            this.groupPanel5.Controls.Add(this.labelX10);
            this.groupPanel5.Controls.Add(this.labelX11);
            this.groupPanel5.Controls.Add(this.txtSessionNotes);
            this.groupPanel5.Controls.Add(this.txtSessionOrders);
            this.groupPanel5.Controls.Add(this.txtSessionDetails);
            this.groupPanel5.Controls.Add(this.txtRollNumber);
            this.groupPanel5.Controls.Add(this.labelX27);
            this.groupPanel5.Controls.Add(this.dtSessionDate);
            this.groupPanel5.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel5.Location = new System.Drawing.Point(33, 57);
            this.groupPanel5.Name = "groupPanel5";
            this.groupPanel5.Size = new System.Drawing.Size(457, 244);
            // 
            // 
            // 
            this.groupPanel5.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel5.Style.BackColorGradientAngle = 90;
            this.groupPanel5.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel5.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderBottomWidth = 1;
            this.groupPanel5.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel5.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderLeftWidth = 1;
            this.groupPanel5.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderRightWidth = 1;
            this.groupPanel5.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderTopWidth = 1;
            this.groupPanel5.Style.CornerDiameter = 4;
            this.groupPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel5.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel5.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel5.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel5.TabIndex = 9;
            this.groupPanel5.Text = "تفاصيل الجلسة";
            // 
            // btnAddSession
            // 
            this.btnAddSession.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddSession.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddSession.Image = global::LowerApplication.Properties.Resources.Add;
            this.btnAddSession.Location = new System.Drawing.Point(3, 193);
            this.btnAddSession.Name = "btnAddSession";
            this.btnAddSession.Size = new System.Drawing.Size(101, 27);
            this.btnAddSession.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddSession.TabIndex = 56;
            this.btnAddSession.Text = "إضافة جلسة";
            this.btnAddSession.Click += new System.EventHandler(this.btnAddSession_Click);
            // 
            // labelX8
            // 
            this.labelX8.AutoSize = true;
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.Location = new System.Drawing.Point(370, 142);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(46, 20);
            this.labelX8.TabIndex = 55;
            this.labelX8.Text = "ملاحظات";
            // 
            // labelX9
            // 
            this.labelX9.AutoSize = true;
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.Location = new System.Drawing.Point(370, 82);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(43, 20);
            this.labelX9.TabIndex = 55;
            this.labelX9.Text = "القرارات";
            // 
            // labelX10
            // 
            this.labelX10.AutoSize = true;
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.Location = new System.Drawing.Point(370, 38);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(75, 20);
            this.labelX10.TabIndex = 55;
            this.labelX10.Text = "تفاصيل الجلسة";
            // 
            // labelX11
            // 
            this.labelX11.AutoSize = true;
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX11.Location = new System.Drawing.Point(370, 4);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(50, 20);
            this.labelX11.TabIndex = 55;
            this.labelX11.Text = "رقم الرول";
            // 
            // txtSessionNotes
            // 
            // 
            // 
            // 
            this.txtSessionNotes.Border.Class = "TextBoxBorder";
            this.txtSessionNotes.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSessionNotes.Location = new System.Drawing.Point(9, 126);
            this.txtSessionNotes.Multiline = true;
            this.txtSessionNotes.Name = "txtSessionNotes";
            this.txtSessionNotes.Size = new System.Drawing.Size(354, 52);
            this.txtSessionNotes.TabIndex = 54;
            // 
            // txtSessionOrders
            // 
            // 
            // 
            // 
            this.txtSessionOrders.Border.Class = "TextBoxBorder";
            this.txtSessionOrders.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSessionOrders.Location = new System.Drawing.Point(9, 70);
            this.txtSessionOrders.Multiline = true;
            this.txtSessionOrders.Name = "txtSessionOrders";
            this.txtSessionOrders.Size = new System.Drawing.Size(354, 44);
            this.txtSessionOrders.TabIndex = 54;
            // 
            // txtSessionDetails
            // 
            // 
            // 
            // 
            this.txtSessionDetails.Border.Class = "TextBoxBorder";
            this.txtSessionDetails.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSessionDetails.Location = new System.Drawing.Point(9, 32);
            this.txtSessionDetails.Multiline = true;
            this.txtSessionDetails.Name = "txtSessionDetails";
            this.txtSessionDetails.Size = new System.Drawing.Size(354, 32);
            this.txtSessionDetails.TabIndex = 54;
            this.txtSessionDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRollNumber
            // 
            // 
            // 
            // 
            this.txtRollNumber.Border.Class = "TextBoxBorder";
            this.txtRollNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRollNumber.Location = new System.Drawing.Point(270, 6);
            this.txtRollNumber.Name = "txtRollNumber";
            this.txtRollNumber.Size = new System.Drawing.Size(93, 20);
            this.txtRollNumber.TabIndex = 54;
            // 
            // labelX27
            // 
            this.labelX27.AutoSize = true;
            this.labelX27.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX27.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX27.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX27.Location = new System.Drawing.Point(187, 6);
            this.labelX27.Name = "labelX27";
            this.labelX27.Size = new System.Drawing.Size(66, 20);
            this.labelX27.TabIndex = 53;
            this.labelX27.Text = "تاريخ الجلسة";
            // 
            // dtSessionDate
            // 
            // 
            // 
            // 
            this.dtSessionDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtSessionDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtSessionDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtSessionDate.ButtonDropDown.Visible = true;
            this.dtSessionDate.IsPopupCalendarOpen = false;
            this.dtSessionDate.Location = new System.Drawing.Point(9, 6);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtSessionDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtSessionDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtSessionDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtSessionDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtSessionDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtSessionDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtSessionDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtSessionDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtSessionDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtSessionDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtSessionDate.MonthCalendar.DisplayMonth = new System.DateTime(2016, 3, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtSessionDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtSessionDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtSessionDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtSessionDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtSessionDate.MonthCalendar.TodayButtonVisible = true;
            this.dtSessionDate.Name = "dtSessionDate";
            this.dtSessionDate.Size = new System.Drawing.Size(163, 20);
            this.dtSessionDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtSessionDate.TabIndex = 52;
            // 
            // groupPanel4
            // 
            this.groupPanel4.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel4.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel4.Controls.Add(this.dgvSessions);
            this.groupPanel4.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupPanel4.Location = new System.Drawing.Point(545, 1);
            this.groupPanel4.Name = "groupPanel4";
            this.groupPanel4.Size = new System.Drawing.Size(243, 522);
            // 
            // 
            // 
            this.groupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel4.Style.BackColorGradientAngle = 90;
            this.groupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderBottomWidth = 1;
            this.groupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderLeftWidth = 1;
            this.groupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderRightWidth = 1;
            this.groupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderTopWidth = 1;
            this.groupPanel4.Style.CornerDiameter = 4;
            this.groupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal;
            this.groupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel4.TabIndex = 8;
            this.groupPanel4.Text = "الجلسات السابقة";
            // 
            // dgvSessions
            // 
            this.dgvSessions.AllowUserToAddRows = false;
            this.dgvSessions.AllowUserToDeleteRows = false;
            this.dgvSessions.AllowUserToOrderColumns = true;
            this.dgvSessions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSessionDate,
            this.colSessionRollNo,
            this.colSessionDetails,
            this.colSessionDecisions,
            this.colSessionNotes});
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSessions.DefaultCellStyle = dataGridViewCellStyle25;
            this.dgvSessions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSessions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvSessions.Location = new System.Drawing.Point(0, 0);
            this.dgvSessions.Name = "dgvSessions";
            this.dgvSessions.ReadOnly = true;
            this.dgvSessions.Size = new System.Drawing.Size(237, 501);
            this.dgvSessions.TabIndex = 44;
            this.dgvSessions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSessions_CellContentClick);
            this.dgvSessions.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvSessions_DataError);
            this.dgvSessions.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSessions_RowEnter);
            // 
            // colSessionDate
            // 
            this.colSessionDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSessionDate.HeaderText = "تاريخ الجلسة";
            this.colSessionDate.Name = "colSessionDate";
            this.colSessionDate.ReadOnly = true;
            // 
            // colSessionRollNo
            // 
            this.colSessionRollNo.HeaderText = "رقم الرول";
            this.colSessionRollNo.Name = "colSessionRollNo";
            this.colSessionRollNo.ReadOnly = true;
            this.colSessionRollNo.Visible = false;
            // 
            // colSessionDetails
            // 
            this.colSessionDetails.HeaderText = "تفاصيل الجلسة";
            this.colSessionDetails.Name = "colSessionDetails";
            this.colSessionDetails.ReadOnly = true;
            this.colSessionDetails.Visible = false;
            // 
            // colSessionDecisions
            // 
            this.colSessionDecisions.HeaderText = "القرارات";
            this.colSessionDecisions.Name = "colSessionDecisions";
            this.colSessionDecisions.ReadOnly = true;
            this.colSessionDecisions.Visible = false;
            // 
            // colSessionNotes
            // 
            this.colSessionNotes.HeaderText = "ملاحظات";
            this.colSessionNotes.Name = "colSessionNotes";
            this.colSessionNotes.ReadOnly = true;
            this.colSessionNotes.Visible = false;
            // 
            // tabItem2
            // 
            this.tabItem2.AttachedControl = this.tpSessions;
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = "الجلســــات";
            // 
            // tpFees
            // 
            this.tpFees.Controls.Add(this.groupPanel10);
            this.tpFees.DisabledBackColor = System.Drawing.Color.Empty;
            this.tpFees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpFees.Location = new System.Drawing.Point(0, 22);
            this.tpFees.Name = "tpFees";
            this.tpFees.Padding = new System.Windows.Forms.Padding(1);
            this.tpFees.Size = new System.Drawing.Size(789, 524);
            this.tpFees.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tpFees.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tpFees.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tpFees.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tpFees.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tpFees.Style.GradientAngle = 90;
            this.tpFees.TabIndex = 17;
            this.tpFees.TabItem = this.tabItem5;
            // 
            // groupPanel10
            // 
            this.groupPanel10.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel10.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel10.Controls.Add(this.panelEx1);
            this.groupPanel10.Controls.Add(this.labelX39);
            this.groupPanel10.Controls.Add(this.labelX40);
            this.groupPanel10.Controls.Add(this.labelX41);
            this.groupPanel10.Controls.Add(this.labelX42);
            this.groupPanel10.Controls.Add(this.diTotalAmount);
            this.groupPanel10.Controls.Add(this.diInstallsAmount);
            this.groupPanel10.Controls.Add(this.diRetensionAmount);
            this.groupPanel10.Controls.Add(this.diPresentAmount);
            this.groupPanel10.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel10.Location = new System.Drawing.Point(230, 30);
            this.groupPanel10.Name = "groupPanel10";
            this.groupPanel10.Size = new System.Drawing.Size(364, 217);
            // 
            // 
            // 
            this.groupPanel10.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel10.Style.BackColorGradientAngle = 90;
            this.groupPanel10.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel10.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel10.Style.BorderBottomWidth = 1;
            this.groupPanel10.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel10.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel10.Style.BorderLeftWidth = 1;
            this.groupPanel10.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel10.Style.BorderRightWidth = 1;
            this.groupPanel10.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel10.Style.BorderTopWidth = 1;
            this.groupPanel10.Style.CornerDiameter = 4;
            this.groupPanel10.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel10.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel10.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel10.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel10.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel10.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel10.TabIndex = 7;
            this.groupPanel10.Text = "تفاصيل الدفع";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(3, 131);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(342, 3);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 33;
            // 
            // labelX39
            // 
            this.labelX39.AutoSize = true;
            this.labelX39.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX39.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX39.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX39.Location = new System.Drawing.Point(272, 145);
            this.labelX39.Name = "labelX39";
            this.labelX39.Size = new System.Drawing.Size(43, 20);
            this.labelX39.TabIndex = 32;
            this.labelX39.Text = "الاجمالي";
            // 
            // labelX40
            // 
            this.labelX40.AutoSize = true;
            this.labelX40.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX40.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX40.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX40.Location = new System.Drawing.Point(278, 71);
            this.labelX40.Name = "labelX40";
            this.labelX40.Size = new System.Drawing.Size(38, 20);
            this.labelX40.TabIndex = 32;
            this.labelX40.Text = "الأقساط";
            // 
            // labelX41
            // 
            this.labelX41.AutoSize = true;
            this.labelX41.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX41.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX41.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX41.Location = new System.Drawing.Point(278, 39);
            this.labelX41.Name = "labelX41";
            this.labelX41.Size = new System.Drawing.Size(37, 20);
            this.labelX41.TabIndex = 32;
            this.labelX41.Text = "المؤجل";
            // 
            // labelX42
            // 
            this.labelX42.AutoSize = true;
            this.labelX42.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX42.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX42.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX42.Location = new System.Drawing.Point(284, 7);
            this.labelX42.Name = "labelX42";
            this.labelX42.Size = new System.Drawing.Size(31, 20);
            this.labelX42.TabIndex = 32;
            this.labelX42.Text = "المقدم";
            // 
            // diTotalAmount
            // 
            // 
            // 
            // 
            this.diTotalAmount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diTotalAmount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diTotalAmount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.diTotalAmount.Colors.Highlight = System.Drawing.Color.Blue;
            this.diTotalAmount.Colors.HighlightText = System.Drawing.Color.Red;
            this.diTotalAmount.Enabled = false;
            this.diTotalAmount.Increment = 1D;
            this.diTotalAmount.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.diTotalAmount.Location = new System.Drawing.Point(51, 145);
            this.diTotalAmount.MinValue = 0D;
            this.diTotalAmount.Name = "diTotalAmount";
            this.diTotalAmount.ShowUpDown = true;
            this.diTotalAmount.Size = new System.Drawing.Size(179, 20);
            this.diTotalAmount.TabIndex = 0;
            // 
            // diInstallsAmount
            // 
            // 
            // 
            // 
            this.diInstallsAmount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diInstallsAmount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diInstallsAmount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.diInstallsAmount.Colors.Highlight = System.Drawing.Color.Blue;
            this.diInstallsAmount.Colors.HighlightText = System.Drawing.Color.Red;
            this.diInstallsAmount.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.diInstallsAmount.Increment = 1D;
            this.diInstallsAmount.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.diInstallsAmount.Location = new System.Drawing.Point(51, 71);
            this.diInstallsAmount.MinValue = 0D;
            this.diInstallsAmount.Name = "diInstallsAmount";
            this.diInstallsAmount.ShowUpDown = true;
            this.diInstallsAmount.Size = new System.Drawing.Size(179, 20);
            this.diInstallsAmount.TabIndex = 0;
            this.diInstallsAmount.ValueChanged += new System.EventHandler(this.diInstallsAmount_ValueChanged);
            // 
            // diRetensionAmount
            // 
            // 
            // 
            // 
            this.diRetensionAmount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diRetensionAmount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diRetensionAmount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.diRetensionAmount.Colors.Highlight = System.Drawing.Color.Blue;
            this.diRetensionAmount.Colors.HighlightText = System.Drawing.Color.Red;
            this.diRetensionAmount.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.diRetensionAmount.Increment = 1D;
            this.diRetensionAmount.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.diRetensionAmount.Location = new System.Drawing.Point(51, 39);
            this.diRetensionAmount.MinValue = 0D;
            this.diRetensionAmount.Name = "diRetensionAmount";
            this.diRetensionAmount.ShowUpDown = true;
            this.diRetensionAmount.Size = new System.Drawing.Size(179, 20);
            this.diRetensionAmount.TabIndex = 0;
            this.diRetensionAmount.ValueChanged += new System.EventHandler(this.diRetensionAmount_ValueChanged);
            // 
            // diPresentAmount
            // 
            // 
            // 
            // 
            this.diPresentAmount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diPresentAmount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diPresentAmount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.diPresentAmount.Colors.Highlight = System.Drawing.Color.Blue;
            this.diPresentAmount.Colors.HighlightText = System.Drawing.Color.Red;
            this.diPresentAmount.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.diPresentAmount.Increment = 1D;
            this.diPresentAmount.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.diPresentAmount.Location = new System.Drawing.Point(51, 7);
            this.diPresentAmount.MinValue = 0D;
            this.diPresentAmount.Name = "diPresentAmount";
            this.diPresentAmount.ShowUpDown = true;
            this.diPresentAmount.Size = new System.Drawing.Size(179, 20);
            this.diPresentAmount.TabIndex = 0;
            this.diPresentAmount.ValueChanged += new System.EventHandler(this.diPresentAmount_ValueChanged);
            // 
            // tabItem5
            // 
            this.tabItem5.AttachedControl = this.tpFees;
            this.tabItem5.Name = "tabItem5";
            this.tabItem5.Text = "الأتعــــــــاب";
            // 
            // tpCLowers
            // 
            this.tpCLowers.Controls.Add(this.groupPanel7);
            this.tpCLowers.Controls.Add(this.groupPanel6);
            this.tpCLowers.DisabledBackColor = System.Drawing.Color.Empty;
            this.tpCLowers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpCLowers.Location = new System.Drawing.Point(0, 22);
            this.tpCLowers.Name = "tpCLowers";
            this.tpCLowers.Padding = new System.Windows.Forms.Padding(1);
            this.tpCLowers.Size = new System.Drawing.Size(789, 524);
            this.tpCLowers.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tpCLowers.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tpCLowers.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tpCLowers.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tpCLowers.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tpCLowers.Style.GradientAngle = 90;
            this.tpCLowers.TabIndex = 9;
            this.tpCLowers.TabItem = this.tabItem3;
            // 
            // groupPanel7
            // 
            this.groupPanel7.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel7.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel7.Controls.Add(this.btnAddCLower);
            this.groupPanel7.Controls.Add(this.labelX28);
            this.groupPanel7.Controls.Add(this.labelX31);
            this.groupPanel7.Controls.Add(this.labelX29);
            this.groupPanel7.Controls.Add(this.txtCLowerOtherDetails);
            this.groupPanel7.Controls.Add(this.labelX30);
            this.groupPanel7.Controls.Add(this.txtCLowerOffice);
            this.groupPanel7.Controls.Add(this.txtCLowerPhone);
            this.groupPanel7.Controls.Add(this.txtCLowerName);
            this.groupPanel7.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel7.Location = new System.Drawing.Point(36, 55);
            this.groupPanel7.Name = "groupPanel7";
            this.groupPanel7.Size = new System.Drawing.Size(454, 238);
            // 
            // 
            // 
            this.groupPanel7.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel7.Style.BackColorGradientAngle = 90;
            this.groupPanel7.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel7.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel7.Style.BorderBottomWidth = 1;
            this.groupPanel7.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel7.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel7.Style.BorderLeftWidth = 1;
            this.groupPanel7.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel7.Style.BorderRightWidth = 1;
            this.groupPanel7.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel7.Style.BorderTopWidth = 1;
            this.groupPanel7.Style.CornerDiameter = 4;
            this.groupPanel7.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel7.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel7.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel7.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel7.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel7.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel7.TabIndex = 35;
            this.groupPanel7.Text = "تفاصيل  المحامي";
            // 
            // btnAddCLower
            // 
            this.btnAddCLower.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddCLower.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddCLower.Image = global::LowerApplication.Properties.Resources.Add;
            this.btnAddCLower.Location = new System.Drawing.Point(3, 183);
            this.btnAddCLower.Name = "btnAddCLower";
            this.btnAddCLower.Size = new System.Drawing.Size(93, 31);
            this.btnAddCLower.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddCLower.TabIndex = 57;
            this.btnAddCLower.Text = "إضافة محامي";
            this.btnAddCLower.Click += new System.EventHandler(this.btnAddCLower_Click);
            // 
            // labelX28
            // 
            this.labelX28.AutoSize = true;
            this.labelX28.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX28.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX28.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX28.Location = new System.Drawing.Point(368, 122);
            this.labelX28.Name = "labelX28";
            this.labelX28.Size = new System.Drawing.Size(68, 20);
            this.labelX28.TabIndex = 41;
            this.labelX28.Text = "تفاصيل أخري";
            this.labelX28.Click += new System.EventHandler(this.labelX28_Click);
            // 
            // labelX31
            // 
            this.labelX31.AutoSize = true;
            this.labelX31.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX31.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX31.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX31.Location = new System.Drawing.Point(368, 66);
            this.labelX31.Name = "labelX31";
            this.labelX31.Size = new System.Drawing.Size(56, 20);
            this.labelX31.TabIndex = 41;
            this.labelX31.Text = "اسم المكتب";
            // 
            // labelX29
            // 
            this.labelX29.AutoSize = true;
            this.labelX29.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX29.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX29.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX29.Location = new System.Drawing.Point(368, 34);
            this.labelX29.Name = "labelX29";
            this.labelX29.Size = new System.Drawing.Size(61, 20);
            this.labelX29.TabIndex = 41;
            this.labelX29.Text = "رقم التليفون";
            // 
            // txtCLowerOtherDetails
            // 
            // 
            // 
            // 
            this.txtCLowerOtherDetails.Border.Class = "TextBoxBorder";
            this.txtCLowerOtherDetails.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCLowerOtherDetails.Location = new System.Drawing.Point(3, 117);
            this.txtCLowerOtherDetails.Multiline = true;
            this.txtCLowerOtherDetails.Name = "txtCLowerOtherDetails";
            this.txtCLowerOtherDetails.Size = new System.Drawing.Size(359, 30);
            this.txtCLowerOtherDetails.TabIndex = 40;
            // 
            // labelX30
            // 
            this.labelX30.AutoSize = true;
            this.labelX30.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX30.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX30.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX30.Location = new System.Drawing.Point(368, 3);
            this.labelX30.Name = "labelX30";
            this.labelX30.Size = new System.Drawing.Size(63, 20);
            this.labelX30.TabIndex = 41;
            this.labelX30.Text = "اسم المحامي";
            // 
            // txtCLowerOffice
            // 
            // 
            // 
            // 
            this.txtCLowerOffice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCLowerOffice.Location = new System.Drawing.Point(3, 66);
            this.txtCLowerOffice.Name = "txtCLowerOffice";
            this.txtCLowerOffice.Size = new System.Drawing.Size(359, 20);
            this.txtCLowerOffice.TabIndex = 40;
            // 
            // txtCLowerPhone
            // 
            // 
            // 
            // 
            this.txtCLowerPhone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCLowerPhone.Location = new System.Drawing.Point(3, 34);
            this.txtCLowerPhone.Name = "txtCLowerPhone";
            this.txtCLowerPhone.Size = new System.Drawing.Size(359, 20);
            this.txtCLowerPhone.TabIndex = 40;
            // 
            // txtCLowerName
            // 
            // 
            // 
            // 
            this.txtCLowerName.Border.Class = "TextBoxBorder";
            this.txtCLowerName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCLowerName.Location = new System.Drawing.Point(3, 3);
            this.txtCLowerName.Name = "txtCLowerName";
            this.txtCLowerName.Size = new System.Drawing.Size(359, 20);
            this.txtCLowerName.TabIndex = 40;
            // 
            // groupPanel6
            // 
            this.groupPanel6.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel6.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel6.Controls.Add(this.dgvCLowers);
            this.groupPanel6.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupPanel6.Location = new System.Drawing.Point(545, 1);
            this.groupPanel6.Name = "groupPanel6";
            this.groupPanel6.Size = new System.Drawing.Size(243, 522);
            // 
            // 
            // 
            this.groupPanel6.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel6.Style.BackColorGradientAngle = 90;
            this.groupPanel6.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel6.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel6.Style.BorderBottomWidth = 1;
            this.groupPanel6.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel6.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel6.Style.BorderLeftWidth = 1;
            this.groupPanel6.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel6.Style.BorderRightWidth = 1;
            this.groupPanel6.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel6.Style.BorderTopWidth = 1;
            this.groupPanel6.Style.CornerDiameter = 4;
            this.groupPanel6.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal;
            this.groupPanel6.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel6.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            // 
            // 
            // 
            this.groupPanel6.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel6.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel6.TabIndex = 33;
            this.groupPanel6.Text = "محامي الخصم";
            // 
            // dgvCLowers
            // 
            this.dgvCLowers.AllowUserToAddRows = false;
            this.dgvCLowers.AllowUserToDeleteRows = false;
            this.dgvCLowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCLowers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colClowerName,
            this.colClowerPhone,
            this.colClowerOffice,
            this.colClowerDetails});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCLowers.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgvCLowers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCLowers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCLowers.Location = new System.Drawing.Point(0, 0);
            this.dgvCLowers.Name = "dgvCLowers";
            this.dgvCLowers.ReadOnly = true;
            this.dgvCLowers.Size = new System.Drawing.Size(237, 501);
            this.dgvCLowers.TabIndex = 32;
            this.dgvCLowers.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvCLowers_DataError);
            this.dgvCLowers.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCLowers_RowEnter);
            // 
            // colClowerName
            // 
            this.colClowerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colClowerName.HeaderText = "الاســـــــــم";
            this.colClowerName.Name = "colClowerName";
            this.colClowerName.ReadOnly = true;
            // 
            // colClowerPhone
            // 
            this.colClowerPhone.HeaderText = "رقم التليفون";
            this.colClowerPhone.Name = "colClowerPhone";
            this.colClowerPhone.ReadOnly = true;
            this.colClowerPhone.Visible = false;
            // 
            // colClowerOffice
            // 
            this.colClowerOffice.HeaderText = "المكتب";
            this.colClowerOffice.Name = "colClowerOffice";
            this.colClowerOffice.ReadOnly = true;
            this.colClowerOffice.Visible = false;
            // 
            // colClowerDetails
            // 
            this.colClowerDetails.HeaderText = "تفاصيل أخرى";
            this.colClowerDetails.Name = "colClowerDetails";
            this.colClowerDetails.ReadOnly = true;
            this.colClowerDetails.Visible = false;
            // 
            // tabItem3
            // 
            this.tabItem3.AttachedControl = this.tpCLowers;
            this.tabItem3.Name = "tabItem3";
            this.tabItem3.Text = "محامي الخصم";
            // 
            // frmCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 730);
            this.Name = "frmCase";
            this.Text = "frmCase";
            this.Load += new System.EventHandler(this.frmCase_Load);
            this.gpnlBody.ResumeLayout(false);
            this.gpnlBody.PerformLayout();
            this.ribnpnlHeader.ResumeLayout(false);
            this.ribnpnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._errorfrmProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcCaseDetails)).EndInit();
            this.tcCaseDetails.ResumeLayout(false);
            this.tpDelegators.ResumeLayout(false);
            this.groupPanel9.ResumeLayout(false);
            this.groupPanel9.PerformLayout();
            this.groupPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelegators)).EndInit();
            this.tpGeneralCaseData.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            this.groupPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iiadministrativeNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iiTotalNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iiPartialNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iiImprisonmentNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iiInvestigationNumer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iifinenumber)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtRecievingDate)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iiDelegationNumber)).EndInit();
            this.tpSessions.ResumeLayout(false);
            this.groupPanel5.ResumeLayout(false);
            this.groupPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtSessionDate)).EndInit();
            this.groupPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).EndInit();
            this.tpFees.ResumeLayout(false);
            this.groupPanel10.ResumeLayout(false);
            this.groupPanel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diTotalAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diInstallsAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diRetensionAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diPresentAmount)).EndInit();
            this.tpCLowers.ResumeLayout(false);
            this.groupPanel7.ResumeLayout(false);
            this.groupPanel7.PerformLayout();
            this.groupPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCLowers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCases;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearchKeyword;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxCaseParameters;
        private DevComponents.Editors.ComboItem AdminNumber;
        private DevComponents.Editors.ComboItem FineNumber;
        private DevComponents.Editors.ComboItem InvestigationNumber;
        private DevComponents.Editors.ComboItem ImprisonmentNumber;
        private DevComponents.Editors.ComboItem PartialNumber;
        private DevComponents.Editors.ComboItem TotalNumber;
        private DevComponents.Editors.ComboItem DelegationNumber;
        private DevComponents.Editors.ComboItem CaseSubject;
        private DevComponents.Editors.ComboItem DelegatorName;
        private DevComponents.Editors.ComboItem DelegatorSSN;
        private DevComponents.Editors.ComboItem DelegatorMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaseSubject;
        private DevComponents.DotNetBar.TabControl tcCaseDetails;
        private DevComponents.DotNetBar.TabControlPanel tpGeneralCaseData;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.TabControlPanel tpFees;
        private DevComponents.DotNetBar.TabItem tabItem5;
        private DevComponents.DotNetBar.TabControlPanel tpDelegators;
        private DevComponents.DotNetBar.TabItem tabItem4;
        private DevComponents.DotNetBar.TabControlPanel tpCLowers;
        private DevComponents.DotNetBar.TabItem tabItem3;
        private DevComponents.DotNetBar.TabControlPanel tpSessions;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.Editors.IntegerInput iiadministrativeNumber;
        private DevComponents.DotNetBar.Controls.TextBoxX txtadministrativestring;
        private DevComponents.DotNetBar.LabelX labelX17;
        private DevComponents.DotNetBar.Controls.TextBoxX txtfinestring;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtInvestigationString;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtImprisonString;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPartialString;
        private DevComponents.Editors.IntegerInput iiTotalNumber;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTotalString;
        private DevComponents.Editors.IntegerInput iiPartialNumber;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.Editors.IntegerInput iiImprisonmentNumber;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.Editors.IntegerInput iiInvestigationNumer;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.Editors.IntegerInput iifinenumber;
        private DevComponents.DotNetBar.LabelX labelX18;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnAddChamber;
        private DevComponents.DotNetBar.ButtonX btnAddCourt;
        private DevComponents.DotNetBar.LabelX labelX19;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtRecievingDate;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxChamber;
        private DevComponents.DotNetBar.LabelX labelX20;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxCourt;
        private DevComponents.DotNetBar.LabelX labelX21;
        private DevComponents.DotNetBar.LabelX labelX22;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCaseDetails;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCaseSubject;
        private DevComponents.DotNetBar.LabelX lblUseraName;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX btnAddDocumentationOffice;
        private DevComponents.DotNetBar.LabelX labelX23;
        private DevComponents.DotNetBar.LabelX labelX24;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxDocumentationOffice;
        private DevComponents.DotNetBar.LabelX labelX25;
        private DevComponents.Editors.IntegerInput iiDelegationNumber;
        private DevComponents.DotNetBar.LabelX labelX26;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDelegationString;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDelegationLetter;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel4;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSessions;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel5;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSessionNotes;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSessionOrders;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSessionDetails;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRollNumber;
        private DevComponents.DotNetBar.LabelX labelX27;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtSessionDate;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCLowers;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel6;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel7;
        private DevComponents.DotNetBar.LabelX labelX28;
        private DevComponents.DotNetBar.LabelX labelX29;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCLowerOtherDetails;
        private DevComponents.DotNetBar.LabelX labelX30;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCLowerPhone;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCLowerName;
        private DevComponents.DotNetBar.LabelX labelX31;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCLowerOffice;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel8;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDelegators;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel9;
        private DevComponents.DotNetBar.LabelX labelX32;
        private DevComponents.DotNetBar.LabelX labelX33;
        private DevComponents.DotNetBar.LabelX labelX34;
        private DevComponents.DotNetBar.LabelX labelX35;
        private DevComponents.DotNetBar.LabelX labelX37;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDelegatorDetails;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDelegatorSSN;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDelegatorPhone;
        private DevComponents.DotNetBar.LabelX labelX38;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDelegatorMobile;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDelegatorAddress;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDelegatorName;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel10;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX39;
        private DevComponents.DotNetBar.LabelX labelX40;
        private DevComponents.DotNetBar.LabelX labelX41;
        private DevComponents.DotNetBar.LabelX labelX42;
        private DevComponents.Editors.DoubleInput diTotalAmount;
        private DevComponents.Editors.DoubleInput diInstallsAmount;
        private DevComponents.Editors.DoubleInput diRetensionAmount;
        private DevComponents.Editors.DoubleInput diPresentAmount;
        private DevComponents.DotNetBar.ButtonX btnAddSession;
        private DevComponents.DotNetBar.ButtonX btnAddCLower;
        private DevComponents.DotNetBar.ButtonX btnAddDelegator;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClowerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClowerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClowerOffice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClowerDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSessionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSessionRollNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSessionDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSessionDecisions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSessionNotes;
        private DevComponents.DotNetBar.LabelX labelX36;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCase_Del_Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDelegatorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDelegatorAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDelegatorSSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDelegatorPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDelegatorMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDelegatorDetails;
    }
}