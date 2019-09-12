using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowerApplication.DAL
{
    public class SessionsDB
    {
        public static List<CaseSession> GetSessionsByCaseID(int caseid)
        {
            using (var cont = new SmartLowerEntities())
            {
                try
                {
                    return cont.CaseSessions.Where(cs => cs.CaseID == caseid).OrderBy(cs => cs.SessionDate).ToList();
                }
                catch { }
                return new List<CaseSession>();
            }
        }

        public static int DeleteCaseSessionsByCaseID(int caseid)
        {
            int deleted = 0;
            using (var cont = new SmartLowerEntities())
            {
                try
                {
                    var css = cont.CaseSessions.Where(cs => cs.CaseID == caseid).ToList();
                    foreach (CaseSession cs in css)
                    {
                       cont.CaseSessions.Remove(cs);
                       deleted += cont.SaveChanges();
                    }
                }
                catch { }
                return deleted;
            }
        }

        public static int InsertSeesion(CaseSession cs)
        {
            using (var cont = new SmartLowerEntities())
            {
                try
                {
                    if(cs !=null)
                    {
                        cont.CaseSessions.Add(cs);
                        return cont.SaveChanges();
                    }
                }
                catch { }
                return -1;
            }
        }
    }
}
