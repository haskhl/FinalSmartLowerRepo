using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowerApplication.DAL
{
    public class DelegatorDB
    {

        public static Delegator GetDelegator()
        {
            using (var cont = new SmartLowerEntities())
            {
                return cont.Delegators.FirstOrDefault();
            }
        }

        public static List<Delegator> GetAllDelegators()
        {
            using (var cont = new SmartLowerEntities())
            {
                return cont.Delegators.ToList();
            }
        }

        public static DataTable GetDelegatorByCaseId(int caseId)
        {
            SqlConnection conn = Connection.GetConnection();
            string query = @"select d.DelName, d.DelAddress, 
                            d.DelMobile, d.DelPhone, 
                            d.DelDetails, d.DelSSN,
                            ds.Notes 
                            from Delegator as d, Delegator_Case as ds
                            where d.DelID =ds.DelID and  ds.CaseID = "+caseId;

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static int InsertCaseDelegators(List<Delegator> delegators, List<Delegator_Case> delegators_case)
        {
            using (var cont = new SmartLowerEntities())
            {
                if (delegators != null && delegators.Count > 0)
                {
                    foreach (Delegator d in delegators)
                    {
                        try
                        {
                            cont.Delegators.Add(d);
                            cont.SaveChanges();
                        }
                        catch { }
                    }
                    if (delegators_case != null && delegators_case.Count > 0)
                    {
                        foreach (Delegator_Case delcas in delegators_case)
                        {
                            try
                            {
                                cont.Delegator_Case.Add(delcas);
                                cont.SaveChanges();
                            }
                            catch { }
                        }
                    }
                    return 1;
                }
                return -1;
               
            }
        }

        public static int InsertDelegator(Delegator del)
        {
            using (var cont = new SmartLowerEntities())
            {
                try
                {
                    if(del != null)
                    {
                        cont.Delegators.Add(del);
                        return del.DelID;
                    }
                    return -1;
                }
                catch { return -1; }
            }
        }

        public static int[] InsertDelegator_Case(Delegator_Case delcase)
        {
            using (var cont = new SmartLowerEntities())
            {
                int[] ids = new int[2];
                try
                {
                    if (delcase != null)
                    {
                        cont.Delegator_Case.Add(delcase);
                        cont.SaveChanges();
                        ids[0] = delcase.CaseID;
                        ids[1] = delcase.DelID;
                    }
                    return ids;
                }
                catch { return ids; }
            }
        }

        public static int DeleteCaseDelegators(int caseId)
        {
            using (var cont = new SmartLowerEntities())
            {
                try
                {
                    int affectedrows = 0;
                    List<Delegator_Case> dlcslst = cont.Delegator_Case.Where(c => c.CaseID == caseId).ToList();
                    foreach (Delegator_Case dlcs in dlcslst)
                    {
                        try
                        {
                            cont.Delegator_Case.Remove(dlcs);
                            affectedrows += cont.SaveChanges();
                        }
                        catch { }
                    }
                    return affectedrows;
                }
                catch { return -1; }
            }
        }

    }
}
