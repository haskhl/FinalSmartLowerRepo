using DevComponents.DotNetBar;
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
    public partial class frmDocOffice : frmMaster
    {
        public frmDocOffice()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtDetails.Clear();
        }

        DocumentationOffice dof = new DocumentationOffice();
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(!string.IsNullOrEmpty(txtName.Text))
                {
                    dof = new DocumentationOffice() { Name = txtName.Text, Details = txtDetails.Text };
                    int res = DAL.MiscDB.AddDocOffice(dof);
                    if (res > 0)
                        MessageBoxEx.Show("تم اضافة بيانات مكتب التوثيق بنحاح");
                    else
                        MessageBoxEx.Show("حدث خطأ في ادخال بيانات مكتب التوثيق");
                }
            }
            catch { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
