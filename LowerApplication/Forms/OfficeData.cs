using DevComponents.DotNetBar;
using LowerApplication.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LowerApplication.Forms
{
    public partial class frmOfficeData : frmMaster
    {
        Office office;
        List<Office> officelist;
        public frmOfficeData()
        {
            InitializeComponent();
            office = new Office();
            officelist = new List<Office>();
        }

        private void frmOfficeData_Load(object sender, EventArgs e)
        {
            GetOffice();
            //populateOffice(office);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetForm()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtDetails.Clear();
            picBoxLogo.Image = null;
            picBoxLogo.Refresh();
            txtLogoURL.Clear();
        }

        private void GetOffice()
        {
            officelist = MiscDB.GetOffice();
            if(officelist.Count > 0)
            {
                populateOffice(officelist[0]);
            }
        }

        int currentOffID = 0;
        private void populateOffice(Office off)
        {
            if (off != null)
            {
                currentOffID = off.OfficeID;
                txtName.Text = off.OfficeName;
                txtAddress.Text = off.OfficeAddress;
                txtDetails.Text = off.OfficeDetails;
                var data = off.OfficeLogo;
                if (data != null)
                {
                    MemoryStream ms = new MemoryStream(data);
                    pbxLogo.Image = Image.FromStream(ms);
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //txtName.Text = string.Empty;
            ResetForm();
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (office != null)
                {

                    if (MiscDB.DeleteOfficeData(office) > 0)
                    {
                        ResetForm();

                    }
                }
            }
            catch { }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                office = new Office();
                office.OfficeName = txtName.Text;
                office.OfficeAddress = txtAddress.Text;
                office.OfficeDetails = txtDetails.Text;
                Image img = Image.FromFile(txtLogoURL.Text);
                MemoryStream ms = new MemoryStream();
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] arrimg = ms.ToArray();
                office.OfficeLogo = arrimg;
                if (MiscDB.AddOffice(office) > 0)
                {
                    MessageBoxEx.Show("تم اضافة بيانات المكتب الجديد بنجاح");
                }
                else
                {
                    MessageBoxEx.Show("خطأ أثناء اضافةبيانات المكتب");
                }
            }
            catch
            {

             
            }
            

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                ofdLogo.ShowDialog();
                txtLogoURL.Text = ofdLogo.FileName.ToString();
                pbxLogo.Image = Image.FromFile(ofdLogo.FileName);
            }
            catch { }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (officelist.Count > 0)
                {
                    for (int i = 0; i < officelist.Count - 1; i++)
                    {
                        if (currentOffID == officelist[i].OfficeID)
                        {
                            populateOffice(officelist[i + 1]);
                            currentOffID = officelist[i + 1].OfficeID;
                        }
                    }
                }
            }
            catch { }
        }

        private void btnPreviouse_Click(object sender, EventArgs e)
        {
            if (officelist.Count > 0)
            {
                for (int i = 0; i < officelist.Count - 1; i++)
                {
                    if (currentOffID == officelist[i].OfficeID)
                    {
                        populateOffice(officelist[i + 1]);
                        currentOffID = officelist[i + 1].OfficeID;
                    }
                }
            }
        }
    }
}
