using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevComponents.DotNetBar;


namespace EasyStore.Classes
{
  public  class ErrorsManager
    {

        public static bool AddNewError(string ClassName, string EventName, Exception ex)
        {
            bool lbolFalg = false;
            //InsertError(ClassName, EventName, ex);

            if (ex is SqlException)
            {
                lbolFalg = ErrorReason(ex);
            }
            else
            {
                MessagesManager.CallSystenAdmin();

            }
            return lbolFalg;
        }

        private static bool ErrorReason(Exception ex)
        {
            bool lbolFalg = false;
            SqlException sqlException = (SqlException)ex;
            if (sqlException.Number == -1)
            {
                MessagesManager.ConnectionFailed();
                lbolFalg = true;
            }
            else if (sqlException.Number == 547)
            {
                MessagesManager.DeleteFailed();
                lbolFalg = true;
            }
            else if (sqlException.Number == 2601)
            {
                MessagesManager.PreExisting();
                lbolFalg = true;
            }
            else if (sqlException.Number == 2627)
            {
                MessagesManager.PreExisting();
                lbolFalg = true;
            }
            else
            {
                MessagesManager.CallSystenAdmin();
                lbolFalg = false;
            }
            return lbolFalg;
        }

        //private static void InsertError(string ClassName, string EventName, Exception ex)
        //{
        //    try
        //    {
        //        ErrorsEntity ErrorData = new ErrorsEntity();
        //        ErrorData.ClassName = ClassName;
        //        ErrorData.EventName = EventName;
        //        ErrorData.ErrorMessage = ex.Message;
        //        ErrorData.ErrorLine = ex.StackTrace.Substring(ex.StackTrace.Length - 3);
        //        ErrorData.ErrorDate = DateTime.Now;
        //        if (ex is SqlException)
        //        {
        //            SqlException sqlException = (SqlException)ex;
        //            ErrorData.ErrorNumber = Convert.ToInt16(sqlException.Number);
        //        }
        //        else
        //        {
        //            ErrorData.ErrorNumber = 1;
        //        }
        //        ErrorsDB.AddNewErrorr(ErrorData);
        //    }
        //    catch (Exception ex2)
        //    {
        //        MessagesManager.Error(ex2.Message);
        //    }
        //}
    }
}
