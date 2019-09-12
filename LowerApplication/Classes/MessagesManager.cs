using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.Globalization;

namespace EasyStore.Classes
{
    class MessagesManager
    {
        private static string mstrArabicCultureName = "ar-EG";
        private static string mstrEnglishCultureName = "en-US";

        /// <summary>
        /// Show a success message if add completed
        /// </summary>
        public static void AddCompletedSuccessfully()
        {
            if (Thread.CurrentThread.CurrentUICulture.Name == mstrArabicCultureName)
            {
                MessageBoxEx.Show("تم الإضافة  بنجاح", "نجـــــــاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Thread.CurrentThread.CurrentUICulture.Name == mstrEnglishCultureName)
            {
                MessageBoxEx.Show("Add succeeded", "S U C C E S S", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        /// <summary>
        /// Show an error message if add failed
        /// </summary>
        public static void AddFailed()
        {
            if (Thread.CurrentThread.CurrentUICulture.Name == mstrArabicCultureName)
            {
                MessageBoxEx.Show("Error in addition", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Thread.CurrentThread.CurrentUICulture.Name == mstrEnglishCultureName)
            {
                MessageBoxEx.Show("Error in addition", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Show a success message if update completed
        /// </summary>
        public static void UpdateCompletedSuccessfully()
        {
            if (Thread.CurrentThread.CurrentUICulture.Name == mstrArabicCultureName)
            {
                MessageBoxEx.Show("تم التحديث بنجاح", "نجـــــــاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Thread.CurrentThread.CurrentUICulture.Name == mstrEnglishCultureName)
            {
                MessageBoxEx.Show("Update succeeded", "S U C C E S S", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Show an error message if update failed
        /// </summary>
        public static void UpdateFailed()
        {
            if (Thread.CurrentThread.CurrentUICulture.Name == mstrArabicCultureName)
            {
                MessageBoxEx.Show("خطأ في التحديث", "خـــطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Thread.CurrentThread.CurrentUICulture.Name == mstrEnglishCultureName)
            {
                MessageBoxEx.Show("Error in updating", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Show assurance message before delete
        /// </summary>
        /// <returns>
        /// returns true if the user clicked YES else returns false
        /// </returns>
        public static bool SaveAssurance()
        {

            bool lbool_Result = false;
            if (Thread.CurrentThread.CurrentUICulture.Name == mstrArabicCultureName)
            {
                if (MessageBoxEx.Show("هل تريد حفظ التغييرات", "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    lbool_Result = true;
                }
            }
            else if (Thread.CurrentThread.CurrentUICulture.Name == mstrEnglishCultureName)
            {
                if (MessageBoxEx.Show("هل تريد حفظ التغييرات", "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    lbool_Result = true;
                }
            }
            return lbool_Result;
        }

        /// <summary>
        /// Show assurance message before delete
        /// </summary>
        /// <returns>
        /// returns true if the user clicked YES else returns false
        /// </returns>
        public static bool RejectAssurance()
        {

            bool lbool_Result = false;
            if (Thread.CurrentThread.CurrentUICulture.Name == mstrArabicCultureName)
            {
                if (MessageBoxEx.Show("هل تريد التراجع عن كل التغييرات", "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    lbool_Result = true;
                }
            }
            else if (Thread.CurrentThread.CurrentUICulture.Name == mstrEnglishCultureName)
            {
                if (MessageBoxEx.Show("هل تريد حفظ التغييرات", "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    lbool_Result = true;
                }
            }
            return lbool_Result;
        }

        /// <summary>
        /// Show assurance message before delete
        /// </summary>
        /// <returns>
        /// returns true if the user clicked YES else returns false
        /// </returns>
        public static bool DeleteAssurance()
        {

            bool lbool_Result = false;
            if (Thread.CurrentThread.CurrentUICulture.Name == mstrArabicCultureName)
            {
                if (MessageBoxEx.Show("هل تريد الحذف ؟ ", "تنــــبــيــه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    lbool_Result = true;
                }
            }
            else if (Thread.CurrentThread.CurrentUICulture.Name == mstrEnglishCultureName)
            {
                if (MessageBoxEx.Show("Are you sure to delete ?", "A T T E N T I O N", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    lbool_Result = true;
                }
            }
            return lbool_Result;
        }

        /// <summary>
        /// Show a success message if delete completed
        /// </summary>
        public static void DeleteCompletedSuccessfully()
        {
            if (Thread.CurrentThread.CurrentUICulture.Name == mstrArabicCultureName)
            {
                MessageBoxEx.Show("تم الحذف بنجاح", "نـجــــــاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Thread.CurrentThread.CurrentUICulture.Name == mstrEnglishCultureName)
            {
                MessageBoxEx.Show("Delete succeeded", "S U C C E S S", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Show an error message if delete failed
        /// </summary>
        public static void DeleteFailed()
        {
            if (Thread.CurrentThread.CurrentUICulture.Name == mstrArabicCultureName)
            {
                MessageBoxEx.Show("لا يمكن حذف هذه القمية, لانها مرتبطة بقيم اخري", "خـــــــطــأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Thread.CurrentThread.CurrentUICulture.Name == mstrEnglishCultureName)
            {
                MessageBoxEx.Show("Can't delete this value ,its reference to another values", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Show exception message from the passed Exception object
        /// </summary>
        /// <param name="ex">
        /// Exception object to show its message
        /// </param>
        public static void ExceptionMessage(Exception ex)
        {
            MessageBoxEx.Show(ex.Message, "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Show exception message from the passed Exception object
        /// </summary>
        /// <param name="ex">
        /// Exception object to show its message
        /// </param>
        public static void ExceptionMessage(SqlException ex)
        {
            if (ex.Number == -1)
            {
                MessageBoxEx.Show("Sorry ! Server not found, try again later.", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ex.Number == 2627)
            {
                MessageBoxEx.Show("Sorry ! This ID is already exist, use another one.", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBoxEx.Show(ex.Message, "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static void PreExisting()
        {
            if (Thread.CurrentThread.CurrentUICulture.Name == mstrArabicCultureName)
            {
                MessageBoxEx.Show("هذه القيمة مستخدمة من قبل", "خـــطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Thread.CurrentThread.CurrentUICulture.Name == mstrEnglishCultureName)
            {
                MessageBoxEx.Show("This value is pre-existing", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static void SelectFirst()
        {
            if (Thread.CurrentThread.CurrentUICulture.Name == mstrArabicCultureName)
            {
                MessageBoxEx.Show("أختار أولا", "خـــطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Thread.CurrentThread.CurrentUICulture.Name == mstrEnglishCultureName)
            {
                MessageBoxEx.Show("Please select first", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public static void Information(string message)
        {
            MessageBoxEx.Show(message, "I N F O", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public static void Error(string message)
        {
            MessageBox.Show(message, "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 
        /// </summary>
        public static void InvalidDate()
        {
            MessageBoxEx.Show("Invalid Date", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }       

        /// <summary>
        /// 
        /// </summary>
        public static void WrongPassword()
        {
            if (Thread.CurrentThread.CurrentUICulture.Name == mstrArabicCultureName)
            {
                MessageBoxEx.Show("كلمة المرور غير صحيحة", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Thread.CurrentThread.CurrentUICulture.Name == mstrEnglishCultureName)
            {
                MessageBoxEx.Show("You have entered wrong password", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static void UserNotFound()
        {
            if (Thread.CurrentThread.CurrentUICulture.Name == mstrArabicCultureName)
            {
                MessageBoxEx.Show("لايوجد مستخدم بهذا الأســـم", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Thread.CurrentThread.CurrentUICulture.Name == mstrEnglishCultureName)
            {
                MessageBoxEx.Show("This user not found", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static void PassworNotMatch()
        {
            if (Thread.CurrentThread.CurrentUICulture.Name == mstrArabicCultureName)
            {
                MessageBoxEx.Show("كلمتي المرور غير متطابقتين", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Thread.CurrentThread.CurrentUICulture.Name == mstrEnglishCultureName)
            {
                MessageBoxEx.Show("The password not match", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static void NoResult()
        {
            if (Thread.CurrentThread.CurrentUICulture.Name == mstrArabicCultureName)
            {
                MessageBoxEx.Show("لا يوجد قيمة", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Thread.CurrentThread.CurrentUICulture.Name == mstrEnglishCultureName)
            {
                MessageBoxEx.Show("There is no results", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static void FillCurrentRow()
        {
            if (Thread.CurrentThread.CurrentUICulture.Name == mstrArabicCultureName)
            {
                MessageBoxEx.Show("لأبد من استكمال بيانات الحقل الحالي", "خطــأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Thread.CurrentThread.CurrentUICulture.Name == mstrEnglishCultureName)
            {
                MessageBoxEx.Show("Plz fill current row", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static void FillGrdDetails()
        {
            if (Thread.CurrentThread.CurrentUICulture.Name == mstrArabicCultureName)
            {
                MessageBoxEx.Show("لأبد من وجود صنف واحد على الاقل   ", "خطــأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Thread.CurrentThread.CurrentUICulture.Name == mstrEnglishCultureName)
            {
                MessageBoxEx.Show("Plz fill current row", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static void FillEmpList()
        {
            if (Thread.CurrentThread.CurrentUICulture.Name == mstrArabicCultureName)
            {
                MessageBoxEx.Show("لأبد من وجود موظف واحد على الاقل في لجنة الفحص ", "خطــأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Thread.CurrentThread.CurrentUICulture.Name == mstrEnglishCultureName)
            {
                MessageBoxEx.Show("Plz fill current row", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Show a success message if Connection Success  
        /// </summary>
        public static void ConnectionSuccessfully()
        {
            if (Thread.CurrentThread.CurrentUICulture.Name == mstrArabicCultureName)
            {
                MessageBox.Show("نجاح عملية الأتصال بقاعدة البيانات", "S U C C E S S", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Thread.CurrentThread.CurrentUICulture.Name == mstrEnglishCultureName)
            {
                MessageBox.Show("Connection succeeded", "S U C C E S S", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void ConnectionFailed()
        {
            if (Thread.CurrentThread.CurrentUICulture.Name == mstrArabicCultureName)
            {
                MessageBoxEx.Show("!فشل الإتصال بقاعدة البيانات", "تنبيــه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else if (Thread.CurrentThread.CurrentUICulture.Name == mstrEnglishCultureName)
            {
                MessageBoxEx.Show("!فشل الإتصال بقاعدة البيانات", "تنبيــه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        public static void CallSystenAdmin()
        {
            if (Thread.CurrentThread.CurrentUICulture.Name == mstrArabicCultureName)
            {
                MessageBoxEx.Show("من فضلك يرجى الأتصال مدير البرنامج", "خطــأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Thread.CurrentThread.CurrentUICulture.Name == mstrEnglishCultureName)
            {
                MessageBoxEx.Show("Please call system admin", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static void ServerNotFound()
        {
            if (Thread.CurrentThread.CurrentUICulture.Name == mstrArabicCultureName)
            {
                MessageBoxEx.Show("الخادم غير موجود", "خــطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Thread.CurrentThread.CurrentUICulture.Name == mstrEnglishCultureName)
            {
                MessageBoxEx.Show("You have entered wrong password", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //License

        public static void SetLicenseSuccess()
        {
            if (Thread.CurrentThread.CurrentUICulture.Name == mstrArabicCultureName)
            {
                MessageBoxEx.Show("نجاح عملية تسجيل البرنامج", "نجــاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Thread.CurrentThread.CurrentUICulture.Name == mstrEnglishCultureName)
            {
                MessageBoxEx.Show("نجاح عملية تسجيل البرنامج", "نجــاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public static void SetLicenseFailed()
        {
            if (Thread.CurrentThread.CurrentUICulture.Name == mstrArabicCultureName)
            {
                MessageBoxEx.Show("الرخصــة غير صحيحة", "خطــأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Thread.CurrentThread.CurrentUICulture.Name == mstrEnglishCultureName)
            {
                MessageBoxEx.Show("الرخصــة غير صحيحة", "خطــأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        /// <summary>
        /// Show assurance message before  LogOut
        /// </summary>
        /// <returns>
        /// returns true if the user clicked YES else returns false
        /// </returns>
        public static bool LogOutAssurance()
        {

            bool lbool_Result = false;
            if (Thread.CurrentThread.CurrentUICulture.Name == mstrArabicCultureName)
            {
                if (MessageBoxEx.Show("هل تريد الخروج من البرنامج", "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    lbool_Result = true;
                }
            }
            else if (Thread.CurrentThread.CurrentUICulture.Name == mstrEnglishCultureName)
            {
                if (MessageBoxEx.Show("Are you sure to logout ?", "A T T E N T I O N", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    lbool_Result = true;
                }
            }
            return lbool_Result;
        }

        /// <summary>
        /// Show assurance message before  LogOut
        /// </summary>
        /// <returns>
        /// returns true if the user clicked YES else returns false
        /// </returns>
        public static void LogOutWarning()
        {
            if (Thread.CurrentThread.CurrentUICulture.Name == mstrArabicCultureName)
            {
                
                MessageBoxEx.Show("عفوا لا يوجد اي مستخدم ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else if (Thread.CurrentThread.CurrentUICulture.Name == mstrEnglishCultureName)
            {
                MessageBoxEx.Show("Are you sure to logout ?", "A T T E N T I O N", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            
        }

        /// <summary>
        /// Show assurance message before  LogOut
        /// </summary>
        /// <returns>
        /// returns true if the user clicked YES else returns false
        /// </returns>
        public static bool LogInAssurance()
        {

            bool lbool_Result = false;
            if (Thread.CurrentThread.CurrentUICulture.Name == mstrArabicCultureName)
            {
                if (MessageBoxEx.Show("هل تريد تسجيل الدخول للبرنامج", "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    lbool_Result = true;
                }
            }
            else if (Thread.CurrentThread.CurrentUICulture.Name == mstrEnglishCultureName)
            {
                if (MessageBoxEx.Show("Are you sure to logout ?", "A T T E N T I O N", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    lbool_Result = true;
                }
            }
            return lbool_Result;
        }



        public static void LogInWarning()
        {
            if (Thread.CurrentThread.CurrentUICulture.Name == mstrArabicCultureName)
            {
                MessageBoxEx.Show("عفوا لايمكنك الدخول يوجد مستخدم حاليا", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (Thread.CurrentThread.CurrentUICulture.Name == mstrEnglishCultureName)
            {
                MessageBoxEx.Show("Are you sure to logout ?", "A T T E N T I O N", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        
    }
}
