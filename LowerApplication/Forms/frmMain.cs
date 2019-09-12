using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.WinForms;
using DevComponents.DotNetBar;
using EasyStore.UI.Configurations;
using DevComponents.DotNetBar.Rendering;
using LowerApplication.Forms;

namespace LowerApplication
{
    public partial class frmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        Office2007ButtonItemColorTable colorTable = new Office2007ButtonItemColorTable();
        eOffice2007ColorScheme baseColorScheme;
        Office2007ColorTable colorT = new Office2007ColorTable();
        bool colorSelected;
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void office2007StartButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnVista_Click(object sender, EventArgs e)
        {
            try
            {
                RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.VistaGlass);
                AppConfiguration.SysColor = "VistaGlass";
            }
            catch { }
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            try
            {
                RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, eOffice2007ColorScheme.Black);
                AppConfiguration.SysColor = "Black";
            }
            catch { }
        }

        private void btnSilver_Click(object sender, EventArgs e)
        {
            try
            {
                RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, eOffice2007ColorScheme.Silver);
                AppConfiguration.SysColor = "Silver";
            }
            catch { }
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            try
            {
                RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, eOffice2007ColorScheme.Blue);
                AppConfiguration.SysColor = "Blue";
            }
            catch { }
        }

        private void clrPckrCustomiz_SelectedColorChanged(object sender, EventArgs e)
        {
            try
            {
                colorSelected = true;
                RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, baseColorScheme, clrPckrCustomiz.SelectedColor);
            }
            catch { }
        }

        private void clrPckrCustomiz_ColorPreview(object sender, ColorPreviewEventArgs e)
        {
            RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, baseColorScheme, e.Color);
            AppConfiguration.SysColor = e.Color.Name;
        }

        private void clrPckrCustomiz_ExpandChange(object sender, EventArgs e)
        {
            try
            {
                if (clrPckrCustomiz.Expanded)
                {
                    colorSelected = false;
                    baseColorScheme = ((Office2007Renderer)GlobalManager.Renderer).ColorTable.InitialColorScheme;
                }
                else
                {
                    if (!colorSelected)
                    {
                        rcMain.Office2007ColorTable = baseColorScheme;
                    }
                }
            }
            catch { }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch { }
        }

        private void btnOfficeData_Click(object sender, EventArgs e)
        {
            try
            {
                frmOfficeData offdata = new frmOfficeData();
                //offdata.Parent = this;
                offdata.StartPosition = FormStartPosition.CenterParent;
                offdata.ShowDialog();
            }
            catch { }
        }

        private void btnCourts_Click(object sender, EventArgs e)
        {
            try
            {
                frmCourt crt = new frmCourt();
                //crt.Parent = this;
                crt.StartPosition = FormStartPosition.CenterParent;
                crt.ShowDialog();
            }
            catch { }
        }

        private void btnRegions_Click(object sender, EventArgs e)
        {
            try
            {
                frmRegion _frmRegion = new frmRegion();
                //_frmRegion.Parent = this;
                _frmRegion.StartPosition = FormStartPosition.CenterParent;
                _frmRegion.ShowDialog();
            }
            catch { }
        }

        private void btnChamber_Click(object sender, EventArgs e)
        {
            try
            {
                frmChamber _frmChamber = new frmChamber();
                _frmChamber.StartPosition = FormStartPosition.CenterParent;
                _frmChamber.ShowDialog();
            }
            catch { }
        }

        private void btnCase_Click(object sender, EventArgs e)
        {
            try
            {
                frmCase _frmCase = new frmCase();
                _frmCase.StartPosition = FormStartPosition.CenterParent;
                _frmCase.ShowDialog();
            }
            catch { }
        }

        private void btnDelegators_Click(object sender, EventArgs e)
        {
            try
            {
                frmDelegator _frmDelegator = new frmDelegator();
                _frmDelegator.StartPosition = FormStartPosition.CenterParent;
                _frmDelegator.ShowDialog();
            }
            catch { }
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            try
            {
                new frmPayments().ShowDialog();
            }
            catch { }
        }

        private void btnCalcs_Click(object sender, EventArgs e)
        {
            try
            {
                new frmAccounting().ShowDialog();
            }
            catch { }
        }

        private void btnAboutus_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCompetitorLowers_Click(object sender, EventArgs e)
        {
            try
            {
                frmDefendLowers _frmDefendLower = new frmDefendLowers();
                _frmDefendLower.StartPosition = FormStartPosition.CenterParent;
                _frmDefendLower.ShowDialog();
            }
            catch { }
        }

        private void btnSessions_Click(object sender, EventArgs e)
        {
            try
            {
                frmSessions _frmSessions = new frmSessions();
                _frmSessions.StartPosition = FormStartPosition.CenterParent;
                _frmSessions.ShowDialog();
            }
            catch { }
        }

        private void btnDocumentationOffice_Click(object sender, EventArgs e)
        {
            try
            {
                frmDocOffice _frmDocOffice = new frmDocOffice();
                _frmDocOffice.StartPosition = FormStartPosition.CenterParent;
                _frmDocOffice.ShowDialog();
            }
            catch { }
        }

        private void btnNewcase_Click(object sender, EventArgs e)
        {
            try
            {
                frmNewCase _frmnewCase = new frmNewCase();
                _frmnewCase.StartPosition = FormStartPosition.CenterParent;
                _frmnewCase.ShowDialog();
            }
            catch { }
        }
    }
}
