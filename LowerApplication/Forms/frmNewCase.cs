using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;

namespace LowerApplication.Forms
{
    public partial class frmNewCase : frmMaster
    {
        public frmNewCase()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            new frmCase().ShowDialog();
        }

        private void btnAddDocumentationOffice_Click(object sender, EventArgs e)
        {
            try
            {
                frmDocOffice _frmDocOffice = new frmDocOffice();
                _frmDocOffice.StartPosition = FormStartPosition.CenterParent;
                _frmDocOffice.ShowDialog();
            }
            catch { }
        }

        private void btnAddCourt_Click(object sender, EventArgs e)
        {
            try
            {
                frmCourt _frmCourt = new frmCourt();
                _frmCourt.StartPosition = FormStartPosition.CenterParent;
                _frmCourt.ShowDialog();
            }
            catch { }
        }

        private void btnAddChamber_Click(object sender, EventArgs e)
        {
            try
            {
                frmChamber _frmChamber = new frmChamber();
                _frmChamber.StartPosition = FormStartPosition.CenterParent;
                _frmChamber.ShowDialog();
            }
            catch { }
        }

        private void frmNewCase_Load(object sender, EventArgs e)
        {
            try
            {
                cbxCourt.DisplayMember = "CourtName";
                cbxCourt.ValueMember = "CourtID";
                cbxCourt.DataSource = DAL.CourtDB.GetAllCourts();

            }
            catch { }
            try
            {
                cbxDocumentationOffice.DisplayMember = "Name";
                cbxDocumentationOffice.ValueMember = "ID";
                cbxDocumentationOffice.DataSource = DAL.MiscDB.GetAllDocOffices();

            }
            catch { }
        }

        private void cbxCourt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbxChamber.DisplayMember = "ChamberName";
                cbxChamber.ValueMember = "ChamberID";
                cbxChamber.DataSource = DAL.ChamberDB.GetAllChambersByCourtId(Convert.ToInt32(cbxCourt.SelectedValue));

            }
            catch { }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            foreach (var cntrol in this.Controls)
            {
                if(cntrol.GetType() == typeof(TextBoxX))
                {
                    ((TextBoxX)cntrol).Clear();
                }
                else if (cntrol.GetType() == typeof(ComboBoxEx))
                {
                    ((ComboBoxEx)cntrol).SelectedIndex = -1;
                }
                else if (cntrol.GetType() == typeof(IntegerInput))
                {
                    ((IntegerInput)cntrol).ResetText();
                }
                dtRecievingDate.Value = DateTime.Now;
            }
        }
    }
}
