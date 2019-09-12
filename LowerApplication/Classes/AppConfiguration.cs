using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DevComponents.DotNetBar;
using System.Windows.Forms;
using DevComponents.DotNetBar.Rendering;
using System.Drawing;

namespace EasyStore.UI.Configurations
{
    public class AppConfiguration
    {


        static string sysColor;
        static short nCopies;
        static string connectionString;
        static SqlConnectionStringBuilder ConnectionStringBuilder = new SqlConnectionStringBuilder();


        #region ---------------------------------------------------------------  Public Propertiy

        public static string AdminUser { get; set; }

        public static string AdminPassword { get; set; } 

        public static string Key { get; set; }

        public static string License { get; set; }

        public static string UserID { get; set; }

        public static string Password { get; set; }

        public static string ServerName { get; set; }

        public static string DataBaseName { get; set; }

        public static string ConnectionString
        {
            get
            {
                return xmlConfiguration.Default.ConnectionString;
            }
            set
            {
                connectionString = value;
                ConnectionStringBuilder.ConnectionString = connectionString;
                xmlConfiguration.Default.ConnectionString = connectionString;
                xmlConfiguration.Default.Save();
                DisplayConfigurations();
            }
        }

        public static string SysColor
        {
            get
            {
                if (xmlConfiguration.Default.sysColor != null)
                {
                    return xmlConfiguration.Default.sysColor;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                sysColor = value;
                xmlConfiguration.Default.sysColor = sysColor;
                xmlConfiguration.Default.Save();
            }
        }        
        public static short NumberCopyies
        {
            get
            {
                if (xmlConfiguration.Default.nCopies != null)
                {
                    return xmlConfiguration.Default.nCopies;
                }
                else
                {
                    return 1;
                }
            }
            set
            {
                nCopies = value;
                xmlConfiguration.Default.nCopies = nCopies;
                xmlConfiguration.Default.Save();
            }
        }

         
        
        #endregion


        #region ---------------------------------------------------------------  Public Methods
        public static void SetServerConfigurations(string _connectionString)
        {
            ConnectionStringBuilder.ConnectionString = _connectionString;
            xmlConfiguration.Default.ConnectionString = _connectionString;
            xmlConfiguration.Default.Save();
            DisplayConfigurations();
        }

        public static void LoadServerConfigurations()
        {
            if (xmlConfiguration.Default.ConnectionString != null)
            {
                ConnectionStringBuilder.ConnectionString = xmlConfiguration.Default.ConnectionString;
                UserID = ConnectionStringBuilder.UserID;
                Password = ConnectionStringBuilder.Password;
                ServerName = ConnectionStringBuilder.DataSource;
                DataBaseName = ConnectionStringBuilder.InitialCatalog;
            }
        }

        public static void SetUserLicense(string key, string license)
        {
            xmlConfiguration.Default.Key = key;
            xmlConfiguration.Default.License = license;
            xmlConfiguration.Default.Save();
        }

        public static void LoadUserLicense()
        {
            Key = xmlConfiguration.Default.Key;
            License = xmlConfiguration.Default.License;
        }

        public static void SetAdminUser(string adminUser, string adminPassword)
        {
            xmlConfiguration.Default.AdminUser = adminUser;
            xmlConfiguration.Default.AdminPassword = adminPassword;
            xmlConfiguration.Default.Save();
        }

        public static void LoadAdminUser()
        {
            AdminUser = xmlConfiguration.Default.AdminUser;
            AdminPassword = xmlConfiguration.Default.AdminPassword;
        }

        public static void LoadSysColor(Control frm, string sysColor)
        {
            switch (sysColor)
            {
                case "Black":
                    {
                        RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(frm, eOffice2007ColorScheme.Black);
                        break;
                    }
                case "Blue":
                    {
                        RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(frm, eOffice2007ColorScheme.Blue);
                        break;
                    }
                case "Silver":
                    {
                        RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(frm, eOffice2007ColorScheme.Silver);
                        break;
                    }
                case "VistaGlass":
                    {
                        RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(frm, eOffice2007ColorScheme.VistaGlass);
                        break;
                    }
                default:
                    {
                        //eOffice2007ColorScheme baseColorScheme;
                        //Color c = new Color();

                        //RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(frm, baseColorScheme, e.Color);
                        RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(frm, eOffice2007ColorScheme.VistaGlass);
                        break;
                    }
            }
        }

        public static void LoadSysColor(Control frm, ColorPreviewEventArgs e, eOffice2007ColorScheme baseColorScheme)
        {
            RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(frm, baseColorScheme, e.Color);
        } 
        #endregion
        #region --------------------------------------------------------------- Private Methods
        private static void DisplayConfigurations()
        {
            if (xmlConfiguration.Default.ConnectionString != null)
            {
                UserID = ConnectionStringBuilder.UserID;
                Password = ConnectionStringBuilder.Password;
                ServerName = ConnectionStringBuilder.DataSource;
                DataBaseName = ConnectionStringBuilder.InitialCatalog;
            }
        } 
        #endregion
    }
}
