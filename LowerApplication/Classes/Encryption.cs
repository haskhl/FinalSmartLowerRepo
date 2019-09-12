using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace EasyStore.Classes
{
    public class Encryption
    {

        // - - - - - - - - - - - - - - - - Hashing Methods
        public static byte[] HashEncryption(string PlanText)
        {

            //Create an instance of the MD5 provider.
            MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider();

            //Hash word.
            byte[] CipherText = provider.ComputeHash(Encoding.Default.GetBytes(PlanText));

            return CipherText;
        }

        
        public static bool CompareEncryption(byte[] Encrypt1, byte[] Encrypt2)
        {
            bool bolFlage = true;
            if (Encrypt1.Length != Encrypt2.Length)
            {
                return false;
            }
            for (int i = 0; i < Encrypt1.Length; i++)
            {
                if (Encrypt1[i] != Encrypt2[i])
                {
                    bolFlage = false;
                    break;
                }
            }
            return bolFlage;
        }
    }
}
