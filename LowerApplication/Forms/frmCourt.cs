using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyStore.Classes;
using LowerApplication.DAL;
using LowerApplication.Classes;
using DevComponents.DotNetBar;

namespace LowerApplication.Forms
{
    public partial class frmCourt : frmMaster
    {
        static Court cortobj;
        State s = State.Update;
        static List<Region> reglst;

        public frmCourt()
        {
            InitializeComponent();
            cortobj = new Court();
        }
        private void frmCourt_Load(object sender, EventArgs e)
        {
            reglst = MiscDB.GetAllRegions();
            cortobj = CourtDB.GetCourt();

            if (cortobj == null)
                s = State.Insert;

            PopulateCourt();
        }

        private void PopulateCourt()
        {
            if (reglst != null && reglst.Count >0)
            {
                cbxRegion.DataSource = reglst;
                cbxRegion.ValueMember = "RegionID";
                cbxRegion.DisplayMember = "RegionName";
            }
            else
                cbxRegion.Text = "لا يوجد مناطق لعرضها";

            if (cortobj!=null)
            {
                txtName.Text = cortobj.CourtName;
                txtAddress.Text = cortobj.CourtAddress;
                txtDetails.Text = cortobj.CourtDetails;
            }
        }
        void SetCourt()
        {
            cortobj = new Court();
            cortobj.CourtName = txtName.Text;
            cortobj.CourtAddress = txtAddress.Text;
            cortobj.CourtDetails = txtDetails.Text;
            if(cbxRegion.DataSource != null)
            {
                cortobj.CourtRegionID = Convert.ToInt32(cbxRegion.SelectedValue.ToString());
            }
        }
        private void ResetForm()
        {
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtDetails.Text = string.Empty;
            cbxRegion.Text = string.Empty;
            //cbxRegion.DataSource = null;
            //cbxRegion.Text = "لا يوجد مناطق لعرضها";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(" اضافة محكمة جديدة؟", "سؤال", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
                return;
            if (res == DialogResult.Yes)
            {
                ResetForm();
                cortobj = null;
                s = State.Insert;
            }
        }

        private void ribnpnlHeader_Click(object sender, EventArgs e)
        {

        }

        private void Save()
        {
            if (s == State.Insert)
            {
                SetCourt();
                int res = CourtDB.InsertCourt(cortobj, s);
                if (res > 0)
                {
                    MessageBox.Show("تم اضافة بيانات المحكمة بنجاح");
                }
            }
            else if(s == State.Update)
            {
                int res = CourtDB.InsertCourt(cortobj, s);
                if (res > 0)
                {
                    MessageBox.Show("تم تعديل بيانات المحكمة بنجاح  ");
                }
            }
        }

 
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cortobj != null)
            {
                try
                {
                    CourtDB.DeleteCourt(cortobj);
                    MessageBoxEx.Show("Deleted");
                }
                catch { }
                ResetForm();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
