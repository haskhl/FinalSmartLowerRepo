namespace LowerApplication.Forms
{
    partial class frmPayments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.ckbxInstalls = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.ckbxRetention = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.ckbxPresent = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.diTotalAmount = new DevComponents.Editors.DoubleInput();
            this.diInstallsAmount = new DevComponents.Editors.DoubleInput();
            this.diRetensionAmount = new DevComponents.Editors.DoubleInput();
            this.diPresentAmount = new DevComponents.Editors.DoubleInput();
            this.dgvCases = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.gpPanelRemaining = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lblRemTotal = new DevComponents.DotNetBar.LabelX();
            this.lblRemInstalls = new DevComponents.DotNetBar.LabelX();
            this.lblRemRetension = new DevComponents.DotNetBar.LabelX();
            this.lblRemPresent = new DevComponents.DotNetBar.LabelX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.gpnlBody.SuspendLayout();
            this.ribnpnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._errorfrmProvider)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diTotalAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diInstallsAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diRetensionAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diPresentAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCases)).BeginInit();
            this.gpPanelRemaining.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpnlBody
            // 
            this.gpnlBody.Controls.Add(this.gpPanelRemaining);
            this.gpnlBody.Controls.Add(this.dgvCases);
            this.gpnlBody.Controls.Add(this.groupPanel1);
            this.gpnlBody.Location = new System.Drawing.Point(5, 105);
            this.gpnlBody.Size = new System.Drawing.Size(574, 313);
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
            this.gpnlBody.Controls.SetChildIndex(this.barOperation, 0);
            this.gpnlBody.Controls.SetChildIndex(this.groupPanel1, 0);
            this.gpnlBody.Controls.SetChildIndex(this.dgvCases, 0);
            this.gpnlBody.Controls.SetChildIndex(this.gpPanelRemaining, 0);
            // 
            // ribnpnlHeader
            // 
            this.ribnpnlHeader.Size = new System.Drawing.Size(574, 104);
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
            this.lblDetialsTitle.Size = new System.Drawing.Size(161, 16);
            this.lblDetialsTitle.Text = "تسجيل سداد العملاء لاتعاب القضايا";
            // 
            // lblFormTitle
            // 
            // 
            // 
            // 
            this.lblFormTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblFormTitle.Size = new System.Drawing.Size(76, 32);
            this.lblFormTitle.Text = "التحصيل";
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = global::LowerApplication.Properties.Resources.payment_icon;
            // 
            // barOperation
            // 
            this.barOperation.Size = new System.Drawing.Size(568, 30);
            // 
            // btnNew
            // 
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Visible = false;
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
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.ckbxInstalls);
            this.groupPanel1.Controls.Add(this.ckbxRetention);
            this.groupPanel1.Controls.Add(this.ckbxPresent);
            this.groupPanel1.Controls.Add(this.panelEx1);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.diTotalAmount);
            this.groupPanel1.Controls.Add(this.diInstallsAmount);
            this.groupPanel1.Controls.Add(this.diRetensionAmount);
            this.groupPanel1.Controls.Add(this.diPresentAmount);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(223, 130);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(338, 174);
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
            this.groupPanel1.TabIndex = 32;
            this.groupPanel1.Text = "تفاصيل عملية الدفع الحالية";
            this.groupPanel1.Click += new System.EventHandler(this.groupPanel1_Click);
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
            this.labelX4.Location = new System.Drawing.Point(11, 71);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(16, 20);
            this.labelX4.TabIndex = 35;
            this.labelX4.Text = "جم";
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
            this.labelX2.Location = new System.Drawing.Point(11, 39);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(16, 20);
            this.labelX2.TabIndex = 35;
            this.labelX2.Text = "جم";
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
            this.labelX1.Location = new System.Drawing.Point(11, 7);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(16, 20);
            this.labelX1.TabIndex = 35;
            this.labelX1.Text = "جم";
            // 
            // ckbxInstalls
            // 
            this.ckbxInstalls.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.ckbxInstalls.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ckbxInstalls.Checked = true;
            this.ckbxInstalls.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbxInstalls.CheckValue = "Y";
            this.ckbxInstalls.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.ckbxInstalls.Location = new System.Drawing.Point(214, 71);
            this.ckbxInstalls.Name = "ckbxInstalls";
            this.ckbxInstalls.Size = new System.Drawing.Size(113, 23);
            this.ckbxInstalls.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ckbxInstalls.TabIndex = 34;
            this.ckbxInstalls.Text = "سداد من الاقساط";
            this.ckbxInstalls.CheckedChanged += new System.EventHandler(this.ckbxInstalls_CheckedChanged);
            // 
            // ckbxRetention
            // 
            this.ckbxRetention.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.ckbxRetention.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ckbxRetention.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.ckbxRetention.Location = new System.Drawing.Point(214, 36);
            this.ckbxRetention.Name = "ckbxRetention";
            this.ckbxRetention.Size = new System.Drawing.Size(113, 23);
            this.ckbxRetention.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ckbxRetention.TabIndex = 34;
            this.ckbxRetention.Text = "سداد من المؤخر";
            this.ckbxRetention.CheckedChanged += new System.EventHandler(this.ckbxRetention_CheckedChanged);
            // 
            // ckbxPresent
            // 
            this.ckbxPresent.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.ckbxPresent.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ckbxPresent.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.ckbxPresent.Location = new System.Drawing.Point(214, 4);
            this.ckbxPresent.Name = "ckbxPresent";
            this.ckbxPresent.Size = new System.Drawing.Size(113, 23);
            this.ckbxPresent.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ckbxPresent.TabIndex = 34;
            this.ckbxPresent.Text = "سداد من المقدم";
            this.ckbxPresent.CheckedChanged += new System.EventHandler(this.ckbxPresent_CheckedChanged);
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(0, 101);
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
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(223, 114);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(94, 20);
            this.labelX3.TabIndex = 32;
            this.labelX3.Text = "إجمالي قيمة السداد";
            // 
            // diTotalAmount
            // 
            this.diTotalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
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
            this.diTotalAmount.Location = new System.Drawing.Point(29, 114);
            this.diTotalAmount.MinValue = 0D;
            this.diTotalAmount.Name = "diTotalAmount";
            this.diTotalAmount.ShowUpDown = true;
            this.diTotalAmount.Size = new System.Drawing.Size(179, 20);
            this.diTotalAmount.TabIndex = 0;
            // 
            // diInstallsAmount
            // 
            this.diInstallsAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
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
            this.diInstallsAmount.Location = new System.Drawing.Point(29, 71);
            this.diInstallsAmount.MinValue = 0D;
            this.diInstallsAmount.Name = "diInstallsAmount";
            this.diInstallsAmount.ShowUpDown = true;
            this.diInstallsAmount.Size = new System.Drawing.Size(179, 20);
            this.diInstallsAmount.TabIndex = 0;
            this.diInstallsAmount.ValueChanged += new System.EventHandler(this.diInstallsAmount_ValueChanged);
            // 
            // diRetensionAmount
            // 
            this.diRetensionAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.diRetensionAmount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diRetensionAmount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diRetensionAmount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.diRetensionAmount.Colors.Highlight = System.Drawing.Color.Blue;
            this.diRetensionAmount.Colors.HighlightText = System.Drawing.Color.Red;
            this.diRetensionAmount.Enabled = false;
            this.diRetensionAmount.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.diRetensionAmount.Increment = 1D;
            this.diRetensionAmount.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.diRetensionAmount.Location = new System.Drawing.Point(29, 39);
            this.diRetensionAmount.MinValue = 0D;
            this.diRetensionAmount.Name = "diRetensionAmount";
            this.diRetensionAmount.ShowUpDown = true;
            this.diRetensionAmount.Size = new System.Drawing.Size(179, 20);
            this.diRetensionAmount.TabIndex = 0;
            this.diRetensionAmount.ValueChanged += new System.EventHandler(this.diRetensionAmount_ValueChanged);
            // 
            // diPresentAmount
            // 
            this.diPresentAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.diPresentAmount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diPresentAmount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diPresentAmount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.diPresentAmount.Colors.Highlight = System.Drawing.Color.Blue;
            this.diPresentAmount.Colors.HighlightText = System.Drawing.Color.Red;
            this.diPresentAmount.Enabled = false;
            this.diPresentAmount.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.diPresentAmount.Increment = 1D;
            this.diPresentAmount.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.diPresentAmount.Location = new System.Drawing.Point(29, 7);
            this.diPresentAmount.MinValue = 0D;
            this.diPresentAmount.Name = "diPresentAmount";
            this.diPresentAmount.ShowUpDown = true;
            this.diPresentAmount.Size = new System.Drawing.Size(179, 20);
            this.diPresentAmount.TabIndex = 0;
            this.diPresentAmount.ValueChanged += new System.EventHandler(this.diPresentAmount_ValueChanged);
            // 
            // dgvCases
            // 
            this.dgvCases.AllowUserToAddRows = false;
            this.dgvCases.AllowUserToDeleteRows = false;
            this.dgvCases.AllowUserToOrderColumns = true;
            this.dgvCases.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCases.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCases.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCases.Location = new System.Drawing.Point(9, 36);
            this.dgvCases.Name = "dgvCases";
            this.dgvCases.ReadOnly = true;
            this.dgvCases.Size = new System.Drawing.Size(552, 88);
            this.dgvCases.TabIndex = 33;
            this.dgvCases.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvCases_DataError);
            // 
            // gpPanelRemaining
            // 
            this.gpPanelRemaining.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpPanelRemaining.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpPanelRemaining.Controls.Add(this.lblRemTotal);
            this.gpPanelRemaining.Controls.Add(this.lblRemInstalls);
            this.gpPanelRemaining.Controls.Add(this.lblRemRetension);
            this.gpPanelRemaining.Controls.Add(this.lblRemPresent);
            this.gpPanelRemaining.Controls.Add(this.panelEx2);
            this.gpPanelRemaining.Controls.Add(this.labelX8);
            this.gpPanelRemaining.Controls.Add(this.labelX7);
            this.gpPanelRemaining.Controls.Add(this.labelX6);
            this.gpPanelRemaining.Controls.Add(this.labelX5);
            this.gpPanelRemaining.DisabledBackColor = System.Drawing.Color.Empty;
            this.gpPanelRemaining.Location = new System.Drawing.Point(9, 130);
            this.gpPanelRemaining.Name = "gpPanelRemaining";
            this.gpPanelRemaining.Size = new System.Drawing.Size(198, 174);
            // 
            // 
            // 
            this.gpPanelRemaining.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpPanelRemaining.Style.BackColorGradientAngle = 90;
            this.gpPanelRemaining.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpPanelRemaining.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpPanelRemaining.Style.BorderBottomWidth = 1;
            this.gpPanelRemaining.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpPanelRemaining.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpPanelRemaining.Style.BorderLeftWidth = 1;
            this.gpPanelRemaining.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpPanelRemaining.Style.BorderRightWidth = 1;
            this.gpPanelRemaining.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpPanelRemaining.Style.BorderTopWidth = 1;
            this.gpPanelRemaining.Style.CornerDiameter = 4;
            this.gpPanelRemaining.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpPanelRemaining.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpPanelRemaining.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpPanelRemaining.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpPanelRemaining.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpPanelRemaining.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpPanelRemaining.TabIndex = 37;
            this.gpPanelRemaining.Text = "تفاصيل القيم المتبقية";
            // 
            // lblRemTotal
            // 
            this.lblRemTotal.BackColor = System.Drawing.Color.Red;
            // 
            // 
            // 
            this.lblRemTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRemTotal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblRemTotal.Location = new System.Drawing.Point(3, 113);
            this.lblRemTotal.Name = "lblRemTotal";
            this.lblRemTotal.Size = new System.Drawing.Size(83, 23);
            this.lblRemTotal.TabIndex = 38;
            this.lblRemTotal.Text = "000";
            this.lblRemTotal.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblRemInstalls
            // 
            this.lblRemInstalls.BackColor = System.Drawing.Color.Red;
            // 
            // 
            // 
            this.lblRemInstalls.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRemInstalls.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblRemInstalls.Location = new System.Drawing.Point(3, 65);
            this.lblRemInstalls.Name = "lblRemInstalls";
            this.lblRemInstalls.Size = new System.Drawing.Size(83, 23);
            this.lblRemInstalls.TabIndex = 38;
            this.lblRemInstalls.Text = "000";
            this.lblRemInstalls.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblRemRetension
            // 
            this.lblRemRetension.BackColor = System.Drawing.Color.Red;
            // 
            // 
            // 
            this.lblRemRetension.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRemRetension.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblRemRetension.Location = new System.Drawing.Point(3, 33);
            this.lblRemRetension.Name = "lblRemRetension";
            this.lblRemRetension.Size = new System.Drawing.Size(83, 23);
            this.lblRemRetension.TabIndex = 38;
            this.lblRemRetension.Text = "000";
            this.lblRemRetension.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblRemPresent
            // 
            this.lblRemPresent.BackColor = System.Drawing.Color.Red;
            // 
            // 
            // 
            this.lblRemPresent.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRemPresent.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblRemPresent.Location = new System.Drawing.Point(3, 1);
            this.lblRemPresent.Name = "lblRemPresent";
            this.lblRemPresent.Size = new System.Drawing.Size(83, 23);
            this.lblRemPresent.TabIndex = 38;
            this.lblRemPresent.Text = "000";
            this.lblRemPresent.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Location = new System.Drawing.Point(0, 95);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(195, 3);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 37;
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
            this.labelX8.Location = new System.Drawing.Point(94, 114);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(99, 20);
            this.labelX8.TabIndex = 36;
            this.labelX8.Text = "إجمالي قيمة المتبقي";
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
            this.labelX7.Location = new System.Drawing.Point(98, 66);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(95, 20);
            this.labelX7.TabIndex = 36;
            this.labelX7.Text = "المتبقي من الأقساط";
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
            this.labelX6.Location = new System.Drawing.Point(100, 34);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(93, 20);
            this.labelX6.TabIndex = 36;
            this.labelX6.Text = "المتبقي من المؤخر";
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
            this.labelX5.Location = new System.Drawing.Point(106, 2);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(87, 20);
            this.labelX5.TabIndex = 36;
            this.labelX5.Text = "المتبقي من المقدم";
            // 
            // frmPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 420);
            this.Name = "frmPayments";
            this.Text = "frmPayments";
            this.Load += new System.EventHandler(this.frmPayments_Load);
            this.gpnlBody.ResumeLayout(false);
            this.ribnpnlHeader.ResumeLayout(false);
            this.ribnpnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._errorfrmProvider)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diTotalAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diInstallsAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diRetensionAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diPresentAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCases)).EndInit();
            this.gpPanelRemaining.ResumeLayout(false);
            this.gpPanelRemaining.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.Editors.DoubleInput diTotalAmount;
        private DevComponents.Editors.DoubleInput diInstallsAmount;
        private DevComponents.Editors.DoubleInput diRetensionAmount;
        private DevComponents.Editors.DoubleInput diPresentAmount;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCases;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.CheckBoxX ckbxInstalls;
        private DevComponents.DotNetBar.Controls.CheckBoxX ckbxRetention;
        private DevComponents.DotNetBar.Controls.CheckBoxX ckbxPresent;
        private DevComponents.DotNetBar.Controls.GroupPanel gpPanelRemaining;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX lblRemTotal;
        private DevComponents.DotNetBar.LabelX lblRemInstalls;
        private DevComponents.DotNetBar.LabelX lblRemRetension;
        private DevComponents.DotNetBar.LabelX lblRemPresent;
    }
}