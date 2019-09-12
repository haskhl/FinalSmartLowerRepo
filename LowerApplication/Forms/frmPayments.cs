using LowerApplication.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LowerApplication.Forms
{
    public partial class frmPayments : frmMaster
    {
        public frmPayments()
        {
            InitializeComponent();
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void frmPayments_Load(object sender, EventArgs e)
        {
            ResetForm();
            GetAllCases();
        }

        void ResetForm()
        {
            lblRemInstalls.Text = "000";
            lblRemPresent.Text = "000";
            lblRemRetension.Text = "000";
            lblRemTotal.Text = "000";

            if(dgvCases.SelectedRows.Count > 0)
            {

            }
            else
            {
                diInstallsAmount.Value = 0;
                diPresentAmount.Value = 0;
                diRetensionAmount.Value = 0;
                diTotalAmount.Value = 0;
            }
           
        }

        List<Case> cases = new List<Case>();
        void GetAllCases()
        {
            try
            {
                dgvCases.DataSource = CaseDB.GetCases();
            }
            catch { MessageBox.Show("حدث خطأ أثناء تحميل القضايا"); }
        }

        private void diPresentAmount_ValueChanged(object sender, EventArgs e)
        {
            diTotalAmount.Value = diPresentAmount.Value + diRetensionAmount.Value + diInstallsAmount.Value;
        }

        private void diRetensionAmount_ValueChanged(object sender, EventArgs e)
        {
            diTotalAmount.Value = diPresentAmount.Value + diRetensionAmount.Value + diInstallsAmount.Value;

        }

        private void diInstallsAmount_ValueChanged(object sender, EventArgs e)
        {
            diTotalAmount.Value = diPresentAmount.Value + diRetensionAmount.Value + diInstallsAmount.Value;

        }

        private void ckbxPresent_CheckedChanged(object sender, EventArgs e)
        {
            diPresentAmount.Enabled = ckbxPresent.Checked;
            if (!ckbxPresent.Checked)
                diPresentAmount.Value = 0;

        }

        private void ckbxRetention_CheckedChanged(object sender, EventArgs e)
        {
            diRetensionAmount.Enabled = ckbxRetention.Checked;
            if (!ckbxRetention.Checked)
                diRetensionAmount.Value = 0;
        }

        private void ckbxInstalls_CheckedChanged(object sender, EventArgs e)
        {
            diInstallsAmount.Enabled = ckbxInstalls.Checked;
            if (!ckbxInstalls.Checked)
                diInstallsAmount.Value = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void dgvCases_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            return;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
