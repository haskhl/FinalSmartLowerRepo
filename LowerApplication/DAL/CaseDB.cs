using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace LowerApplication.DAL
{
    public class CaseDB
    {
        public static int InsertCase(Case ca, List<Delegator> ds, List<CompetitorLower> cls, List<CaseSession> css)
        {
            using (var cont = new SmartLowerEntities())
            {
                try
                {
                    int currentCaseid = -1;
                    int currentCLowerid = -1;
                    int currentSessionid = -1;
                    int currentDelegatorid = -1;

                    if (ca == null)
                        return -1;
                    cont.Cases.Add(ca);
                    cont.SaveChanges();
                    currentCaseid = ca.CaseID;
                    //Insert Delegators into DB
                    if (ds != null && ds.Count > 0)
                    {
                        foreach (Delegator d in ds)
                        {
                            cont.Delegators.Add(d);
                            cont.SaveChanges();
                            currentDelegatorid = d.DelID;
                            cont.Delegator_Case.Add(new Delegator_Case() { CaseID = currentCaseid, DelID = currentDelegatorid });
                        }
                    }

                    //Insert CLowers into DB
                    if (cls != null && cls.Count > 0)
                    {
                        foreach (CompetitorLower cl in cls)
                        {
                            cont.CompetitorLowers.Add(cl);
                            cont.SaveChanges();
                            currentCLowerid = cl.CLowerID;
                            cont.CLowers_Case.Add(new CLowers_Case() {CaseID = currentCaseid,  });
                        }
                    }

                    //Insert Sessions into DB
                    if (css != null && css.Count > 0)
                    {
                        foreach (CaseSession cs in css)
                        {
                            cs.CaseID = currentCaseid;

                            cont.CaseSessions.Add(cs);
                            cont.SaveChanges();
                            currentSessionid = cs.SessionID;
                        }
                    }
                    return ca.CaseID;
                }
                catch { return -1; }
            }
        }

        public static int UpdateCase(Case c)
        {
            using (var cont = new SmartLowerEntities())
            {
                try
                {
                    if (c == null)
                        return -1;

                    Case ca = cont.Cases.Where(cas => cas.CaseID == c.CaseID).FirstOrDefault();

                    ca.AdminNumber = c.AdminNumber;
                    ca.AdminString = c.AdminString;
                    ca.FineNumber = c.FineNumber;
                    ca.FineString = c.FineString;

                    ca.InvestigationNumber = c.InvestigationNumber;
                    ca.InvestigationString = c.InvestigationString;
                    ca.ImprisonmentNumber = c.ImprisonmentNumber;
                    ca.ImprisonmentString = c.ImprisonmentString;

                    ca.PartialNumber = c.PartialNumber;
                    ca.PartialString = c.PartialString;
                    ca.TotalNumber = c.TotalNumber;
                    ca.TotalString = c.TotalString;
                    


                    ca.CaseRecevingDate = c.CaseRecevingDate;
                    ca.CaseDetails = c.CaseDetails;
                    ca.CaseSubject = c.CaseSubject;
                    ca.ChamberID = c.ChamberID;
                    ca.CourtID = c.CourtID;
                    
                    ca.DelegationNumber = c.DelegationNumber;
                    ca.DelegationLetter = c.DelegationLetter;
                    ca.DocumentationOffice = c.DocumentationOffice;

                    ca.OfficeID = c.OfficeID;
                    ca.TotalPresentAmount = c.TotalPresentAmount >0 ? c.TotalPresentAmount : 0;
                    ca.TotalRetensionAmount = c.TotalRetensionAmount >0 ? c.TotalRetensionAmount : 0;
                    ca.TotalInstallsAmount = c.TotalInstallsAmount >0 ? c.TotalInstallsAmount : 0;
                    ca.ResponsibleLower = c.ResponsibleLower;

                    return cont.SaveChanges();
                }
                catch { return -1; }
            }
        }
        public static int DeleteCase(Case c)
        {
            using (var cont = new SmartLowerEntities())
            {
                try
                {
                    if (c == null)
                        return -1;

                    Case ca = cont.Cases.Where(cas => cas.CaseID == c.CaseID).FirstOrDefault();
                    cont.Cases.Remove(ca);
                    return cont.SaveChanges();
                }
                catch { return -1; }
            }
        }

        public static Case GetCase()
        {
            using (var cont = new SmartLowerEntities())
            {
                try
                {
                    return cont.Cases.FirstOrDefault();
                }
                catch { return null; }
            }
        }

        public static List<Case> GetCases()
        {
            using (var cont = new SmartLowerEntities())
            {
                try
                {
                    List<Case> clst = cont.Cases.ToList();

                            //{
                            //    CaseID = c.CaseID,
                            //    CaseNumber = c.CaseNumber,
                            //    CaseDetails = c.CaseDetails,
                            //    CaseRecevingDate =c.CaseRecevingDate,
                            //    CaseSubject = c.CaseSubject,
                            //    TotalCost = c.TotalCost,
                            //    TotalInstallsAmount = c.TotalInstallsAmount,
                            //    TotalPresentAmount= c.TotalPresentAmount,
                            //    TotalRetensionAmount = c.TotalRetensionAmount,
                            //    DelegationNumber = c.DelegationNumber
                            //}).ToList();
                    return clst;
                }
                catch(Exception e){ return null; }
            }
        }

        public static DataTable GetCasesADO()
        {
            SqlConnection conn = Connection.GetConnection();
            string query = @"select CaseID,CaseRecevingDate,CaseSubject from [Case]";
            //string query = @"select c.[CaseID] as'كود القضية',c.[CaseNumber] as 'رقم القضية',c.[DelegationNumber] as 'رقم التوكيل',
            //                c.[CaseRecevingDate] as 'تاريخ الورود',c.[CaseSubject] as 'موضوع القضية',
            //                c.[CaseDetails] as 'تفاصيل القضية',c.[TotalPresentAmount] as 'اجمالي المقدم',
            //                c.[TotalInstallsAmount] as 'اجمالي الاقساط',c.[TotalRetensionAmount] as 'اجمالي المؤجل',
            //                c.[TotalCost] as 'الإجمالي',c.[ResponsibleLower] as 'المحامي المسئول', cr.CourtName as 'المحكمة',
            //                ch.ChamberName  as 'الدائرة', o.OfficeName as 'المكتب'
            //                from [dbo].[Case] as c, [dbo].[Court] as cr, [dbo].[Chamber] as ch, [dbo].[office] as o
            //                where c.CourtID = cr.CourtID and c.ChamberID = ch.ChamberID and ch.CourtID = cr.CourtID and c.officeID = o.officeID";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public static List<Case> GetCasesbyChamberId(int chamberid)
        {
            using (var cont = new SmartLowerEntities())
            {
                try
                {
                    return cont.Cases.Where(c=>c.ChamberID == chamberid).ToList();
                }
                catch { return null; }
            }
        }

        public static List<Case> GetCasesbyNumber(int casdid)
        {
            using (var cont = new SmartLowerEntities())
            {
                try
                {
                    return cont.Cases.Where(c => c.CaseID == casdid).ToList();
                }
                catch { return null; }
            }
        }

        public static List<Case> GetCasesbyDelegationNumber(string delegationNumber)
        {
            using (var cont = new SmartLowerEntities())
            {
                try
                {
                    return cont.Cases.Where(c => c.DelegationNumber.ToLower() == delegationNumber.ToLower()).ToList();
                }
                catch { return null; }
            }
        }
    }
}
