using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace LowerApplication.DAL
{
    class Connection
    {
        public static SqlConnection ConnObj;

        public static SqlConnection GetConnection()
        {
            try
            {
                string connstr = ConfigurationManager.ConnectionStrings["SmartLowerEntities"].ToString();
                ConnObj = new SqlConnection("data source=.;initial catalog=SmartLower;user id=sa;password=123456");
                return ConnObj;
            }
            catch { }
            return null;
        }

        public static bool OpenConnection()
        {
            try
            {
                if(ConnObj.State != ConnectionState.Open)
                    ConnObj.Open();
                return true;
            }
            catch { }
            return false;
        }
        public static bool CloseConnection()
        {
            try
            {
                if (ConnObj.State != ConnectionState.Closed)
                    ConnObj.Close();
                return true;
            }
            catch { }
            return false;
        }


    }
}
