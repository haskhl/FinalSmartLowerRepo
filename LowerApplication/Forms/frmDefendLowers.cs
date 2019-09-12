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
    public partial class frmDefendLowers : frmMaster
    {
        public frmDefendLowers()
        {
            InitializeComponent();
        }

        private void grdCLowers_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            return;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
