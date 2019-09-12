using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Data;
using System.Security.Cryptography;
using System.Management;
using System.IO;
using EasyStore.Classes;
using EasyStore.UI.Configurations;
using System.Runtime.InteropServices;

namespace AppRegistration
{
  

    // declares the enum
    enum HardWareNames
    {
        Win32_Processor,
        Win32_LogicalDisk,
        Win32_NetworkAdapterConfiguration,
        Win32_BaseBoard,
        Win32_CDROMDrive,
        Win32_BIOS,
        Win32_UserAccount,
        Win32_PhysicalMemory,
        Win32_PhysicalMemoryArray,
        Win32_DiskDrive
    }


    public class Registration
    {

        public static HardwareInfo hardwareInfo = new HardwareInfo();
       // public static clsRegistry registry = new clsRegistry();
        public static CRC32 CRC = new CRC32();
        public static WriteInFile writeInFile = new WriteInFile();

    }

    public class HardwareInfo
    {

        public HardwareInfo()
        {
            mdtableInfo.Columns.Add("colName", typeof(string));
            mdtableInfo.Columns.Add("colValue", typeof(string));
        }

        #region +++++++++++++++++++++++++++++++++++++++++++   public Variables
        public DataTable mdtableInfo = new DataTable();
        public static string[] mstrProcessorInfo = new string[] { "Name", "DeviceID", "Description", "L2CacheSize", "ProcessorId" };
        public static string[] mstrBoardInfo = new string[] { "Name", "Caption", "Manufacturer", "Product", "Version", "SerialNumber" };
        public static string[] mstrDiskDriveInfo = new string[] { "Name", "Caption", "Description", "InterfaceType", "Size", "SerialNumber" };
        public static string[] mstrLANInfo = new string[] { "MACAddress" };
        #endregion


        #region +++++++++++++++++++++++++++++++++++++++++++++++++   Security


        /// <summary>
        /// use to encrypt hardware info using Hashing code
        /// </summary>
        /// <returns></returns>
        public byte[] EncryptInfoByHashing()
        {
            byte[] HashArray;
            string PCInfo = string.Empty;
            try
            {
                //get hardware information to string 
                PCInfo = GetAllHardWareInfo();

                //Create an instance of the MD5 provider.
                MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider();
                HashArray = provider.ComputeHash(Encoding.Default.GetBytes(PCInfo));   //Hash any word.

            }
            catch (Exception)
            {
                throw;
            }

            return HashArray;
        }


        public string EncryptInfoByHashingWithCRC()
        {
            byte[] HashArray;
            string PCInfo = string.Empty;
            try
            {
                //get hardware information to string 
                PCInfo = GetAllHardWareInfo();

                //Create an instance of the MD5 provider.
                MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider();
                HashArray = provider.ComputeHash(Encoding.Default.GetBytes(PCInfo));   //Hash any word.
                PCInfo = Registration.CRC.GetCrc32(HashArray);
            }
            catch (Exception)
            {
                throw;
            }

            return PCInfo;
        }



