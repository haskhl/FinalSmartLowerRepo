using DevComponents.DotNetBar;
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
    public partial class frmAccounting : frmMaster
    {
        List<Case> casesList;
        Case caseObj;

        CasePayment payobj;
        List<CasePayment> payList;
        int caseid = 0;
        public frmAccounting(int caseId)
        {
            InitializeComponent();

            caseid = caseId;
            casesList = new List<Case>();
            caseObj = new Case();
            payobj = new CasePayment();
            payList = new List<CasePayment>();
        }
        public frmAccounting()
        {
            InitializeComponent();
            casesList = new List<Case>();
            caseObj = new Case();
            payobj = new CasePayment();
            payList = new List<CasePayment>();
        }


        private void doubleInput1_ValueChanged(object sender, EventArgs e)
        {
            diTotalAmount.Value = diPresentAmount.Value + diRetensionAmount.Value + diInstallsAmount.Value;
        }

        private void frmAccounting_Load(object sender, EventArgs e)
        {
            ResetForm();
            casesList = CaseDB.GetCases();

            if (casesList != null && casesList.Count > 0)
            { cbxCases.DataSource = casesList;
                cbxCases.DisplayMember = "CaseNumber";
                cbxCases.ValueMember = "CaseID";
            }
        }

        void ResetForm()
        {
            diPresentAmount.Value = 0;
            diRetensionAmount.Value = 0;
            diInstallsAmount.Value = 0;
            diTotalAmount.Value = 0;
            if (cbxCases.DataSource != null)
                cbxCases.SelectedIndex = -1;
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void cbxCases_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxCases.SelectedItem != null)
            {
                caseObj = (Case)cbxCases.SelectedItem;

                diPresentAmount.Value = (Double)caseObj.TotalPresentAmount.Value;
                diInstallsAmount.Value= (Double)caseObj.TotalInstallsAmount.Value;
                diRetensionAmount.Value = (Double)caseObj.TotalRetensionAmount.Value;
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cbxCases.SelectedItem != null)
            {
                try
                {
                    caseObj = (Case)cbxCases.SelectedItem;

                    caseObj.TotalPresentAmount = Convert.ToDecimal(diPresentAmount.Value.ToString());
                    caseObj.TotalInstallsAmount = Convert.ToDecimal(diInstallsAmount.Value.ToString());
                    caseObj.TotalRetensionAmount = Convert.ToDecimal(diRetensionAmount.Value.ToString());
                    if (CaseDB.UpdateCase(caseObj) > 0)
                        MessageBoxEx.Show("تم تعديل حسابات القضية بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBoxEx.Show("حدثت مشكلة أثناء حففظ التعديلات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(Exception ex)
                {
                    MessageBoxEx.Show("حدثت مشكلة أثناء حففظ التعديلات", "خطأ" +Environment.NewLine + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }   
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
