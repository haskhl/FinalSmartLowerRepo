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
    public partial class frmDelegator : frmMaster
    {

        Case caseObj;
        
        public frmDelegator()
        {
            InitializeComponent();
            caseObj = new Case();
        }
        int caseid = 0;
        public frmDelegator(int caid)
        {
            InitializeComponent();
            caseid = caid;
           
        }

        private void frmDelegator_Load(object sender, EventArgs e)
        {

            List<Case> _allcases = CaseDB.GetCases();
            if(_allcases.Count > 0 )
            {
                cbxCases.ValueMember = "CaseID";
                cbxCases.DisplayMember = "CaseNumber";
                cbxCases.DataSource = _allcases;
                cbxCases.SelectedIndex = 0;
            }
            if (caseid > 0)
            {
                cbxCases.SelectedValue = caseid;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxCases_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCases.SelectedValue != null)
            {
                caseid = Convert.ToInt32(cbxCases.SelectedValue.ToString());
                DataTable dt = DelegatorDB.GetDelegatorByCaseId(caseid);
                grdDelegators.DataSource = null;
                if (dt.Rows.Count > 0)
                {
                    grdDelegators.DataSource = dt;
                    grdDelegators.Refresh();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Delegator del;
                Delegator_Case delcase;
                List<Delegator> delList = new List<Delegator>();
                List<Delegator_Case> delcaseList = new List<Delegator_Case>();
                try
                {
                    int deleted = DelegatorDB.DeleteCaseDelegators(caseid);
                }
                catch { MessageBoxEx.Show("حدث خطأ أثناء محاولة حذف الموكلين الحاليين للقضية لاضافة الموكلين الجدد"); }
                for (int i = 0; i < grdDelegators.Rows.Count; i++)
                {
                    del = new Delegator();
                    delcase = new Delegator_Case();

                    del.DelName = grdDelegators.Rows[i].Cells[0].Value.ToString();
                    del.DelSSN = grdDelegators.Rows[i].Cells[4].Value.ToString();
                    del.DelPhone = grdDelegators.Rows[i].Cells[3].Value.ToString();
                    del.DelMobile = grdDelegators.Rows[i].Cells[2].Value.ToString();
                    del.DelAddress = grdDelegators.Rows[i].Cells[1].Value.ToString();
                    del.DelDetails = grdDelegators.Rows[i].Cells[5].Value.ToString();
                    if (del != null)
                    {
                        delList.Add(del);
                        //DelegatorDB.InsertDelegator(del);
                    }
                    delcase.CaseID = caseid;
                    delcase.DelID = DelegatorDB.InsertDelegator(del);
                    delcase.Notes = grdDelegators.Rows[i].Cells[6].Value.ToString();
                    if (delcase != null)
                    {
                        delcaseList.Add(delcase);
                    }
                }
                if (delList.Count > 0 && delcaseList.Count > 0)
                {
                    try
                    {
                        if (DelegatorDB.InsertCaseDelegators(delList, delcaseList) > 0)
                            MessageBoxEx.Show("تم اضافة الموكلين للقضية بنجاح");
                        else
                            MessageBoxEx.Show("حدث خطأ أثناء اضافة الموكلين للقضية برجاء التاكد من المدخلات");
                    }
                    catch
                    {
                        MessageBoxEx.Show("حدث خطأ أثناء اضافة الموكلين للقضية برجاء التاكد من المدخلات");
                    }
                }
            }
            catch { }
        }
            
        
        
        
        private void grdDelegators_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdDelegators_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow r = null;
            try
            {
                r = grdDelegators.SelectedRows[0];
            }
            catch
            {
                if (grdDelegators.Rows.Count > 0)
                    r = grdDelegators.Rows[0];
            }

                        
            if (r != null)
                {
                    txtAddress.Text = r.Cells[1].Value.ToString();
                    txtName.Text = r.Cells[0].Value.ToString();
                    txtMobile.Text = r.Cells[2].Value.ToString();
                    txtPhone.Text = r.Cells[3].Value.ToString();
                    txtNotes.Text = r.Cells[6].Value.ToString();
                    txtOtherDetails.Text = r.Cells[5].Value.ToString();
                    txtSSN.Text = r.Cells[4].Value.ToString();
                }
            
        }

        private void RestForm()
        {
            txtAddress.Text = string.Empty;
            txtMobile.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtSSN.Text = string.Empty;
            txtName.Text = string.Empty;
            txtNotes.Text = string.Empty;
            txtOtherDetails.Text = string.Empty;

            grdDelegators.ClearSelection();

            if (cbxCases.DataSource != null)
                cbxCases.SelectedIndex = -1;

        }
        bool addNew = false;
        private void btnNew_Click(object sender, EventArgs e)
        {
            addNew = true;
            RestForm();
        }

        private void ribnpnlHeader_Click(object sender, EventArgs e)
        {

        }

        private void gpnlBody_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (grdDelegators.DataSource == null)
            {
                //dt = new DataTable();
                dt.Columns.Add("اسم الموكل");
                dt.Columns.Add("العنوان");
                dt.Columns.Add("رقم الجوال");
                dt.Columns.Add("رقم التليفون");
                dt.Columns.Add("تفاصيل الموكل");
                dt.Columns.Add("الرقم القومي");
                dt.Columns.Add("ملاحظات");
                dt.Rows.Add();

                dt.Rows[0][0] = txtName.Text;
                dt.Rows[0][1] = txtAddress.Text;
                dt.Rows[0][2] = txtMobile.Text;
                dt.Rows[0][3] = txtPhone.Text;
                dt.Rows[0][4] = txtOtherDetails.Text;
                dt.Rows[0][5] = txtSSN.Text;
                dt.Rows[0][6] = txtNotes.Text;
                grdDelegators.DataSource = dt;
                grdDelegators.Refresh();
            }
            else
            {
                dt = (DataTable)grdDelegators.DataSource;
                int index = dt.Rows.Count;
                for (int i = 0; i < index; i++)
                {
                    if (!string.IsNullOrWhiteSpace(txtName.Text))
                    {
                        if (dt.Rows[i][0].ToString().Trim() == txtName.Text.Trim())
                        {
                            MessageBox.Show("يوجد موكل بنفس هذا الاسم مضاف لهذه القضية");
                            return;
                        }
                    }
                }
                dt.Rows.Add();

                dt.Rows[index][0] = txtName.Text;
                dt.Rows[index][1] = txtAddress.Text;
                dt.Rows[index][2] = txtMobile.Text;
                dt.Rows[index][3] = txtPhone.Text;
                dt.Rows[index][4] = txtOtherDetails.Text;
                dt.Rows[index][5] = txtSSN.Text;
                dt.Rows[index][6] = txtNotes.Text;

                grdDelegators.DataSource = dt;
                grdDelegators.Refresh();

            }
            

              


        }
    }
}
