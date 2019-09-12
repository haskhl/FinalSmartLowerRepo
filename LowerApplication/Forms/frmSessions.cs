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
    public partial class frmSessions : frmMaster
    {
        public frmSessions()
        {
            InitializeComponent();
        }
        int caseid = 0;
        public frmSessions(int caseId)
        {
            caseid = caseId;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSessions_Load(object sender, EventArgs e)
        {
            cbxCases.DataSource = CaseDB.GetCases();
            cbxCases.DisplayMember = "caseNumber";
            cbxCases.ValueMember = "caseID";

            if (caseid > 0)
                cbxCases.SelectedValue = caseid;
        }

        private void cbxCases_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxCases.SelectedValue != null)
                {
                    caseid = Convert.ToInt32(cbxCases.SelectedValue.ToString());
                    dgvSessions.DataSource = SessionsDB.GetSessionsByCaseID(caseid);
                }
            }
            catch { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtRollNumber.Text) &&
                !string.IsNullOrWhiteSpace(dtSessionDate.Text) &&
                !string.IsNullOrWhiteSpace(txtSessionDetails.Text))
            {
                try
                {
                    CaseSession cs = new CaseSession()
                    {
                        CaseID = caseid,
                        RollNumber = Convert.ToDecimal(txtRollNumber.Text),
                        SessionDate = Convert.ToDateTime(dtSessionDate.Value.ToShortTimeString()),
                        SessionDetails = txtSessionDetails.Text,
                        SessionNotes = txtSessionNotes.Text,
                        SessionCommandsOrders = txtSessionOrders.Text
                    };
                    List<CaseSession> tempcss = ((List<CaseSession>)dgvSessions.DataSource).ToList();
                    tempcss.Add(cs);
                    dgvSessions.DataSource = null;

                    dgvSessions.DataSource = tempcss;
                    dgvSessions.Refresh();
                }
                catch { MessageBoxEx.Show("حدث خطأ أثناء اضافة بيانات الجلسة لهذه  القضية"); }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int inserted = 0;
                if(cbxCases.SelectedValue != null && dgvSessions.Rows.Count > 0)
                {
                    SessionsDB.DeleteCaseSessionsByCaseID(caseid);
                    List<CaseSession> lst = (List<CaseSession>)dgvSessions.DataSource;
                    for (int i = 0; i < lst.Count; i++)
                    {
                        inserted += SessionsDB.InsertSeesion(lst[i]);
                    }
                }
                if(inserted >0)
                    MessageBox.Show("تم حفظ بيانات الجلسات بنجاح");
                else
                    MessageBox.Show("حدث خطأ أثناء حفظ بيانات الجلسات الحالية لهذه القضية");
            }
            catch
            {
                MessageBox.Show("حدث خطأ أثناء عملية الحفظ","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ResetForm()
        {
            txtRollNumber.Text = string.Empty;
            txtSessionDetails.Text = string.Empty;
            txtSessionNotes.Text = string.Empty;
            txtSessionOrders.Text = string.Empty;
            dtSessionDate.Text = string.Empty;
            dtSessionDate.Value = DateTime.MinValue;

        }
        private void dgvSessions_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow r = null;
            try
            {
                r = dgvSessions.SelectedRows[0];
            }
            catch
            {
                if (dgvSessions.Rows.Count > 0)
                    r = dgvSessions.Rows[0];
            }

            if (r != null)
            {
                ResetForm();
                txtRollNumber.Text = r.Cells[""].Value.ToString();
                txtSessionDetails.Text = r.Cells[2].Value.ToString();
                txtSessionNotes.Text = r.Cells[3].Value.ToString();
                txtSessionOrders.Text = r.Cells[4].Value.ToString();

                dtSessionDate.Value = Convert.ToDateTime(r.Cells[3].Value.ToString());

                
            }
        }
    }
}
