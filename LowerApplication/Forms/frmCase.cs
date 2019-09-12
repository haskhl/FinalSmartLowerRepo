using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;
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
    public partial class frmCase : frmMaster
    {
        Case caseobj;
        List<Case> caseList;
        List<Court> corts;
        List<Chamber> chmbers;
        List<Office> offs;
        List<DocumentationOffice> docoffices;

        List<Delegator> delegators;
        List<CompetitorLower> clowers;
        List<CaseSession> sessions;
        
        State CurrentState = State.Insert;

        public frmCase()
        {
            InitializeComponent();
        }

        void ResetForm()
        {
            txtCaseDetails.ResetText();
            txtCaseSubject.ResetText();

            txtadministrativestring.ResetText();
            iiadministrativeNumber.ResetText();

            txtfinestring.ResetText();
            iifinenumber.ResetText();
            txtInvestigationString.ResetText();
            iiInvestigationNumer.ResetText();
            txtImprisonString.ResetText();
            iiImprisonmentNumber.ResetText();
            txtPartialString.ResetText();
            iiPartialNumber.ResetText();

            txtTotalString.ResetText();
            iiTotalNumber.ResetText();
            iiDelegationNumber.ResetText();
            txtDelegationString.ResetText();
            txtDelegationLetter.ResetText();
            txtDelegatorName.ResetText();
            txtDelegatorAddress.ResetText();
            txtDelegatorPhone.ResetText();
            txtDelegatorSSN.ResetText();
            txtDelegatorMobile.ResetText();

            txtCase_Del_Notes.ResetText();
            txtDelegatorDetails.ResetText();
            txtCLowerName.ResetText();
            txtCLowerPhone.ResetText();
            txtCLowerOffice.ResetText();
            txtCLowerOtherDetails.ResetText();
            diPresentAmount.ResetText();
            diRetensionAmount.ResetText();
            diInstallsAmount.ResetText();

            txtRollNumber.ResetText();
            txtSessionDetails.ResetText();
            txtSessionOrders.ResetText();
            txtSessionNotes.ResetText();

            dgvSessions.DataSource = null;
            dgvCLowers.DataSource = null;
            dgvDelegators.DataSource = null;
        }

        void PopulateCases()
        {
            ResetForm();
            DataTable dt = CaseDB.GetCasesADO();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int index = dgvCases.Rows.Add();
                    dgvCases.Rows[i].Cells["colCaseID"].Value = dt.Rows[i]["CaseID"];
                    dgvCases.Rows[i].Cells["colCaseDate"].Value = dt.Rows[i]["CaseRecevingDate"];
                    dgvCases.Rows[i].Cells["colCaseSubject"].Value = dt.Rows[i]["CaseSubject"];
                }
            }
        }
        void FillObject()
        {
            try
            {
               caseobj = new Case();
                if(iiadministrativeNumber.Value > 0)
                    caseobj.AdminNumber = iiadministrativeNumber.Value.ToString();
                if(!string.IsNullOrWhiteSpace(txtadministrativestring.Text))
                    caseobj.AdminString = txtadministrativestring.Text;

                if(iifinenumber.Value > 0)
                    caseobj.FineNumber = iifinenumber.Value.ToString();
                if(!string.IsNullOrWhiteSpace(txtfinestring.Text))
                    caseobj.FineString = txtfinestring.Text;

                if(iiInvestigationNumer.Value > 0)
                    caseobj.InvestigationNumber = iiInvestigationNumer.Value.ToString();
                if(!string.IsNullOrWhiteSpace(txtInvestigationString.Text))
                    caseobj.InvestigationString = txtInvestigationString.Text;

                if(iiImprisonmentNumber.Value > 0)
                    caseobj.ImprisonmentNumber = iiImprisonmentNumber.Value.ToString();
                if(!string.IsNullOrWhiteSpace(txtImprisonString.Text))
                    caseobj.ImprisonmentString = txtImprisonString.Text;

                if(iiPartialNumber.Value > 0)
                    caseobj.PartialNumber = iiPartialNumber.Value.ToString();
                if(!string.IsNullOrWhiteSpace(txtPartialString.Text))
                    caseobj.PartialString = txtPartialString.Text;

                if(iiTotalNumber.Value > 0)
                    caseobj.TotalNumber = iiTotalNumber.Value.ToString();
                if(!string.IsNullOrWhiteSpace(txtTotalString.Text))
                    caseobj.TotalString = txtTotalString.Text;

                caseobj.CaseRecevingDate = dtRecievingDate.Value;
                caseobj.CourtID = Convert.ToInt32(cbxCourt.SelectedValue.ToString());
                caseobj.ChamberID = Convert.ToInt32(cbxChamber.SelectedValue.ToString());
                caseobj.CaseSubject = txtCaseSubject.Text;
                caseobj.CaseDetails = txtCaseDetails.Text;

                caseobj.DelegationNumber = iiDelegationNumber.Value.ToString();
                caseobj.DelegationLetter = txtDelegationLetter.Text;
                caseobj.DelegationString = txtDelegationString.Text;
                caseobj.DocumentationOffice = cbxDocumentationOffice.Text;

                caseobj.TotalPresentAmount = Convert.ToDecimal(diPresentAmount.Value.ToString());
                caseobj.TotalRetensionAmount = Convert.ToDecimal(diRetensionAmount.Value.ToString());
                caseobj.TotalInstallsAmount = Convert.ToDecimal(diInstallsAmount.Value.ToString());
                caseobj.TotalCost = Convert.ToDecimal(diTotalAmount.Value.ToString());
            }
            catch { MessageBoxEx.Show("خطأ في عملية تهيئة بيانات القضية رجاء مراجعة البيانات المدخلة"); }
        }

        void FillCases()
        {
            caseList = new List<Case>();
            caseList = CaseDB.GetCases();
        }
        void FillCourts()
        {
            corts = new List<Court>();
            corts = CourtDB.GetAllCourts();
            try
            {
                if (corts != null && corts.Count > 0)
                {
                    cbxCourt.DisplayMember = "CourtName";
                    cbxCourt.ValueMember = "CourtID";
                    cbxCourt.DataSource = corts;
                }
                else
                    cbxCourt.WatermarkText = "لا يوجد محاكم مسجلة بالنظام";
            }
            catch { }

        }
        void FillChambers()
        {
            chmbers = new List<Chamber>();
            chmbers = ChamberDB.GetAllChambers();
        }
        void FillOffices()
        {
            offs = new List<Office>();
            offs = MiscDB.GetAllOffices();

        }
        void FillDocOffices()
        {
            docoffices = new List<DocumentationOffice>();
            docoffices = MiscDB.GetAllDocOffices();
            try
            {
                if (docoffices != null && docoffices.Count > 0)
                {
                    cbxDocumentationOffice.DisplayMember = "Name";
                    cbxDocumentationOffice.ValueMember = "ID";
                    cbxDocumentationOffice.DataSource = docoffices;
                }
                else
                    cbxDocumentationOffice.WatermarkText = "لا يوجد مكاتب توثيق لعرضها";
            }
            catch { }
        }
        private void frmCase_Load(object sender, EventArgs e)
        {
            FillCases();
            FillCourts();
            FillChambers();
            FillOffices();
            FillDocOffices();
            PopulateCases();

            //tpGeneralCaseData.Focus();
            //tpGeneralCaseData.Select();
            tcCaseDetails.SelectedPanel = tpGeneralCaseData;
        }

        void Save()
        {
            if (caseobj != null)
            {
                if (CurrentState == State.Insert)
                {
                    if (CaseDB.InsertCase(caseobj,delegators,clowers,sessions) > 0)
                    {
                        MessageBoxEx.Show("تم اضافة بيانات القضية بنحاح");
                    }
                    else
                        MessageBoxEx.Show("حدث خطأ في حفظ بيانات القضية");
                }
                else if (CurrentState == State.Update)
                {
                    int res = CaseDB.UpdateCase(caseobj);
                    if (res > 0)
                        MessageBoxEx.Show("تم تعديل بيانات القضية بنحاح");
                    else
                        MessageBoxEx.Show("حدث خطأ في حفظ تعديل بيانات القضية");
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CurrentState = State.Insert;
            caseobj = new Case();

            ResetForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FillObject();
            
            Save();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBoxEx.Show("سيتم حذف بيانات هذه القضية وكل الاطراف المعنية بها", "تحذير", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    if (caseobj != null)
                        CaseDB.DeleteCase(caseobj);
                }
                catch (Exception ex) { MessageBoxEx.Show("غير قادر علي حذف بيانات القضية" + "\n" + ex.Message); }
            }
        }
        List<Chamber> GetChambersOfCourt(int courtId)
        {
            FillChambers();

            if(chmbers != null && chmbers.Count > 0)
            {
                 List<Chamber> chamlst= new List<Chamber>();
                chamlst = chmbers.Where(a => a.CourtID == courtId).ToList();
                return chamlst;
            }
            return null;
        }
        private void cbxCourt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cbxCourt.SelectedIndex != -1)
                {
                    if(cbxCourt.DataSource != null)
                    {
                        List<Chamber> chmberlst = GetChambersOfCourt(((Court)cbxCourt.SelectedItem).CourtID);
                        if (chmberlst != null && chmberlst.Count > 0)
                        {
                            cbxChamber.DataSource = null;
                            cbxChamber.DisplayMember = "ChamberName";
                            cbxChamber.ValueMember = "ChamberID";
                            cbxChamber.DataSource = chmberlst;
                        }
                        else
                            cbxChamber.WatermarkText = "لا يوجد دوائر مسجلة في هذه المحكمة";
                    }
                }
            }
            catch { }
        }

        private void btnAddoffice_Click(object sender, EventArgs e)
        {
            try
            {
                frmOfficeData _frmOffice = new frmOfficeData();
                _frmOffice.StartPosition = FormStartPosition.CenterParent;
                _frmOffice.ShowDialog();
            }
            catch { }
        }

        private void btnAddCourt_Click(object sender, EventArgs e)
        {

        }

        private void btnAddChamber_Click(object sender, EventArgs e)
        {

        }

        private void labelX8_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            try
            {
                r = dgvCases.SelectedRows[0];
                if (r != null)
                {
                    frmDelegator frmDelg = new frmDelegator(Convert.ToInt32(r.Cells[0].Value.ToString()));
                    frmDelg.StartPosition = FormStartPosition.CenterScreen;
                    frmDelg.Show();
                }
                else
                    new frmDelegator().ShowDialog();
            }
            catch { new frmDelegator().ShowDialog(); }
            

        }

        private void cbxChamber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelX11_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            try
            {
                r = dgvCases.SelectedRows[0];
                if (r != null)
                {
                    new frmAccounting(Convert.ToInt32(r.Cells[0].Value.ToString())).ShowDialog();
                }
                else
                    new frmAccounting().ShowDialog();
            }
            catch { new frmAccounting().ShowDialog(); }
        }

        private void labelX9_Click(object sender, EventArgs e)
        {

            try
            {
                frmDefendLowers _frmCourt = new frmDefendLowers();
                _frmCourt.StartPosition = FormStartPosition.CenterParent;
                _frmCourt.ShowDialog();
            }
            catch { }
            //DataGridViewRow r = new DataGridViewRow();
            //try
            //{
            //    r = dgvCases.SelectedRows[0];
            //    if (r != null)
            //    {
            //        new (Convert.ToInt32(r.Cells[0].Value.ToString())).ShowDialog();
            //    }
            //    else
            //        new frmAccounting().ShowDialog();
            //}
            //catch { new frmAccounting().ShowDialog(); }
        }

        private void dgvCases_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow r = null;
            try
            {
                r = dgvCases.SelectedRows[0];
            }
            catch
            {
                if(dgvCases.Rows.Count > 0)
                    r = dgvCases.Rows[0];
            }

            if(r != null)
            {
                try
                {
                    //ResetForm();
                    //txtCaseNumber.Text = r.Cells[1].Value.ToString();
                    //txtDelegationNumber.Text = r.Cells[2].Value.ToString();

                    //dtRecievingDate.Text = r.Cells[3].Value.ToString();
                    //dtRecievingDate.Value = Convert.ToDateTime(r.Cells[3].Value.ToString());

                    //txtCaseSubject.Text = r.Cells[4].Value.ToString();
                    //txtCaseDetails.Text = r.Cells[5].Value.ToString();

                    //cbxChamber.SelectedText = r.Cells[12].Value.ToString();
                    //cbxCourt.SelectedText = r.Cells[11].Value.ToString();
                    //cbxOffice.SelectedText = r.Cells[13].Value.ToString();
                    ////.Text = r.Cells["DelegationNumber"].ToString();
                }
                catch { }
            }

        }

        private void dgvCases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelX10_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            try
            {
                r = dgvCases.SelectedRows[0];
                if (r != null)
                {
                    new frmSessions(Convert.ToInt32(r.Cells[0].Value.ToString())).ShowDialog();
                }
                else
                    new frmSessions().ShowDialog();
            }
            catch { new frmSessions().ShowDialog(); }
            
        }

        private void dgvCases_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            return;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void cbxSearchColumn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchKeyword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddDocumentationOffice_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCourt_Click_1(object sender, EventArgs e)
        {
            try
            {
                frmCourt _frmCourt = new frmCourt();
                _frmCourt.StartPosition = FormStartPosition.CenterParent;
                _frmCourt.ShowDialog();
            }
            catch { }
        }

        private void btnAddChamber_Click_1(object sender, EventArgs e)
        {
            try
            {
                frmChamber _frmChamber = new frmChamber();
                _frmChamber.StartPosition = FormStartPosition.CenterParent;
                _frmChamber.ShowDialog();
            }
            catch { }
        }

        private void btnAddCaseMainData_Click(object sender, EventArgs e)
        {

        }

        private void dgvSessions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelX28_Click(object sender, EventArgs e)
        {

        }

        private void dgvCases_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int caseId = 0;
            if (dgvCases.SelectedRows.Count > 0)
                caseId = Convert.ToInt32(dgvCases.SelectedRows[0].Cells["colCaseID"].Value.ToString());
            if(caseId > 0)
            {
                Case cs = CaseDB.GetCasesbyNumber(caseId).FirstOrDefault();
                if(cs != null)
                {
                    if (cs.CaseRecevingDate != null)
                        dtRecievingDate.Value = cs.CaseRecevingDate;
                    else
                        dtRecievingDate.Value = DateTime.Now;

                    txtCaseSubject.Text = cs.CaseSubject;
                    txtCaseDetails.Text = cs.CaseDetails;

                    iiadministrativeNumber.Value = Convert.ToInt32(cs.AdminNumber);
                    txtadministrativestring.Text = cs.AdminString;

                    iifinenumber.Value = Convert.ToInt32(cs.FineNumber);
                    txtfinestring.Text = cs.FineString;

                    iiImprisonmentNumber.Value = Convert.ToInt32(cs.ImprisonmentNumber);
                    txtImprisonString.Text = cs.ImprisonmentString;

                    iiInvestigationNumer.Value = Convert.ToInt32(cs.InvestigationNumber);
                    txtInvestigationString.Text = cs.InvestigationString;

                    iiPartialNumber.Value = Convert.ToInt32(cs.PartialNumber);
                    txtPartialString.Text = cs.PartialString;

                    iiTotalNumber.Value = Convert.ToInt32(cs.TotalNumber);
                    txtTotalString.Text = cs.TotalString;

                    iiDelegationNumber.Value = Convert.ToInt32(cs.DelegationNumber);
                    txtDelegationString.Text = cs.DelegationString;
                    txtDelegationLetter.Text = cs.DelegationLetter;
                    cbxDocumentationOffice.Text = cs.DocumentationOffice;

                    diInstallsAmount.Value =Convert.ToDouble(cs.TotalInstallsAmount);
                    diPresentAmount.Value = Convert.ToDouble(cs.TotalPresentAmount);
                    diRetensionAmount.Value = Convert.ToDouble(cs.TotalRetensionAmount);
                    //diTotalAmount.Value = Convert.ToDouble(cs.TotalCost);

                    DataTable caseDelegators = DelegatorDB.GetDelegatorByCaseId(cs.CaseID);
                    if(caseDelegators != null && caseDelegators.Rows.Count > 0)
                    {
                        for (int i = 0; i < caseDelegators.Rows.Count; i++)
                        {
                            int index = dgvDelegators.Rows.Add();
                            dgvDelegators.Rows[index].Cells["colDelegatorName"].Value = caseDelegators.Rows[i]["DelName"].ToString();
                            dgvDelegators.Rows[index].Cells["colDelegatorAddress"].Value = caseDelegators.Rows[i]["DelAddress"].ToString();
                            dgvDelegators.Rows[index].Cells["colDelegatorSSN"].Value = caseDelegators.Rows[i]["DelSSN"].ToString();
                            dgvDelegators.Rows[index].Cells["colDelegatorPhone"].Value = caseDelegators.Rows[i]["DelPhone"].ToString();
                            dgvDelegators.Rows[index].Cells["colDelegatorMobile"].Value = caseDelegators.Rows[i]["DelMobile"].ToString();
                            dgvDelegators.Rows[index].Cells["colDelegatorDetails"].Value = caseDelegators.Rows[i]["DelDetails"].ToString();
                        }
                    }


                    DataTable clowers = MiscDB.GetCLowerByCaseId(cs.CaseID);
                    if (clowers != null && clowers.Rows.Count > 0)
                    {
                        for (int i = 0; i < clowers.Rows.Count; i++)
                        {
                            int index = dgvCLowers.Rows.Add();
                            dgvCLowers.Rows[index].Cells["colClowerName"].Value = caseDelegators.Rows[i]["CLowerName"].ToString();
                            dgvCLowers.Rows[index].Cells["colClowerPhone"].Value = caseDelegators.Rows[i]["CLowerPhone"].ToString();
                            dgvCLowers.Rows[index].Cells["colClowerOffice"].Value = caseDelegators.Rows[i]["CLowerOffice"].ToString();
                            dgvCLowers.Rows[index].Cells["colClowerDetails"].Value = caseDelegators.Rows[i]["CLowerDetails"].ToString();
                        }
                    }

                    List<CaseSession> caseSessions = new List<CaseSession>();
                    caseSessions = SessionsDB.GetSessionsByCaseID(cs.CaseID);
                    if(caseSessions != null && caseSessions.Count > 0)
                    {
                        foreach (CaseSession css in caseSessions)
                        {
                            int index = dgvSessions.Rows.Add();
                            dgvSessions.Rows[index].Cells["colSessionDate"].Value = css.SessionDate;
                            dgvSessions.Rows[index].Cells["colSessionRollNo"].Value = css.RollNumber;
                            dgvSessions.Rows[index].Cells["colSessionDetails"].Value = css.SessionDetails;
                            dgvSessions.Rows[index].Cells["colSessionDecisions"].Value = css.SessionCommandsOrders;
                            dgvSessions.Rows[index].Cells["colSessionNotes"].Value = css.SessionNotes;
                        }
                    }
                    

                }
            }
         }

        private void btnAddCourt_Click_2(object sender, EventArgs e)
        {
            try
            {
                frmCourt _frmcourt = new frmCourt();
                _frmcourt.StartPosition = FormStartPosition.CenterParent;
                _frmcourt.ShowDialog();
                FillCourts();
            }
            catch { }
        }

        private void btnAddChamber_Click_2(object sender, EventArgs e)
        {
            try
            {
                frmChamber _frmchamber = new frmChamber();
                _frmchamber.StartPosition = FormStartPosition.CenterParent;
                _frmchamber.ShowDialog();
                //FillCourts();
                if (cbxCourt.DataSource != null)
                {
                    List<Chamber> chmberlst = GetChambersOfCourt(((Court)cbxCourt.SelectedItem).CourtID);
                    if (chmberlst != null && chmberlst.Count > 0)
                    {
                        cbxChamber.DataSource = null;
                        cbxChamber.DisplayMember = "ChamberName";
                        cbxChamber.ValueMember = "ChamberID";
                        cbxChamber.DataSource = chmberlst;
                    }
                    else
                        cbxChamber.WatermarkText = "لا يوجد دوائر مسجلة في هذه المحكمة";
                }
            }
            catch { }
        }

        private void cbxCourt_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnAddDocumentationOffice_Click_1(object sender, EventArgs e)
        {
            try
            {
                frmDocOffice _frmDocOffice = new frmDocOffice();
                _frmDocOffice.StartPosition = FormStartPosition.CenterParent;
                _frmDocOffice.ShowDialog();
                FillDocOffices();
            }
            catch { }
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

        private void btnAddDelegator_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtDelegatorName.Text) && !string.IsNullOrWhiteSpace(txtDelegatorSSN.Text))
            {
                if (this.CurrentState == State.Insert)
                {
                    Delegator _delegator = new Delegator();
                    //Delegator_Case _del_case = new Delegator_Case();
                    FillDelegatorObject(_delegator);
                    AddtoDelegatorsGrid(_delegator);
                }
            }
        }
        void AddtoDelegatorsGrid(Delegator _delegator)
        {
            int ind = dgvDelegators.Rows.Add();
            dgvDelegators.Rows[ind].Cells["colDelegatorName"].Value = _delegator.DelName;
            dgvDelegators.Rows[ind].Cells["colDelegatorAddress"].Value = _delegator.DelAddress;
            dgvDelegators.Rows[ind].Cells["colDelegatorSSN"].Value = _delegator.DelSSN;
            dgvDelegators.Rows[ind].Cells["colDelegatorPhone"].Value = _delegator.DelPhone;
            dgvDelegators.Rows[ind].Cells["colDelegatorMobile"].Value = _delegator.DelMobile;
            dgvDelegators.Rows[ind].Cells["colDelegatorDetails"].Value = _delegator.DelDetails;
        }
        void FillDelegatorObject(Delegator _delegator)
        {
            _delegator.DelName = txtDelegatorName.Text;
            _delegator.DelSSN = txtDelegatorSSN.Text;
            _delegator.DelPhone = txtDelegatorPhone.Text;
            _delegator.DelMobile = txtDelegatorMobile.Text;
            _delegator.DelAddress = txtDelegatorAddress.Text;
            _delegator.DelDetails = txtDelegatorDetails.Text;
        }
        private void buttonX1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCLower_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCLowerName.Text))
            {
                if (this.CurrentState == State.Insert)
                {
                    CompetitorLower _clower = new CompetitorLower();
                    CLowers_Case _cl_case = new CLowers_Case();

                    _clower.CLowerName = txtCLowerName.Text;
                    _clower.CLowerOffice = txtCLowerOffice.Text;
                    _clower.CLowerDetails = txtCLowerOtherDetails.Text;
                    _clower.CLowerPhone = txtCLowerPhone.Text;
                    

                    if (_clower != null)
                    {
                        int ind = dgvCLowers.Rows.Add();
                        dgvCLowers.Rows[ind].Cells["colClowerName"].Value = _clower.CLowerName;
                        dgvCLowers.Rows[ind].Cells["colClowerPhone"].Value = _clower.CLowerPhone;
                        dgvCLowers.Rows[ind].Cells["colClowerOffice"].Value = _clower.CLowerOffice;
                        dgvCLowers.Rows[ind].Cells["colClowerDetails"].Value = _clower.CLowerDetails;

                        //int insertedDelId = MiscDB.AddCLower(_clower);
                        //if (insertedDelId > 0)
                        //{
                        //    _clower.CLowerID = insertedDelId;
                        //    MessageBoxEx.Show("تم اضافة محامي الخصم بنجاح");
                        //}
                        //else
                        //    MessageBoxEx.Show("حدث خطأ أثناء اضافة محامي الخصم  برجاء التاكد من المدخلات");
                    }
                    //_cl_case.CLowerID = _clower.CLowerID;
                    //_cl_case.CaseID = caseobj.CaseID;

                    //if (_cl_case != null)
                    //{
                    //    int insertedDelId = MiscDB.AddCLower_Case(_cl_case);
                    //    if (insertedDelId > 0)
                    //    {
                    //        MessageBoxEx.Show("تم ربط محامي الخصم بالقضية بنجاح");
                    //    }
                    //    else
                    //        MessageBoxEx.Show("حدث خطأ أثناء ربط محامي الخصم بالقضية  برجاء التاكد من المدخلات");
                    //}

                  
                }
            }
        }

        private void btnAddSession_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSessionOrders.Text) && !string.IsNullOrWhiteSpace(dtSessionDate.Value.ToShortDateString()))
            {
                if (this.CurrentState == State.Insert)
                {
                    CaseSession _session = new CaseSession();

                    _session.SessionDate = dtSessionDate.Value;
                    _session.SessionCommandsOrders = txtSessionOrders.Text;
                    _session.SessionDetails = txtSessionDetails.Text;
                    _session.SessionNotes = txtSessionNotes.Text;

                    if (_session != null && caseobj != null)
                    {
                        int ind = dgvSessions.Rows.Add();
                        dgvSessions.Rows[ind].Cells["colSessionDate"].Value = _session.SessionDate.ToShortDateString();
                        dgvSessions.Rows[ind].Cells["colSessionRollNo"].Value = _session.RollNumber;
                        dgvSessions.Rows[ind].Cells["colSessionDetails"].Value = _session.SessionDetails;
                        dgvSessions.Rows[ind].Cells["colSessionDecisions"].Value = _session.SessionCommandsOrders;
                        dgvSessions.Rows[ind].Cells["colSessionNotes"].Value = _session.SessionNotes;

                        //_session.CaseID = caseobj.CaseID;

                        //int insertedDelId = SessionsDB.InsertSeesion(_session);
                        //if (insertedDelId > 0)
                        //{
                        //    _session.SessionID = insertedDelId;
                        //    MessageBoxEx.Show("تم اضافة تفاصيل الجلسة بنجاح");
                        //}
                        //else
                        //    MessageBoxEx.Show("حدث خطأ أثناء اضافة تفاصيل الجلسة،  برجاء التاكد من المدخلات");
                    }

                   
                }
            }
        }

        private void dgvSessions_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvSessions != null && dgvSessions.Rows.Count > 0)
            {
                txtRollNumber.Text = dgvSessions.SelectedRows[0].Cells["colSessionRollNo"].Value.ToString();
                dtSessionDate.Value = Convert.ToDateTime(dgvSessions.SelectedRows[0].Cells["colSessionRollNo"].Value.ToString());
                txtSessionDetails.Text = dgvSessions.SelectedRows[0].Cells["colSessionDetails"].Value.ToString();
                txtSessionNotes.Text = dgvSessions.SelectedRows[0].Cells["colSessionNotes"].Value.ToString();
                txtSessionOrders.Text = dgvSessions.SelectedRows[0].Cells["colSessionDecisions"].Value.ToString();
            }
        }

        private void dgvSessions_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            return;
        }

        private void dgvCLowers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCLowers != null && dgvCLowers.Rows.Count > 0)
            {
                txtCLowerName.Text = dgvCLowers.SelectedRows[0].Cells["colClowerName"].Value.ToString();
                txtCLowerPhone.Text = dgvCLowers.SelectedRows[0].Cells["colClowerPhone"].Value.ToString();
                txtCLowerOffice.Text = dgvCLowers.SelectedRows[0].Cells["colClowerOffice"].Value.ToString();
                txtCLowerOtherDetails.Text = dgvCLowers.SelectedRows[0].Cells["colClowerDetails"].Value.ToString();
            }
        }

        private void dgvCLowers_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            return;
        }

        private void dgvDelegators_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            return;
        }




        private void dgvDelegators_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDelegators != null && dgvDelegators.SelectedRows.Count > 0)
                {
                    txtDelegatorName.Text = dgvDelegators.SelectedRows[0].Cells["colDelegatorName"].Value.ToString();
                    txtDelegatorAddress.Text = dgvDelegators.SelectedRows[0].Cells["colDelegatorAddress"].Value.ToString();
                    txtDelegatorPhone.Text = dgvDelegators.SelectedRows[0].Cells["colDelegatorSSN"].Value.ToString();
                    txtDelegatorSSN.Text = dgvDelegators.SelectedRows[0].Cells["colDelegatorPhone"].Value.ToString();
                    txtDelegatorMobile.Text = dgvDelegators.SelectedRows[0].Cells["colDelegatorMobile"].Value.ToString();
                    txtDelegatorDetails.Text = dgvDelegators.SelectedRows[0].Cells["colDelegatorDetails"].Value.ToString();
                }
            }
            catch(Exception ex) { string s = ex.Message; }
        }
    }
}
 