        public string EncryptInfoByGC(string word, int order)
        {
            string lstrInfo = string.Empty;
            try
            {

                byte[] Encrpty = EncryptInfoByGC(word, order, true);
                for (int i = 0; i < Encrpty.Length; i++)
                {
                    lstrInfo += Encrpty[i].ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return lstrInfo;
        }


        public string EncryptInfoByGCWithCRC(string word, int order)
        {
            string lstrInfo = string.Empty;
            try
            {

                byte[] Encrpty = EncryptInfoByGC(word, order, true);
                lstrInfo = Registration.CRC.GetCrc32(Encrpty);

            }
            catch (Exception)
            {
                throw;
            }

            return lstrInfo;
        }



        public byte[] EncryptInfoByGC(string word, int order,bool diff)
        {
            byte[] Encrpty;
            try
            {
                byte[] Key = Encoding.ASCII.GetBytes(word);

                //Create an instance of the GCCryptography .
                GCCryptography provider = new GCCryptography();

                //use Goldn Cryptograpgy algorithm 
                Encrpty = provider.GCEncrypt(Key, order);

            }
            catch (Exception)
            {
                throw;
            }

            return Encrpty;
        }


        //public string GenerateKeyByGC(int order)
        //{
        //    string lstrInfo = string.Empty;
        //    try
        //    {
        //        //Get hardware information.
        //      //  lstrInfo = EncryptionInfo();

        //        byte[] Key = Encoding.ASCII.GetBytes(lstrInfo);
        //        lstrInfo = string.Empty;   //Rest  PCInfo

        //        //Create an instance of the GCCryptography .
        //        GCCryptography provider = new GCCryptography();

        //        //Hash any word.
        //        byte[] Encrpty = provider.GCEncrypt(Key, order);

        //        // lstrInfo = System.Text.ASCIIEncoding.ASCII.GetString(Encrpty);
        //        for (int i = 0; i < Encrpty.Length; i++)
        //        {
        //            lstrInfo += Encrpty[i].ToString();
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }

        //    return lstrInfo;
        //}


        public bool CheckInfoByHash(string PCInfo)
        {
            try
            {

                string PCInfo2 = string.Empty;

                // get hardware information and encrpt it by hashing Code
              //  PCInfo2 = EncryptionInfo();


                if (PCInfo == PCInfo2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        public bool CheckInfoByGC(string LicenseInfo, int order)
        {
            try
            {
                string PCInfo = string.Empty;

                // get hardware information and encrpt it by hashing Code
                PCInfo = EncryptInfoByHashingWithCRC();
                PCInfo = EncryptInfoByGCWithCRC(PCInfo, order);

                if (LicenseInfo == PCInfo)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }

        }


        #endregion


        #region ++++++++++++++++++++++++++++++++++++++++++   HardWare Info
        private string GetAllHardWareInfo()
        {
            string key = "ProcessorInfo:";
            try
            {
                GetInfo(HardWareNames.Win32_Processor.ToString(), true, HardwareInfo.mstrProcessorInfo);
                for (int i = 0; i < mdtableInfo.Rows.Count; i++)
                {
                    key += mdtableInfo.Rows[i]["colValue"].ToString();
                }
                key += new StringBuilder().AppendLine() + "DiskDriveInfo:";
                GetInfo(HardWareNames.Win32_DiskDrive.ToString(), true, HardwareInfo.mstrDiskDriveInfo);
                for (int i = 0; i < mdtableInfo.Rows.Count; i++)
                {
                    key += mdtableInfo.Rows[i]["colValue"].ToString();
                }
                key += new StringBuilder().AppendLine() + "BoardInfo:";
                GetInfo(HardWareNames.Win32_BaseBoard.ToString(), true, HardwareInfo.mstrBoardInfo);
                for (int i = 0; i < mdtableInfo.Rows.Count; i++)
                {
                    key += mdtableInfo.Rows[i]["colValue"].ToString();
                }
                key += new StringBuilder().AppendLine() + "MACAddress:";
                key += HardwareInfo.GetMACAddress();
                key += new StringBuilder().AppendLine() + "PhysicalMemory:";
                key += HardwareInfo.GetPhysicalMemory();
            }
            catch (Exception)
            {
                throw;
            }

            return key;
        }


        public string GetInfo(string Key, bool DontInsertNull)
        {
            mdtableInfo.Rows.Clear();
            string lstrInfo = string.Empty;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + Key);

            try
            {
                foreach (ManagementObject share in searcher.Get())
                {

                    try
                    {
                        lstrInfo = share["Name"].ToString();
                    }
                    catch
                    {
                        lstrInfo = share.ToString();
                    }

                    if (share.Properties.Count <= 0)
                    {
                        lstrInfo = "No Information Available";
                        return lstrInfo;
                    }


                    foreach (PropertyData PC in share.Properties)
                    {
                        mdtableInfo.Rows.Add(mdtableInfo.NewRow());

                        mdtableInfo.Rows[mdtableInfo.Rows.Count - 1]["colName"] = PC.Name;



                        if (PC.Value != null && PC.Value.ToString() != "")
                        {
                            switch (PC.Value.GetType().ToString())
                            {
                                case "System.String[]":
                                    {
                                        string[] str = (string[])PC.Value;
                                        string str2 = "";
                                        foreach (string st in str)
                                        {
                                            str2 += st + " ";
                                        }
                                        mdtableInfo.Rows[mdtableInfo.Rows.Count - 1]["colValue"] = str2;

                                        break;
                                    }
                                case "System.UInt16[]":
                                    {
                                        ushort[] shortData = (ushort[])PC.Value;


                                        string tstr2 = "";
                                        foreach (ushort st in shortData)
                                            tstr2 += st.ToString() + " ";

                                        mdtableInfo.Rows[mdtableInfo.Rows.Count - 1]["colValue"] = tstr2;

                                        break;
                                    }

                                default:
                                    {
                                        mdtableInfo.Rows[mdtableInfo.Rows.Count - 1]["colValue"] = PC.Value.ToString();
                                        break;
                                    }
                            }
                        }
                        else
                        {
                            if (!DontInsertNull)
                                mdtableInfo.Rows[mdtableInfo.Rows.Count - 1]["colValue"] = "No Information available";
                            else
                                continue;
                        }

                    }
                }

            }


            catch (Exception exp)
            {
                MessageBox.Show("can't get data because of the followeing error \n" + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return lstrInfo;

        }

        public bool GetInfo(string Key, bool DontInsertNull, string[] PartInfo)
        {
            mdtableInfo.Rows.Clear();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + Key);

            try
            {
                foreach (ManagementObject share in searcher.Get())
                {
                    if (share.Properties.Count <= 0)
                    {
                        return false;
                    }

                    foreach (PropertyData PC in share.Properties)
                    {
                        if (ChooseHardWareInfo(PartInfo, PC))
                        {
                            mdtableInfo.Rows.Add(mdtableInfo.NewRow());
                            mdtableInfo.Rows[mdtableInfo.Rows.Count - 1]["colName"] = PC.Name;

                            if (PC.Value != null && PC.Value.ToString() != string.Empty)
                            {
                                switch (PC.Value.GetType().ToString())
                                {
                                    case "System.String[]":
                                        {
                                            string[] str = (string[])PC.Value;
                                            string str2 = "";
                                            foreach (string st in str)
                                            {
                                                str2 += st + " ";
                                            }
                                            mdtableInfo.Rows[mdtableInfo.Rows.Count - 1]["colValue"] = str2;

                                            break;
                                        }
                                    case "System.UInt16[]":
                                        {
                                            ushort[] shortData = (ushort[])PC.Value;


                                            string tstr2 = "";
                                            foreach (ushort st in shortData)
                                                tstr2 += st.ToString() + " ";

                                            mdtableInfo.Rows[mdtableInfo.Rows.Count - 1]["colValue"] = tstr2;

                                            break;
                                        }

                                    default:
                                        {
                                            mdtableInfo.Rows[mdtableInfo.Rows.Count - 1]["colValue"] = PC.Value.ToString();
                                            break;
                                        }
                                }
                            }
                            else
                            {
                                if (!DontInsertNull)
                                    mdtableInfo.Rows[mdtableInfo.Rows.Count - 1]["colValue"] = "No Information available";
                                else
                                    continue;
                            }

                        }
                    }
                }

            }


            catch (Exception exp)
            {
                MessageBox.Show("can't get data because of the followeing error \n" + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return true;

        }

        private bool ChooseHardWareInfo(string[] PropertyValue, PropertyData PC)
        {
            bool b = false;
            for (int i = 0; i < PropertyValue.Length; i++)
            {
                if (PC.Name.ToLower() == PropertyValue[i].ToLower())
                {
                    b = true;
                    break;
                }
            }
            return b;
        }
        #endregion


        #region ++++++++++++++++++++++++++++++++   HardWare Info 2
        /// <summary>
        /// Retrieving Processor ID.
        /// </summary>
        /// <returns></returns>
        /// 
        public static string GetProcessorID()
        {
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            string lstrProcessorID = String.Empty;
            try
            {
                foreach (ManagementObject mo in moc)
                {
                    lstrProcessorID = mo.Properties["processorID"].Value.ToString();
                    break;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return lstrProcessorID;
        }


        /// <summary>
        /// Retrieving HDD Serial No.
        /// </summary>
        /// <returns></returns>
        public static string GetHDDSerialNo()
        {
            ManagementClass mc = new ManagementClass("Win32_LogicalDisk");
            ManagementObjectCollection moc = mc.GetInstances();
            string lstrHDDSerialNo = string.Empty;

            try
            {
                foreach (ManagementObject mo in moc)
                {
                    lstrHDDSerialNo += Convert.ToString(mo["VolumeSerialNumber"]);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return lstrHDDSerialNo;
        }


        /// <summary>
        /// Retrieving System MAC Address.
        /// </summary>
        /// <returns></returns>
        public static string GetMACAddress()
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();
            string lstrMACAddress = string.Empty;
            try
            {
                foreach (ManagementObject mo in moc)
                {
                    if (lstrMACAddress == String.Empty)
                    {
                        if ((bool)mo["IPEnabled"] == true) lstrMACAddress = mo["MacAddress"].ToString();
                    }
                    mo.Dispose();
                }
            }
            catch (Exception)
            {
                throw;
            }
            lstrMACAddress = lstrMACAddress.Replace(":", "");
            return lstrMACAddress;
        }


        /// <summary>
        /// Retrieving Motherboard Manufacturer.
        /// </summary>
        /// <returns></returns>
        public static string GetBoardMaker()
        {

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");

            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Manufacturer").ToString();
                }

                catch (Exception)
                {
                    throw;
                }

            }

            return "Board Maker: Unknown";

        }


        /// <summary>
        /// Retrieving Motherboard Product Id.
        /// </summary>
        /// <returns></returns>
        public static string GetBoardProductID()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Product").ToString();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return "Product: Unknown";
        }


        /// <summary>
        /// Retrieving CD-DVD Drive Path.
        /// </summary>
        /// <returns></returns>
        public static string GetCdRomDrive()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_CDROMDrive");
            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Drive").ToString();
                }

                catch (Exception)
                {
                    throw;
                }

            }
            return "CD ROM Drive Letter: Unknown";

        }


        /// <summary>
        /// Retrieving BIOS Maker.
        /// </summary>
        /// <returns></returns>
        public static string GetBIOSmaker()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");
            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Manufacturer").ToString();
                }
                catch (Exception)
                {
                    throw;
                }

            }

            return "BIOS Maker: Unknown";

        }


