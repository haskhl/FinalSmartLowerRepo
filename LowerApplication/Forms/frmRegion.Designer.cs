namespace LowerApplication.Forms
{
    partial class frmRegion
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lblUseraName = new DevComponents.DotNetBar.LabelX();
            this.txtDetails = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.gpnlBody.SuspendLayout();
            this.ribnpnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._errorfrmProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gpnlBody
            // 
            this.gpnlBody.Controls.Add(this.labelX1);
            this.gpnlBody.Controls.Add(this.lblUseraName);
            this.gpnlBody.Controls.Add(this.txtDetails);
            this.gpnlBody.Controls.Add(this.txtName);
            this.gpnlBody.Location = new System.Drawing.Point(5, 105);
            this.gpnlBody.Size = new System.Drawing.Size(396, 142);
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
            this.gpnlBody.Click += new System.EventHandler(this.gpnlBody_Click);
            this.gpnlBody.Controls.SetChildIndex(this.barOperation, 0);
            this.gpnlBody.Controls.SetChildIndex(this.txtName, 0);
            this.gpnlBody.Controls.SetChildIndex(this.txtDetails, 0);
            this.gpnlBody.Controls.SetChildIndex(this.lblUseraName, 0);
            this.gpnlBody.Controls.SetChildIndex(this.labelX1, 0);
            // 
            // ribnpnlHeader
            // 
            this.ribnpnlHeader.Size = new System.Drawing.Size(396, 104);
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
            this.lblDetialsTitle.Location = new System.Drawing.Point(61, 78);
            this.lblDetialsTitle.Size = new System.Drawing.Size(215, 16);
            this.lblDetialsTitle.Text = "تستخدم هذه النافـــذة في حفظ بيانات المناطق";
            // 
            // lblFormTitle
            // 
            // 
            // 
            // 
            this.lblFormTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblFormTitle.Location = new System.Drawing.Point(104, 42);
            this.lblFormTitle.Size = new System.Drawing.Size(147, 32);
            this.lblFormTitle.Text = "المناطق الرئيسية";
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = global::LowerApplication.Properties.Resources.Map_Marker_Marker_Outside_Azure_icon;
            this.picBoxLogo.Location = new System.Drawing.Point(315, 30);
            this.picBoxLogo.Size = new System.Drawing.Size(73, 69);
            // 
            // barOperation
            // 
            this.barOperation.Size = new System.Drawing.Size(390, 30);
            // 
            // btnNew
            // 
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
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
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(308, 94);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(77, 20);
            this.labelX1.TabIndex = 26;
            this.labelX1.Text = "تفاصيل المنطقة";
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
            this.lblUseraName.Location = new System.Drawing.Point(308, 48);
            this.lblUseraName.Name = "lblUseraName";
            this.lblUseraName.Size = new System.Drawing.Size(60, 20);
            this.lblUseraName.TabIndex = 27;
            this.lblUseraName.Text = "اسم المنطقة";
            // 
            // txtDetails
            // 
            // 
            // 
            // 
            this.txtDetails.Border.Class = "TextBoxBorder";
            this.txtDetails.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDetails.Location = new System.Drawing.Point(9, 79);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(288, 45);
            this.txtDetails.TabIndex = 24;
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.Border.Class = "TextBoxBorder";
            this.txtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtName.Location = new System.Drawing.Point(9, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(288, 20);
            this.txtName.TabIndex = 25;
            // 
            // frmRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 249);
            this.Name = "frmRegion";
            this.Text = "frmRegion";
            this.Load += new System.EventHandler(this.frmRegion_Load);
            this.gpnlBody.ResumeLayout(false);
            this.gpnlBody.PerformLayout();
            this.ribnpnlHeader.ResumeLayout(false);
            this.ribnpnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._errorfrmProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX lblUseraName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDetails;
        private DevComponents.DotNetBar.Controls.TextBoxX txtName;
    }
}