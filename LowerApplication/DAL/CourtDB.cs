using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LowerApplication.Classes;

namespace LowerApplication.DAL
{
    public class CourtDB
    {

        public static Court GetCourt()
        {
            using (var cont = new SmartLowerEntities())
            {
                return cont.Courts.FirstOrDefault();
            }
        }

        public static Court GetCourtById(int id)
        {
            using (var cont = new SmartLowerEntities())
            {
                try
                {
                    return cont.Courts.Where(i => i.CourtID == id).FirstOrDefault();
                }
                catch { return null; }
            }
        }

        public static List<Court> GetAllCourts()
        {
            using (var cont = new SmartLowerEntities())
            {
                return cont.Courts.ToList();
            }
        }
        
        public static int InsertCourt(Court obj, State s)
        {
            using (var cont = new SmartLowerEntities())
            {
                if (obj != null)
                {
                    try
                    {
                        if (s == State.Insert)
                        {
                            cont.Courts.Add(obj);
                            cont.SaveChanges();

                        }
                        if(s == State.Update)
                        {
                            Court cor = (from c in cont.Courts.Where(c => c.CourtID == obj.CourtID) select c).FirstOrDefault();
                            cor.CourtName = obj.CourtName;
                            cor.CourtAddress = obj.CourtAddress;
                            cor.CourtDetails = obj.CourtDetails;
                            cor.CourtRegionID = obj.CourtRegionID;
                            cont.SaveChanges();
                        }
                        return obj.CourtID;
                    }
                    catch { return -1; }
                }
                return -1;
            }
        }

        public static int DeleteCourt(Court obj)
        {
            using (var cont = new SmartLowerEntities())
            {
                if (obj != null)
                {
                    try
                    {
                        Court crt = (Court)cont.Courts.Select(c => c.CourtID == obj.CourtID);
                        cont.Courts.Remove(crt);
                        cont.SaveChanges();
                        return obj.CourtID;
                    }
                    catch (Exception e) { return -1; }
                }
                return -1;
            }
        }
    }
}