        /// <summary>
        /// Retrieving BIOS Serial No.
        /// </summary>
        /// <returns></returns>
        public static string GetBIOSserNo()
        {

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");

            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("SerialNumber").ToString();

                }

                catch (Exception)
                {
                    throw;
                }

            }

            return "BIOS Serial Number: Unknown";

        }


        /// <summary>
        /// Retrieving BIOS Caption.
        /// </summary>
        /// <returns></returns>
        public static string GetBIOScaption()
        {

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");

            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Caption").ToString();

                }
                catch (Exception)
                {
                    throw;
                }
            }
            return "BIOS Caption: Unknown";
        }


        /// <summary>
        /// Retrieving System Account Name.
        /// </summary>
        /// <returns></returns>
        public static string GetAccountName()
        {

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_UserAccount");

            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {

                    return wmi.GetPropertyValue("Name").ToString();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return "User Account Name: Unknown";

        }


        /// <summary>
        /// Retrieving Physical Ram Memory.
        /// </summary>
        /// <returns></returns>
        public static string GetPhysicalMemory()
        {
            ManagementScope oMs = new ManagementScope();
            ObjectQuery oQuery = new ObjectQuery("SELECT Capacity FROM Win32_PhysicalMemory");
            ManagementObjectSearcher oSearcher = new ManagementObjectSearcher(oMs, oQuery);
            ManagementObjectCollection oCollection = oSearcher.Get();

            long MemSize = 0;
            long mCap = 0;

            try
            {
                // In case more than one Memory sticks are installed
                foreach (ManagementObject obj in oCollection)
                {
                    mCap = Convert.ToInt64(obj["Capacity"]);
                    MemSize += mCap;
                }
                MemSize = (MemSize / 1024) / 1024;
            }
            catch (Exception)
            {

                throw;
            }
            return MemSize.ToString() + "MB";
        }


        /// <summary>
        /// Retrieving No of Ram Slot on Motherboard.
        /// </summary>
        /// <returns></returns>
        public static string GetNoRamSlots()
        {

            int MemSlots = 0;
            ManagementScope oMs = new ManagementScope();
            ObjectQuery oQuery2 = new ObjectQuery("SELECT MemoryDevices FROM Win32_PhysicalMemoryArray");
            ManagementObjectSearcher oSearcher2 = new ManagementObjectSearcher(oMs, oQuery2);
            ManagementObjectCollection oCollection2 = oSearcher2.Get();
            try
            {
                foreach (ManagementObject obj in oCollection2)
                {
                    MemSlots = Convert.ToInt32(obj["MemoryDevices"]);

                }
            }
            catch (Exception)
            {
                throw;
            }
            return MemSlots.ToString();
        }

        /// <summary>
        /// Get CPU Temprature.
        /// method for retrieving the CPU Manufacturer
        /// using the WMI class
        /// </summary>
        /// <returns>CPU Manufacturer</returns>
        public static string GetCPUManufacturer()
        {
            string cpuMan = String.Empty;
            //create an instance of the Managemnet class with the
            //Win32_Processor class
            ManagementClass mgmt = new ManagementClass("Win32_Processor");
            //create a ManagementObjectCollection to loop through
            ManagementObjectCollection objCol = mgmt.GetInstances();
            //start our loop for all processors found
            try
            {
                foreach (ManagementObject obj in objCol)
                {
                    if (cpuMan == String.Empty)
                    {
                        // only return manufacturer from first CPU
                        cpuMan = obj.Properties["Manufacturer"].Value.ToString();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return cpuMan;
        }

        /// <summary>
        /// method to retrieve the CPU's current
        /// clock speed using the WMI class
        /// </summary>
        /// <returns>Clock speed</returns>
        public static int GetCPUCurrentClockSpeed()
        {
            int cpuClockSpeed = 0;
            //create an instance of the Managemnet class with the
            //Win32_Processor class
            ManagementClass mgmt = new ManagementClass("Win32_Processor");
            //create a ManagementObjectCollection to loop through
            ManagementObjectCollection objCol = mgmt.GetInstances();
            //start our loop for all processors found
            try
            {
                foreach (ManagementObject obj in objCol)
                {
                    if (cpuClockSpeed == 0)
                    {
                        // only return cpuStatus from first CPU
                        cpuClockSpeed = Convert.ToInt32(obj.Properties["CurrentClockSpeed"].Value.ToString());
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            //return the status
            return cpuClockSpeed;
        }

        /// <summary>
        /// method to retrieve the network adapters
        /// default IP gateway using WMI
        /// </summary>
        /// <returns>adapters default IP gateway</returns>
        public static string GetDefaultIPGateway()
        {
            //create out management class object using the
            //Win32_NetworkAdapterConfiguration class to get the attributes
            //of the network adapter
            ManagementClass mgmt = new ManagementClass("Win32_NetworkAdapterConfiguration");
            //create our ManagementObjectCollection to get the attributes with
            ManagementObjectCollection objCol = mgmt.GetInstances();
            string gateway = String.Empty;
            //loop through all the objects we find
            try
            {
                foreach (ManagementObject obj in objCol)
                {
                    if (gateway == String.Empty)  // only return MAC Address from first card
                    {
                        //grab the value from the first network adapter we find
                        //you can change the string to an array and get all
                        //network adapters found as well
                        //check to see if the adapter's IPEnabled
                        //equals true
                        if ((bool)obj["IPEnabled"] == true)
                        {
                            gateway = obj["DefaultIPGateway"].ToString();
                        }
                    }
                    //dispose of our object
                    obj.Dispose();
                }
            }
            catch (Exception)
            {
                throw;
            }
            //replace the ":" with an empty space, this could also
            //be removed if you wish
            gateway = gateway.Replace(":", "");
            //return the mac address
            return gateway;
        }


        /// <summary>
        /// Retrieve CPU Speed.
        /// </summary>
        /// <returns></returns>
        public static double? GetCpuSpeedInGHz()
        {
            double? GHz = null;
            try
            {
                using (ManagementClass mc = new ManagementClass("Win32_Processor"))
                {
                    foreach (ManagementObject mo in mc.GetInstances())
                    {
                        GHz = 0.001 * (UInt32)mo.Properties["CurrentClockSpeed"].Value;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return GHz;
        }
        #endregion


        public bool IsRegister()
        {

            string Key, Key1, Key2;
            string License, License1, License2;
            clsRegistry registry = new clsRegistry();

            //Load Info from  Registery Path : KEY_LOCAL_MACHINE\SOFTWARE\ + Application.ProductName
            Key1 = registry.Read("Key");
            License1 = registry.Read("License");

            //Load Info from  Registery Path : KEY_LOCAL_MACHINE\SOFTWARE\EasyLicense
            registry.SubKey = "SOFTWARE\\EasyLicense";
            Key2 = registry.Read("Key");
            License2 = registry.Read("License");


            //Load Info from Setting File.
            AppConfiguration.LoadUserLicense();
            Key = AppConfiguration.Key;
            License = AppConfiguration.License;

            if (Key1 == null || Key2 == null || Key == null)
            {
                
                return false;
            }

            if (Key != Key1 || License != License1)
            {
                return false;
            }

            Key = CreatePermutation(Key, 5);
            License = CreatePermutation(License, 5);

            if (Key != Key2 || License != License2)
            {
                return false;
            }

            return true;

        }

        public string CreatePermutation(string Input, int P)
        {
            clsPermutation objPermuation;
            // Local Variables
            string lstrPartPermutation = string.Empty;
            string lstrTotalPermutation = string.Empty;
            try
            {
                for (int indx = 0; indx < Input.Length; )
                {
                    // we must Reinialization to clear all object memebers
                    objPermuation = new clsPermutation();

                    // Split the file into equal parts  ( Each part consists of 4 letters)
                    if (indx + 4 < Input.Length)
                    {
                        lstrPartPermutation = Input.Substring(indx, 4);
                    }
                    else
                    {
                        lstrPartPermutation = Input.Substring(indx, Input.Length - indx);
                    }

                    // here we create permutation
                    if (lstrPartPermutation.Length == 4)
                    {
                        objPermuation.InputSet = objPermuation.MakeCharArray(lstrPartPermutation);
                        objPermuation.Recursion(0, P);
                        lstrTotalPermutation += objPermuation.PermutationWord;
                    }
                    else
                    {
                        objPermuation.InputSet = objPermuation.MakeCharArray(lstrPartPermutation);
                        objPermuation.Recursion(0, lstrPartPermutation.Length);
                        lstrTotalPermutation += objPermuation.PermutationWord;
                    }
                    indx += 4;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return lstrTotalPermutation;
        }
    }

    /// <summary>
    /// An useful class to read/write/delete/count registry keys
    /// </summary>
    public class clsRegistry
    {
        private bool mstrShowError = false;
        private string mstrSubKey = "SOFTWARE\\" + Application.ProductName.ToUpper();
        private RegistryKey mBaseRegistryKey = Registry.LocalMachine;


        //-----------------------------------Public Properities

        /// <summary>
        /// A property to show or hide error messages 
        /// (default = false)
        /// </summary>
        public bool ShowError
        {
            get
            {
                return mstrShowError;
            }
            set
            {
                mstrShowError = value;
            }
        }


        /// <summary>
        /// A property to set the SubKey value
        /// (default = "SOFTWARE\\" + Application.ProductName.ToUpper())
        /// </summary>
        public string SubKey
        {
            get
            {
                return mstrSubKey;
            }
            set
            {
                mstrSubKey = value;
            }
        }

        /// <summary>
        /// A property to set the BaseRegistryKey value.
        /// (default = Registry.LocalMachine)
        /// </summary>
        public RegistryKey BaseRegistryKey
        {
            get
            {
                return mBaseRegistryKey;
            }
            set
            {
                mBaseRegistryKey = value;
            }
        }


        //-----------------------------------Public Methods
        /// <summary>
        /// To read a registry key.
        /// input: KeyName (string)
        /// output: value (string) 
        /// </summary>
        public string Read(string KeyName)
        {
            // Opening the registry key
            RegistryKey rk = mBaseRegistryKey;
            // Open a subKey as read-only
            RegistryKey sk1 = rk.OpenSubKey(mstrSubKey);
            // If the RegistrySubKey doesn't exist -> (null)
            if (sk1 == null)
            {
                return null;
            }
            else
            {
                try
                {
                    // If the RegistryKey exists I get its value
                    // or null is returned.
                    return (string)sk1.GetValue(KeyName.ToUpper());
                }
                catch (Exception )
                {
                    ShowError = true;
                    // AAAAAAAAAAARGH, an error!
                   // ShowErrorMessage(ex, "Reading registry " + KeyName.ToUpper());
                   // return null;
                    throw;
                }
            }
        }


        /// <summary>
        /// To write into a registry key.
        /// input: KeyName (string) , Value (object)
        /// output: true or false 
        /// </summary>
        public bool Write(string KeyName, object Value)
        {
            try
            {
                // Setting
                RegistryKey rk = BaseRegistryKey;
                //rk.
                // I have to use CreateSubKey 
                // (create or open it if already exits), 
                // 'cause OpenSubKey open a subKey as read-only
                RegistryKey sk1 = rk.CreateSubKey(SubKey.ToUpper());
                // Save the value
                sk1.SetValue(KeyName.ToUpper(), Value);


                //RegistryKey root = null;

                ////using (ECR.Impersonator imp = new ECR.Impersonator("XXX", "XXX", "XXX"))
                ////{
                ////    WindowsIdentity ident = WindowsIdentity.GetCurrent();
                ////    WindowsPrincipal princ = new WindowsPrincipal(ident);
                ////    lit.Text = string.Format("{0}, {1}", ident.Name, princ.IsInRole(WindowsBuiltInRole.Administrator));
                ////    root = Registry.LocalMachine.CreateSubKey("SOFTWARE\\XXX", RegistryKeyPermissionCheck.ReadWriteSubTree);
                ////}
                ////root.SetValue("test", "test");
                ////RegistryKey key = root.CreateSubKey("XXX", RegistryKeyPermissionCheck.ReadWriteSubTree);


                return true;
            }
            catch (Exception)
            {
                ShowError = true;
                throw;
            }
        }


        /// <summary>
        /// To write into a registry key.
        /// input: KeyName (string) , Value (object)
        /// output: true or false 
        /// </summary>
        public bool GetValue(string KeyName)
        {
            try
            {
                // Setting

                //rk.
                // I have to use CreateSubKey 
                // (create or open it if already exits), 
                // 'cause OpenSubKey open a subKey as read-only
                string s = SubKey + "\\" + KeyName.ToUpper();
                string[] o = Registry.LocalMachine.GetValueNames();
                for (int i = 0; i < o.Length; i++)
                {
                    if (o[i].Contains(s))
                    {
                        return true;
                    }

                }
                //if (o == null)
                //    return false;
                //else
                //    return true;


            }
            catch (Exception e)
            {
                ShowError = true;
                // AAAAAAAAAAARGH, an error!
                ShowErrorMessage(e, "Writing registry " + e.Message);
                return false;
            }
            return false;
        }


        /// <summary>
        /// To delete a registry key.
        /// input: KeyName (string)
        /// output: true or false 
        /// </summary>
        public bool DeleteKey(string KeyName)
        {
            try
            {
                // Setting
                RegistryKey rk = mBaseRegistryKey;
                RegistryKey sk1 = rk.CreateSubKey(mstrSubKey);
                // If the RegistrySubKey doesn't exists -> (true)
                if (sk1 == null)
                    return true;
                else
                    sk1.DeleteValue(KeyName);

                return true;
            }
            catch (Exception e)
            {
                // AAAAAAAAAAARGH, an error!
                ShowErrorMessage(e, "Deleting SubKey " + mstrSubKey);
                return false;
            }
        }


        /// <summary>
        /// To delete a sub key and any child.
        /// input: void
        /// output: true or false 
        /// </summary>
        public bool DeleteSubKeyTree()
        {
            try
            {
                // Setting
                RegistryKey rk = mBaseRegistryKey;
                RegistryKey sk1 = rk.OpenSubKey(mstrSubKey);
                // If the RegistryKey exists, I delete it
                if (sk1 != null)
                    rk.DeleteSubKeyTree(mstrSubKey);

                return true;
            }
            catch (Exception e)
            {
                // AAAAAAAAAAARGH, an error!
                ShowErrorMessage(e, "Deleting SubKey " + mstrSubKey);
                return false;
            }
        }


        /// <summary>
        /// Retrive the count of subkeys at the current key.
        /// input: void
        /// output: number of subkeys
        /// </summary>
        public int SubKeyCount()
        {
            try
            {
                // Setting
                RegistryKey rk = mBaseRegistryKey;
                RegistryKey sk1 = rk.OpenSubKey(mstrSubKey);
                // If the RegistryKey exists...
                if (sk1 != null)
                    return sk1.SubKeyCount;
                else
                    return 0;
            }
            catch (Exception e)
            {
                // AAAAAAAAAAARGH, an error!
                ShowErrorMessage(e, "Retriving subkeys of " + mstrSubKey);
                return 0;
            }
        }


        /// <summary>
        /// Retrive the count of values in the key.
        /// input: void
        /// output: number of keys
        /// </summary>
        public int ValueCount()
        {
            try
            {
                // Setting
                RegistryKey rk = mBaseRegistryKey;
                RegistryKey sk1 = rk.OpenSubKey(mstrSubKey);
                // If the RegistryKey exists...
                if (sk1 != null)
                {
                    return sk1.ValueCount;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                ShowErrorMessage(e, "Retriving keys of " + mstrSubKey);
                return 0;
            }
        }


        private string ShowErrorMessage(Exception e, string Title)
        {
            if (mstrShowError == true)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }
    }

    /// <summary>
    /// Declarations for querying the Win32 Performance Counter
    /// </summary>
    internal class UnmanagedMethods
    {

        internal struct LARGE_INTEGER
        {
            public UInt32 lowpart;
            public UInt32 highpart;
        }

        [DllImport("kernel32.dll")]
        internal extern static UInt32 QueryPerformanceCounter(ref LARGE_INTEGER lpPerformanceCount);
        [DllImport("kernel32.dll")]
        internal extern static UInt32 QueryPerformanceFrequency(ref LARGE_INTEGER lpFrequency);

    }

    /// <summary>
    /// A Win32 timer using the system performance counter (the highest resolution timer
    /// possible on the system).  Typically the high performance counter has a resolution of 1 
    /// microsecond or less.
    /// </summary>
    public class HiResTimer
    {
        private float period = 0;
        private float startTime = 0;
        private float timerFrequency = 0;
        private bool hasHiResCounter = false;

        /// <summary>
        /// Starts the timing using the high resolution performance counter
        /// (if installed) on the machine.
        /// </summary>
        public void Start()
        {
            UnmanagedMethods.LARGE_INTEGER res = new UnmanagedMethods.LARGE_INTEGER();
            UnmanagedMethods.QueryPerformanceCounter(ref res);
            startTime = (float)((res.highpart >> 32) + res.lowpart);
        }

        /// <summary>
        /// Stops timing using the high resolution performance counter.  Note
        /// if Start() has not been called prior to this call, the result
        /// is undefined.
        /// </summary>
        public void Stop()
        {
            UnmanagedMethods.LARGE_INTEGER res = new UnmanagedMethods.LARGE_INTEGER();
            UnmanagedMethods.QueryPerformanceCounter(ref res);
            float endTime = (float)((res.highpart >> 32) + res.lowpart);
            period = endTime - startTime;
        }

        /// <summary>
        /// Returns the time measured between calling Start() and Stop() methods, 
        /// in seconds.
        /// </summary>
        public float ElapsedTime
        {
            get
            {
                return period / timerFrequency;
            }
        }

        /// <summary>
        /// Returns whether a high resolution counter is available on the system.
        /// If no hardware is available, this class will not be usable.  I have
        /// not found a system which does not provide this function.
        /// </summary>
        public bool HasHiResCounter
        {
            get
            {
                return hasHiResCounter;
            }
        }

        /// <summary>
        /// Returns the number of ticks per second of the high resolution
        /// counter.  Typically this will be 1 million or above.
        /// </summary>
        public float Frequency
        {
            get
            {
                return timerFrequency;
            }
        }

        /// <summary>
        ///  Constructs a new instance of the HiResTimer object, and checks
        ///  the availability and resolution of the system high resolution
        ///  performance counter.
        /// </summary>
        public HiResTimer()
        {
            // If the installed hardware supports a high-resolution performance counter, 
            // the return value is nonzero.
            // If the function fails, the return value is zero. To get extended error 
            // information, call GetLastError. For example, if the installed hardware 
            // does not support a high-resolution performance counter, the function fails. 
            UnmanagedMethods.LARGE_INTEGER res = new UnmanagedMethods.LARGE_INTEGER();
            UInt32 r = UnmanagedMethods.QueryPerformanceFrequency(ref res);
            if (r != 0)
            {
                hasHiResCounter = true;
                timerFrequency = (float)((res.highpart >> 32) + res.lowpart);
            }
        }
    }

    public class CRC32
    {
        private UInt32[] crc32Table;
        private const int BUFFER_SIZE = 1024;

        /// <summary>
        /// Returns the CRC32 for the specified stream.
        /// </summary>
        /// <param name="stream">The stream to calculate the CRC32 for</param>
        /// <returns>An unsigned integer containing the CRC32 calculation</returns>
        public UInt32 GetCrc32(System.IO.Stream stream)
        {
            unchecked
            {
                UInt32 crc32Result;
                crc32Result = 0xFFFFFFFF;
                byte[] buffer = new byte[BUFFER_SIZE];
                int readSize = BUFFER_SIZE;

                int count = stream.Read(buffer, 0, readSize);
                while (count > 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        crc32Result = ((crc32Result) >> 8) ^ crc32Table[(buffer[i]) ^ ((crc32Result) & 0x000000FF)];
                    }
                    count = stream.Read(buffer, 0, readSize);
                }
                return ~crc32Result;
            }
        }


        public string GetCrc32(string word)
        {
            UInt32 crc32Result = GetCrc32(word, true);
            return String.Format("{0:X8}", crc32Result);
        }


        private UInt32 GetCrc32(string word, bool b)
        {
            unchecked
            {
                UInt32 crc32Result;
                crc32Result = 0xFFFFFFFF;
                byte[] buffer = new byte[BUFFER_SIZE];
                Byte[] hash = System.Text.Encoding.UTF8.GetBytes(word);
                for (int i = 0; i < hash.Length; i++)
                {
                    buffer[i] = hash[i];

                }
                int count = hash.Length; 
                while (count > 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        crc32Result = ((crc32Result) >> 8) ^ crc32Table[(buffer[i]) ^ ((crc32Result) & 0x000000FF)];
                    }
                    count = 0;
                }
                return ~crc32Result;
            }
        }

        public string GetCrc32(byte[] hash)
        {
            unchecked
            {
                UInt32 crc32Result;
                crc32Result = 0xFFFFFFFF;
                byte[] buffer = new byte[BUFFER_SIZE];
                for (int i = 0; i < hash.Length; i++)
                {
                    buffer[i] = hash[i];

                }
                int count = hash.Length;
                while (count > 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        crc32Result = ((crc32Result) >> 8) ^ crc32Table[(buffer[i]) ^ ((crc32Result) & 0x000000FF)];
                    }
                    count = 0;
                }
                UInt32 _crcRestult = ~crc32Result;
                return String.Format("{0:X8}", _crcRestult);
            }
        }


        /// <summary>
        /// Construct an instance of the CRC32 class, pre-initialising the table
        /// for speed of lookup.
        /// </summary>
        public CRC32()
        {
            unchecked
            {
                // This is the official polynomial used by CRC32 in PKZip.
                // Often the polynomial is shown reversed as 0x04C11DB7.
                UInt32 dwPolynomial = 0xEDB88320;
                UInt32 i, j;

                crc32Table = new UInt32[256];

                UInt32 dwCrc;
                for (i = 0; i < 256; i++)
                {
                    dwCrc = i;
                    for (j = 8; j > 0; j--)
                    {
                        if ((dwCrc & 1) == 1)
                        {
                            dwCrc = (dwCrc >> 1) ^ dwPolynomial;
                        }
                        else
                        {
                            dwCrc >>= 1;
                        }
                    }
                    crc32Table[i] = dwCrc;
                }
            }
        }
    }

    class LinerAlgebera
    {

        public double[,] Muilt2Dim(double[,] MatrixA, double[,] MatrixB)
        {
            double[,] MatrixC = new double[MatrixA.GetLength(0), MatrixB.GetLength(1)];
            double sum = 0;
            for (int i = 0; i < MatrixA.GetLength(0); i++)
            {
                for (int j = 0; j < MatrixB.GetLength(1); j++)
                {
                    sum = 0;
                    for (int r = 0; r < MatrixA.GetLength(1); r++)
                    {
                        sum += MatrixA[i, r] * MatrixB[r, j];
                    }
                    MatrixC[i, j] = sum;
                }
            }

            return MatrixC;

        }

        public void MuiltNumberByDim(double[,] Martrix, double num)
        {

            for (int i = 0; i < Martrix.GetLength(0); i++)
            {
                for (int j = 0; j < Martrix.GetLength(1); j++)
                {
                    Martrix[i, j] = num * Martrix[i, j];
                }
            }

        }

        public double[,] Invers2DimMatrix(double[,] basicMatirx)
        {
            double[,] matrix = new double[2, 2];
            matrix[0, 0] = basicMatirx[1, 1];
            matrix[0, 1] = -basicMatirx[0, 1];
            matrix[1, 0] = -basicMatirx[1, 0];
            matrix[1, 1] = basicMatirx[0, 0];
            double detMatrix = DetMatrix2Dim(matrix);
            MuiltNumberByDim(matrix, (1 / detMatrix));
            return matrix;
        }

        public double[,] CoFactorMatrix(double[,] m)
        {
            int step = 1;
            int rowCount = m.GetLength(0);
            double[,] coFactor = new double[rowCount, rowCount];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(0); j++)
                {
                    double[,] mm = SubMatrix(m, i, j);
                    double detValue = DetMatrix2Dim(mm);
                    coFactor[i, j] = Exp(-1, i + j + 2) * detValue;

                    //Console.WriteLine("---------------------------- matrix number: {0}", step);
                    //obj.Print2Dim(mm);
                    //Console.WriteLine("\n------------------------------------\n");
                    step++;
                }
            }
            return coFactor;
        }

        public double[,] SubMatrix(double[,] MainMatrix, int rowIndx, int colIndx)
        {
            int lengthMain = MainMatrix.GetLength(0);
            int lengthSub = lengthMain - 1;
            double[,] subMatirx = new double[lengthSub, lengthSub];
            string strMatrixElem = null;

            int index = 0;

            for (int i = 0; i < lengthMain; i++)
            {
                for (int j = 0; j < lengthMain; j++)
                {
                    if (i != rowIndx && j != colIndx)
                    {
                        strMatrixElem += MainMatrix[i, j] + ",";
                    }
                }
            }
            strMatrixElem = strMatrixElem.Remove(strMatrixElem.Length - 1);
            string[] elmentsValue = strMatrixElem.Split(',');
            for (int i = 0; i < lengthSub; i++)
            {
                for (int j = 0; j < lengthSub; j++)
                {
                    subMatirx[i, j] = Convert.ToInt32(elmentsValue[index]);
                    index++;
                }

            }
            return subMatirx;
        }

        public double[,] TransposeMatrix(double[,] matrix)
        {
            int rowsCount = matrix.GetLength(0);
            double[,] Tmatrix = new double[rowsCount, rowsCount];

            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < rowsCount; j++)
                {
                    Tmatrix[i, j] = matrix[j, i];
                }
            }


            return Tmatrix;
        }

        public double DetMatrix2Dim(double[,] matrix)
        {
            double detMatrix = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            return detMatrix;
        }

        public double DetMatrix3Dim(double[,] matrix)
        {
            double detMatrix = 0;
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                double[,] mm = SubMatrix(matrix, 0, j);
                double detValue = DetMatrix2Dim(mm);
                detValue *= Exp(-1, j + 2) * matrix[0, j];
                detMatrix += detValue;
            }
            return detMatrix;
        }

        public double Exp(int _base, int e)
        {
            if (e == 1)
            {
                return _base;
            }
            else
            {
                return _base * Exp(_base, --e);
            }

        }

        public int MaxNumberElements(double number)
        {
            int element = 0;
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    element = i;
                }

            }
            return element;
        }

        public double[,] IdentityMatrix(int Order)
        {
            double[,] In = new double[Order, Order];

            for (int rowIndx = 0; rowIndx < Order; rowIndx++)
            {
                for (int colIndx = 0; colIndx < Order; colIndx++)
                {
                    if (colIndx == rowIndx)
                    {
                        In[rowIndx, colIndx] = 1;
                    }
                    else
                    {
                        In[rowIndx, colIndx] = 0;
                    }
                }
            }
            return In;
        }

        public double[,] PMatrix(int Order)
        {
            double[,] Pn = new double[Order + 1, Order + 1];

            double[,] In = IdentityMatrix(Order);

            for (int rowIndx = 0; rowIndx < Order + 1; rowIndx++)
            {
                for (int colIndx = 0; colIndx < Order + 1; colIndx++)
                {
                    if ((rowIndx == 0 & colIndx == 0) || (rowIndx == Order & colIndx == 0))
                    {
                        Pn[rowIndx, colIndx] = 1;
                    }
                    else if ((rowIndx != 0 & colIndx == 0) || (rowIndx == Order & colIndx != 0))
                    {
                        Pn[rowIndx, colIndx] = 0;
                    }
                    else
                    {
                        Pn[rowIndx, colIndx] = In[rowIndx, colIndx - 1];
                    }
                }
            }
            return Pn;
        }








    }

    class FibonaceNumber
    {
        public double Fibonnace(int index)
        {
            double F = 0;
            if (index == 0)
            {
                F = 0;
            }
            else if (index == 1 || index == 2)
            {
                F = 1;
            }
            else if (index > 2)
            {
                F = Fibonnace(index - 1) + Fibonnace(index - 2);
            }

            return F;


        }

        public double[,] FibonnaceQ(int n)
        {
            double[,] fMatrix = new double[2, 2];
            fMatrix[0, 0] = Fibonnace(n + 1);
            fMatrix[0, 1] = Fibonnace(n);
            fMatrix[1, 0] = Fibonnace(n);
            fMatrix[1, 1] = Fibonnace(n - 1);


            return fMatrix;
        }

        public double[,] FibonnaceMinQ(int n)
        {
            Console.WriteLine("Q-Matrix of {0} is ", -n);
            double[,] fMatrix = new double[2, 2];
            int ExpOneOfN = 1;
            if ((n % 2) == 0)
            {
                ExpOneOfN = 1;
            }
            else
            {
                ExpOneOfN = -1;
            }
            fMatrix[0, 0] = Fibonnace(n - 1) / ExpOneOfN;
            fMatrix[0, 1] = -1 * Fibonnace(n) / ExpOneOfN;
            fMatrix[1, 0] = -1 * Fibonnace(n) / ExpOneOfN;
            fMatrix[1, 1] = Fibonnace(n + 1) / ExpOneOfN;
            return fMatrix;


        }
    }

    class GCCryptography
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytPlain"></param>
        /// <param name="fibonnacOrder"></param>
        /// <returns></returns>
        public byte[] GCEncrypt(byte[] bytPlain, int fibonnacOrder)
        {
            List<byte> ChipherText = new List<byte>();     //List Of Byte
            LinerAlgebera objLinerAlgebera = new LinerAlgebera();
            FibonaceNumber objFibonacci = new FibonaceNumber();



            double[,] FMatrix = objFibonacci.FibonnaceQ(fibonnacOrder);   //  Create Key Matrix from Fibonnace


            double[,] keyMatrix = objFibonacci.FibonnaceQ(fibonnacOrder);   //  Create Key Matrix from Fibonnace

            double[,] PainTextMatrix = new double[2, 2];   //  Convert plaintext to bolcks in 2x2 matrix





            for (int arrIndx = 0; arrIndx < bytPlain.Length; )
            {
                for (int j = 0; j < PainTextMatrix.GetLength(0); j++)
                {
                    for (int k = 0; k < PainTextMatrix.GetLength(0); k++)
                    {
                        if (arrIndx < bytPlain.Length)
                        {
                            PainTextMatrix[j, k] = Convert.ToDouble(bytPlain[arrIndx]);
                            arrIndx++;
                        }
                        else
                        {
                            PainTextMatrix[j, k] = 0;
                        }

                    }
                }

                double[,] cipherMatrix = objLinerAlgebera.Muilt2Dim(PainTextMatrix, keyMatrix);





                // convert every item to array of binary 
                for (int K = 0; K < cipherMatrix.GetLength(0); K++)
                {
                    for (int j = 0; j < cipherMatrix.GetLength(0); j++)
                    {
                        byte[] array = BitConverter.GetBytes(cipherMatrix[K, j]);
                        foreach (byte element in array)
                        {
                            ChipherText.Add(element);
                        }
                    }
                }

            }

            return ChipherText.ToArray();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytCipher"></param>
        /// <param name="fibonnacOrder"></param>
        /// <returns></returns>
        public byte[] GCDecrypt(byte[] bytCipher, int fibonnacOrder)
        {
            List<byte> PlainText = new List<byte>(); //List Of Byte
            LinerAlgebera objLinerAlgebera = new LinerAlgebera();
            FibonaceNumber objFibonacci = new FibonaceNumber();


            double[,] FMatrix = objFibonacci.FibonnaceQ(fibonnacOrder);   //  Create Key Matrix from Fibonnace

            double[,] keyMatrix = objFibonacci.FibonnaceQ(fibonnacOrder);   //  Create Key Matrix from Fibonnace

            keyMatrix = objLinerAlgebera.Invers2DimMatrix(keyMatrix); // calc inverse

            double[,] CipherTextMatrix = new double[2, 2];
            int indexer = 0;
            for (int arrIndx = 0; arrIndx < bytCipher.Length / 8; )
            {
                for (int j = 0; j < CipherTextMatrix.GetLength(0); j++)
                {
                    for (int k = 0; k < CipherTextMatrix.GetLength(0); k++)
                    {
                        if (indexer < bytCipher.Length)
                        {
                            CipherTextMatrix[j, k] = BitConverter.ToDouble(bytCipher, indexer);
                            arrIndx++;
                            indexer += 8;
                        }

                        else
                        {
                            int c = arrIndx;
                        }


                    }

                }
                double[,] PlainMatrix = objLinerAlgebera.Muilt2Dim(CipherTextMatrix, keyMatrix);
                for (int K = 0; K < PlainMatrix.GetLength(0); K++)
                {
                    for (int j = 0; j < PlainMatrix.GetLength(0); j++)
                    {
                        if (Convert.ToInt32(PlainMatrix[K, j]) == 0)
                        {
                            break;
                        }
                        else
                        {
                            PlainText.Add(Convert.ToByte(PlainMatrix[K, j]));
                        }
                    }
                }
            }
            return PlainText.ToArray();
        }





    }

    class clsPermutation
    {
        private int miElementLevel = -1;
        private int miNumberOfElements;
        private int miPermutationCount = 0;
        private int[] miPermutationValue = new int[0];
        private char[] mchrInputSet;
        private string mstrPermutationWord;

        /// <summary>
        /// get and set Permuation word
        /// </summary>
        public string PermutationWord
        {
            get
            {
                return mstrPermutationWord;
            }
            set
            {
                mstrPermutationWord = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public char[] InputSet
        {
            get
            {
                return mchrInputSet;
            }
            set
            {
                mchrInputSet = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public int PermutationCount
        {
            get
            {
                return miPermutationCount;
            }
            set
            {
                miPermutationCount = value;
            }
        }

        //Resize permutationValue array : count of permutationValue items is zero, we want resize it items ;
        public char[] MakeCharArray(string InputString)
        {
            char[] charString = InputString.ToCharArray();
            Array.Resize(ref miPermutationValue, charString.Length);
            miNumberOfElements = charString.Length;
            return charString;
        }


        /// <summary>
        /// Recursive Algorithm Source:
        /// A. Bogomolny, Counting And Listing All Permutations from Interactive Mathematics Miscellany and Puzzles
        /// http://www.cut-the-knot.org/do_you_know/AllPerm.shtml, Accessed 11 June 2009
        /// </summary>
        /// <param name="k"></param>
        public void Recursion(int k, int PermutationNumber)
        {

            miElementLevel++;

            // set item in array
            miPermutationValue.SetValue(miElementLevel, k);

            if (miElementLevel == miNumberOfElements)
            {
                PermutationWord = OutputPermutation(miPermutationValue, PermutationNumber);
            }
            else
            {
                for (int i = 0; i < miNumberOfElements; i++)
                {
                    int goout = 0;
                    if (miPermutationValue[i] == 0)
                    {
                        Recursion(i, PermutationNumber);
                        goout++;
                    }
                }
            }
            miElementLevel--;
            if (PermutationCount == PermutationNumber)
            {

                return;
            }
            miPermutationValue.SetValue(0, k);
        }

        /// <summary>
        /// Code Source (AddItem()):
        /// A. Bogomolny, Counting And Listing All Permutations from Interactive Mathematics Miscellany and Puzzles
        /// http://www.cut-the-knot.org/do_you_know/AllPerm.shtml, Accessed 11 June 2009
        /// </summary>
        /// <param name="value"></param>
        private string OutputPermutation(int[] value, int order)
        {
            string lstrPerm = string.Empty;
            if (PermutationCount == order - 1)
            {
                foreach (int i in value)
                {
                    lstrPerm += mchrInputSet.GetValue(i - 1).ToString();
                }
            }
            PermutationCount++;
            return lstrPerm;
        }

        public string RestorePerumtation(string word, int PermutationNumber)
        {

            // Create position of string which that will compare with permuation word
            // ( o,1,2,3,4,.. ) to Length of word
            string lstrPositionItmes = string.Empty;
            for (int i = 0; i < word.Length; i++)
            {
                lstrPositionItmes += i;
            }


            InputSet = MakeCharArray(lstrPositionItmes);
            Recursion(0, PermutationNumber);
            lstrPositionItmes = PermutationWord;  // new item position after permutation



            char[] lchrWord = new char[word.Length];
            //compare between word and permuation item position
            for (int i = 0; i < word.Length; i++)
            {
                int k = Convert.ToInt32(lstrPositionItmes[i].ToString());
                lchrWord[k] = word[i];
            }

            // retrun restore word 
            return new string(lchrWord);
        }






    }

  public  class WriteInFile
    {
        public void Write(string fileName, byte[] Encrpty)
        {

            try
            {
                FileStream fs;
                if (File.Exists(fileName))
                {
                    fs = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
                }
                else
                {
                    fs = new FileStream(fileName, FileMode.Create);
                }
                fs.Write(Encrpty, 0, Encrpty.Length);
                fs.Flush();  //Clears all buffers
                fs.Close();
                fs.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Write(string fileName, string text)
        {

            try
            {
                StreamWriter sw;
                if (File.Exists(fileName))
                {
                    sw = new StreamWriter(fileName);
                }
                else
                {
                    File.Create(fileName).Dispose();
                    sw = new StreamWriter(fileName);
                }
                sw.WriteLine(text);
                sw.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
