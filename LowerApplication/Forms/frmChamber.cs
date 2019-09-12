using DevComponents.DotNetBar;
using LowerApplication.Classes;
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
    public partial class frmChamber: frmMaster
    {
        State s = State.Update;
        Chamber chmberobj;
        List<Court> crts;
        public frmChamber()
        {
            InitializeComponent();
        }

        private void frmChamber_Load(object sender, EventArgs e)
        {
            chmberobj = new Chamber();
            crts = new List<Court>();

            chmberobj = ChamberDB.GetChamber();
            crts = CourtDB.GetAllCourts();

            if (chmberobj == null)
                s = State.Insert;

            Populate();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ResetForm();
            s = State.Insert;
        }

        void ResetForm()
        {
            txtName.Text = string.Empty;
            txtDetails.Text = string.Empty;
            txtBoss.Text = string.Empty;
            txtAddress.Text = string.Empty;
            //cbxCourts.Text = string.Empty;
            //cbxCourts.DataSource = null;
        }

        private void Populate()
        {
            ResetForm();
            if (crts != null && crts.Count > 0)
            {
                cbxCourts.ValueMember = "CourtID";
                cbxCourts.DisplayMember = "CourtName";
                cbxCourts.DataSource = crts;
            }
            else
                cbxCourts.Text = "لا يوجد محاكم لعرضها";

            if (chmberobj != null)
            {
                txtAddress.Text = chmberobj.ChamberAdress;
                txtName.Text = chmberobj.ChamberName;
                txtBoss.Text = chmberobj.ChamberBossName;
                txtDetails.Text = chmberobj.ChamberDetails;
            }

        }
        private void SetChamber()
        {
            chmberobj = new Chamber();
            if (cbxCourts.DataSource != null && cbxCourts.SelectedIndex >= 0)
                chmberobj.CourtID = Convert.ToInt32(cbxCourts.SelectedValue.ToString());
            chmberobj.ChamberName = txtName.Text;
            chmberobj.ChamberBossName = txtBoss.Text;
            chmberobj.ChamberDetails = txtDetails.Text;
            chmberobj.ChamberAdress = txtAddress.Text;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SetChamber();
            if (chmberobj != null)
            {
                if (s == State.Insert)
                {
                    int insertedid = ChamberDB.InsertChamber(chmberobj);
                    if (insertedid > 0)
                    {
                        MessageBoxEx.Show("تم اضافة بيانات الدائرة بنحاح");
                    }
                }
                else if (s == State.Update)
                {
                    int affected = ChamberDB.UpdateChamber(chmberobj);
                    if (affected > 0)
                    {
                        MessageBoxEx.Show("تم حفظ التعديلات بنحاح");
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (chmberobj != null)
            {
                try
                {
                    DialogResult dres = MessageBoxEx.Show("سيتم حذف هذه الدائرة وكل البيانات المترتبة عليها", "تنبية", MessageBoxButtons.YesNo);
                    if (dres == DialogResult.Yes)
                    {
                        int res = ChamberDB.DeleteChamber(chmberobj);

                        if (res > 0)
                            MessageBoxEx.Show("تم حذف الدائرة بنجاح");
                        else
                            MessageBoxEx.Show("خطأ في حذف الدائرة", "خطأ", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                catch { }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
