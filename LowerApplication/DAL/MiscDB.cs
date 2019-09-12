using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowerApplication.DAL
{
    public class MiscDB
    {
       static  SmartLowerEntities context = new SmartLowerEntities();
        
        public static int DeleteOfficeData(Office o)
        {
            try
            {
                context.Offices.Remove(o);
                return context.SaveChanges();
            }
            catch { return -1; }
        }
        
        public static List<Office> GetOffice()
        {
            using (var cont = new SmartLowerEntities())
            {
                try
                {
                    return cont.Offices.ToList();
                }
                catch { return null; }
            }
        }
        public static Office GetOfficeById(int id)
        {
            using (var cont = new SmartLowerEntities())
            {
                try
                {
                    return cont.Offices.Where(of => of.OfficeID == id).FirstOrDefault();
                }
                catch { return null; }
            }

        }

        public static List<Office> GetAllOffices()
        {
            return context.Offices.ToList();
        }

        public static int AddOffice(Office o)
        {
            if (o == null)
                return -1;
            context.Offices.Add(o);
            context.SaveChanges();
            return o.OfficeID;
        }

        public static int AddRegion(Region r)
        {
            if (r == null)
                return -1;
            context.Regions.Add(r);
            context.SaveChanges();
            return r.RegionID;                
        }
        public static int UpdateRegion(Region r)
        {
            if (r == null)
                return - 1;
            Region reg = (Region)context.Regions.Select(re => re.RegionID == r.RegionID);
            reg.RegionName = r.RegionName;
            reg.RegionDetails = r.RegionDetails;
            return context.SaveChanges();
        }
        public static Region GetRegion()
        {
            try
            {
                return context.Regions.FirstOrDefault();
            }
            catch { return null; }
        }

        public static List<Region> GetAllRegions()
        {
            return context.Regions.ToList();
        }

        public static int DeleteRegion(Region r)
        {
            if (r == null)
                return -1;
            Region reg = context.Regions.Where(re => re.RegionID == r.RegionID).FirstOrDefault();
            context.Regions.Remove(reg);
            return context.SaveChanges();
        }

        public static int AddDocOffice(DocumentationOffice dof)
        {
            try
            {
                if(dof != null)
                {
                    context.DocumentationOffices.Add(dof);
                    return context.SaveChanges();
                }
                return -1;
            }
            catch(Exception ex) { return ex.HResult; }
        }

        public static int DeleteDocOffice(DocumentationOffice dof)
        {
            try
            {
                if (dof != null)
                {
                    context.DocumentationOffices.Remove(dof);
                    return context.SaveChanges();
                }
                return -1;
            }
            catch (Exception ex) { return ex.HResult; }
        }

        public static List<DocumentationOffice> GetAllDocOffices()
        {
            return context.DocumentationOffices.ToList();
        }

        public static int AddCLower(CompetitorLower CLower)
        {
            try
            {
                if (CLower != null)
                {
                    context.CompetitorLowers.Add(CLower);
                    return context.SaveChanges();
                }
                return -1;
            }
            catch (Exception ex) { return ex.HResult; }
        }

        public static int AddCLower_Case(CLowers_Case CLower_Case)
        {
            try
            {
                if (CLower_Case != null)
                {
                    context.CLowers_Case.Add(CLower_Case);
                    return context.SaveChanges();
                }
                return -1;
            }
            catch (Exception ex) { return ex.HResult; }
        }

        public static DataTable GetCLowerByCaseId(int caseId)
        {
            SqlConnection conn = Connection.GetConnection();
            string query = @"select c.CLowerName, c.CLowerPhone, c.CLowerOffice, c.CLowerDetails 
                            from CompetitorLower as c, CLowers_Case as cs
                            where c.CLowerID =cs.CLowerID and cs.CaseID = " + caseId;

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
