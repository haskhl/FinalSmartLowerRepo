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
    public partial class frmRegion : frmMaster
    {

        static Region region;
        State s = State.Update;
        public frmRegion()
        {
            InitializeComponent();
        }

        private void frmRegion_Load(object sender, EventArgs e)
        {
            region = new Region();
            GetfirstRegion();
            if (region == null)
                s = State.Insert;
            else
                Populate();

        }

        private void gpnlBody_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(" اضافة منطقة جديدة؟", "سؤال", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
                return;

            if (res == DialogResult.Yes)
            {
                RestForm();
                region = null;
                s = State.Insert;
            }

        }
        void RestForm()
        {
            txtDetails.Text = string.Empty;
            txtName.Text = string.Empty;
        }
        
        void GetfirstRegion()
        {
            region = MiscDB.GetRegion();
        }
        void Populate()
        {
            RestForm();
            if (region != null)
            {
                txtName.Text = region.RegionName;
                txtDetails.Text = region.RegionDetails;
            }
        }
        void SetRegion()
        {
            region = new Region();
            region.RegionName = txtName.Text;
            region.RegionDetails = txtDetails.Text;
        }
        void Save()
        {
            SetRegion();
            //if(s == State.Insert)
            try
            {
                MiscDB.AddRegion(region);
                MessageBoxEx.Show("تم حفظ البيانات بنجاح");
            }
            catch { MessageBoxEx.Show("حدث خطأ أثناء حفظ البيانات"); }
            //if (s == State.Update)
            //    MiscDB.UpdateRegion(region);

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (region == null)
                return;
            DialogResult res = MessageBox.Show(" حذف المنطقة سيحذف كل المحاكم والدوائر المسجلة بها \n هل تريد حذف المنطقة ؟", "تنبية", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
                return;

            if (res == DialogResult.Yes)
            {
                MiscDB.DeleteRegion(region);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
