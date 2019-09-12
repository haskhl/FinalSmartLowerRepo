namespace LowerApplication.Forms
{
    partial class frmMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaster));
            this.gpnlBody = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.barOperation = new DevComponents.DotNetBar.Bar();
            this.lblSplit1 = new DevComponents.DotNetBar.LabelItem();
            this.ribnpnlHeader = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.lblDetialsTitle = new DevComponents.DotNetBar.LabelX();
            this.lblFormTitle = new DevComponents.DotNetBar.LabelX();
            this._errorfrmProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this._errorfrmSuperValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this._errorfrmHighlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.btnNew = new DevComponents.DotNetBar.ButtonItem();
            this.btnSearch = new DevComponents.DotNetBar.ButtonItem();
            this.btnSave = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.gpnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barOperation)).BeginInit();
            this.ribnpnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorfrmProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gpnlBody
            // 
            this.gpnlBody.BackColor = System.Drawing.Color.White;
            this.gpnlBody.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpnlBody.Controls.Add(this.barOperation);
            this.gpnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpnlBody.IsShadowEnabled = true;
            this.gpnlBody.Location = new System.Drawing.Point(4, 105);
            this.gpnlBody.Name = "gpnlBody";
            this.gpnlBody.Size = new System.Drawing.Size(560, 283);
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
            this.gpnlBody.Style.Class = "";
            this.gpnlBody.Style.CornerDiameter = 4;
            this.gpnlBody.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpnlBody.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpnlBody.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpnlBody.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpnlBody.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.gpnlBody.StyleMouseOver.Class = "";
            this.gpnlBody.TabIndex = 6;
            // 
            // barOperation
            // 
            this.barOperation.AntiAlias = true;
            this.barOperation.BackColor = System.Drawing.Color.White;
            this.barOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.barOperation.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.barOperation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.barOperation.ForeColor = System.Drawing.Color.Black;
            this.barOperation.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lblSplit1,
            this.btnNew,
            this.btnSearch,
            this.btnSave,
            this.btnDelete,
            this.btnClose});
            this.barOperation.Location = new System.Drawing.Point(0, 0);
            this.barOperation.Name = "barOperation";
            this.barOperation.Size = new System.Drawing.Size(554, 30);
            this.barOperation.Stretch = true;
            this.barOperation.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.barOperation.TabIndex = 5;
            this.barOperation.TabStop = false;
            // 
            // lblSplit1
            // 
            this.lblSplit1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplit1.ForeColor = System.Drawing.Color.Black;
            this.lblSplit1.Name = "lblSplit1";
            // 
            // ribnpnlHeader
            // 
            this.ribnpnlHeader.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribnpnlHeader.Controls.Add(this.lblDetialsTitle);
            this.ribnpnlHeader.Controls.Add(this.lblFormTitle);
            this.ribnpnlHeader.Controls.Add(this.picBoxLogo);
            this.ribnpnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribnpnlHeader.IsShadowEnabled = false;
            this.ribnpnlHeader.Location = new System.Drawing.Point(4, 1);
            this.ribnpnlHeader.Name = "ribnpnlHeader";
            this.ribnpnlHeader.Size = new System.Drawing.Size(560, 104);
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
            this.ribnpnlHeader.Style.Class = "";
            this.ribnpnlHeader.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.ribnpnlHeader.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            // 
            // 
            // 
            this.ribnpnlHeader.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.ribnpnlHeader.StyleMouseOver.Class = "";
            this.ribnpnlHeader.TabIndex = 4;
            // 
            // lblDetialsTitle
            // 
            this.lblDetialsTitle.AutoSize = true;
            this.lblDetialsTitle.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblDetialsTitle.BackgroundStyle.Class = "";
            this.lblDetialsTitle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetialsTitle.ForeColor = System.Drawing.Color.Black;
            this.lblDetialsTitle.Location = new System.Drawing.Point(188, 66);
            this.lblDetialsTitle.Name = "lblDetialsTitle";
            this.lblDetialsTitle.Size = new System.Drawing.Size(238, 16);
            this.lblDetialsTitle.TabIndex = 2;
            this.lblDetialsTitle.Text = "تستخدم هذه النافـــذة في حفظ بيانات المستخدمين";
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblFormTitle.BackgroundStyle.Class = "";
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.Black;
            this.lblFormTitle.Location = new System.Drawing.Point(236, 30);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(133, 30);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "العنوان الرئيسي";
            // 
            // _errorfrmProvider
            // 
            this._errorfrmProvider.ContainerControl = this;
            this._errorfrmProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("_errorfrmProvider.Icon")));
            // 
            // _errorfrmSuperValidator
            // 
            this._errorfrmSuperValidator.ErrorProvider = this._errorfrmProvider;
            this._errorfrmSuperValidator.Highlighter = this._errorfrmHighlighter;
            // 
            // _errorfrmHighlighter
            // 
            this._errorfrmHighlighter.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Green;
            // 
            // btnNew
            // 
            this.btnNew.BeginGroup = true;
            this.btnNew.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnNew.FixedSize = new System.Drawing.Size(70, 27);
            this.btnNew.FontBold = true;
            this.btnNew.Image = global::LowerApplication.Properties.Resources.document_new;
            this.btnNew.Name = "btnNew";
            this.btnNew.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
            this.btnNew.Text = "جديــد";
            this.btnNew.Tooltip = " اضافة جديد ";
            // 
            // btnSearch
            // 
            this.btnSearch.BeginGroup = true;
            this.btnSearch.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSearch.FixedSize = new System.Drawing.Size(70, 27);
            this.btnSearch.FontBold = true;
            this.btnSearch.Image = global::LowerApplication.Properties.Resources._1353914072_find;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlF);
            this.btnSearch.Text = "بحــــث";
            // 
            // btnSave
            // 
            this.btnSave.BeginGroup = true;
            this.btnSave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSave.FixedSize = new System.Drawing.Size(70, 27);
            this.btnSave.FontBold = true;
            this.btnSave.Image = global::LowerApplication.Properties.Resources.disk_blue_ok2;
            this.btnSave.Name = "btnSave";
            this.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSave.Text = "حفـــــظ";
            // 
            // btnDelete
            // 
            this.btnDelete.BeginGroup = true;
            this.btnDelete.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDelete.FixedSize = new System.Drawing.Size(70, 27);
            this.btnDelete.FontBold = true;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlD);
            this.btnDelete.Text = "حــذف";
            // 
            // btnClose
            // 
            this.btnClose.BeginGroup = true;
            this.btnClose.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnClose.FixedSize = new System.Drawing.Size(70, 27);
            this.btnClose.FontBold = true;
            this.btnClose.Image = global::LowerApplication.Properties.Resources.gnome_logout1;
            this.btnClose.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.btnClose.Name = "btnClose";
            this.btnClose.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.AltF4);
            this.btnClose.Text = "خــروج";
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.picBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxLogo.ForeColor = System.Drawing.Color.Black;
            this.picBoxLogo.Image = global::LowerApplication.Properties.Resources.مطرقة;
            this.picBoxLogo.Location = new System.Drawing.Point(5, 8);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(177, 90);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogo.TabIndex = 0;
            this.picBoxLogo.TabStop = false;
            // 
            // frmMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 390);
            this.Controls.Add(this.gpnlBody);
            this.Controls.Add(this.ribnpnlHeader);
            this.Name = "frmMaster";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmMaster";
            this.Load += new System.EventHandler(this.frmMaster_Load);
            this.gpnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barOperation)).EndInit();
            this.ribnpnlHeader.ResumeLayout(false);
            this.ribnpnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorfrmProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevComponents.DotNetBar.Controls.GroupPanel gpnlBody;
        protected DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribnpnlHeader;
        protected DevComponents.DotNetBar.LabelX lblDetialsTitle;
        protected DevComponents.DotNetBar.LabelX lblFormTitle;
        protected System.Windows.Forms.PictureBox picBoxLogo;
        protected DevComponents.DotNetBar.Bar barOperation;
        protected DevComponents.DotNetBar.LabelItem lblSplit1;
        protected DevComponents.DotNetBar.ButtonItem btnNew;
        protected DevComponents.DotNetBar.ButtonItem btnSearch;
        protected DevComponents.DotNetBar.ButtonItem btnSave;
        protected DevComponents.DotNetBar.ButtonItem btnDelete;
        protected DevComponents.DotNetBar.ButtonItem btnClose;
        protected System.Windows.Forms.ErrorProvider _errorfrmProvider;
        protected DevComponents.DotNetBar.Validator.SuperValidator _errorfrmSuperValidator;
        protected DevComponents.DotNetBar.Validator.Highlighter _errorfrmHighlighter;
    }
}