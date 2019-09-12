using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowerApplication.DAL
{
    public class ChamberDB
    {
        public static Chamber GetChamber()
        {
            using (var cont = new SmartLowerEntities())
            {
                return cont.Chambers.FirstOrDefault();
            }
        }
        public static Chamber GetChamberbyId(int id)
        {
            using (var cont = new SmartLowerEntities())
            {
                try
                {
                    return cont.Chambers.Where(cid => cid.ChamberID == id).FirstOrDefault();
                }
                catch { return null; }
            }
        }
        public static List<Chamber> GetAllChambers()
        {
            using (var cont = new SmartLowerEntities())
            {
                return cont.Chambers.ToList();
            }
        }
        public static List<Chamber> GetAllChambersByCourtId(int courtId)
        {
            using (var cont = new SmartLowerEntities())
            {
                try
                {
                    return cont.Chambers.Where(ch => ch.CourtID == courtId).ToList();
                }
                catch { return null; }
            }
        }
        public static int InsertChamber(Chamber ch)
        {
            using (var cont = new SmartLowerEntities())
            {
                if (ch == null)
                    return -1;
                cont.Chambers.Add(ch);
                return cont.SaveChanges();
            }
        }
        public static int UpdateChamber(Chamber ch)
        {
            using (var cont = new SmartLowerEntities())
            {
                if (ch == null)
                    return -1;

                Chamber c = cont.Chambers.Where(cha => cha.ChamberID == ch.ChamberID).FirstOrDefault();
                c.ChamberName = ch.ChamberName;
                c.ChamberBossName = ch.ChamberBossName;
                c.CourtID = ch.CourtID;
                c.ChamberAdress = ch.ChamberAdress;
                return cont.SaveChanges();
            }
        }

        public static int DeleteChamber(Chamber ch)
        {
            using (var cont = new SmartLowerEntities())
            {
                if (ch == null)
                    return -1;

                Chamber c = cont.Chambers.Where(cha => cha.ChamberID == ch.ChamberID).FirstOrDefault();
                cont.Chambers.Remove(ch);
                return cont.SaveChanges();
            }
        }
    }
}
