using System;
using System.Collections.Generic;

using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Validator;
using System.Threading;
using DevComponents.Editors.DateTimeAdv;

namespace EasyStore.Classes
{
    public class HighlightControls
    {
        private static string mstrArabicCultureName = "ar-EG";
        private static string mstrEnglishCultureName = "en-US";
        

        public static void IsNumberOnly(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public static void IsPoneNumber(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back || e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public static void SetHighlightError(Highlighter _errorfrmHighlighter, ErrorProvider _errorfrmProvider, object sender, string errorString)
        {
            Control cntr = (Control)sender;
            _errorfrmHighlighter.SetHighlightColor(cntr, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
            string lstrError = SetError(sender, errorString);
            _errorfrmProvider.SetError(cntr, lstrError);
            _errorfrmProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            _errorfrmProvider.BlinkRate = 500;
        }

        public static void ClearHighlightError(Highlighter _errorfrmHighlighter, ErrorProvider _errorfrmProvider, object sender)
        {
            Control cntr = (Control)sender;
            _errorfrmProvider.Clear();
            _errorfrmHighlighter.SetHighlightColor(cntr, DevComponents.DotNetBar.Validator.eHighlightColor.None);

        }

        private static string SetError(object sender, string Error)
        {
            string lstrError = null;
            if (sender is TextBoxX)
            {
                if (Thread.CurrentThread.CurrentUICulture.Name == mstrArabicCultureName)
                {
                    lstrError = "لابد من  إدخال " + Error;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == mstrEnglishCultureName)
                {
                    lstrError = "you must input" + Error;
                }
            }
            else if (sender is ComboBoxEx)
            {
                if (Thread.CurrentThread.CurrentUICulture.Name == mstrArabicCultureName)
                {
                    lstrError = "لابد من أختيار " + Error;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == mstrEnglishCultureName)
                {
                    lstrError = "you must choose" + Error;
                }
            }
            else if (sender is DateTimeInput)
            {
                if (Thread.CurrentThread.CurrentUICulture.Name == mstrArabicCultureName)
                {
                    lstrError = "لابد إلا يتعدي " + Error + "عن تاريخ اليوم";
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == mstrEnglishCultureName)
                {
                    lstrError = "you must choose" + Error;
                }
            }
            else
            {
                lstrError = Error;
            }

            return lstrError;
        }

        public static void HighlightPreExisting(Highlighter _errorfrm, ErrorProvider _errorfrmPro, object sender)
        {
            Control cntr = (Control)sender;
            string lstrError = string.Empty;
            _errorfrm.SetHighlightColor(cntr, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
            if (Thread.CurrentThread.CurrentUICulture.Name == mstrArabicCultureName)
            {
                lstrError = "هذه القيمة  مستخدمة من قبل";
            }
            else if (Thread.CurrentThread.CurrentUICulture.Name == mstrEnglishCultureName)
            {
                lstrError = "This value already exists";
            }
            _errorfrmPro.SetError(cntr, lstrError);
            _errorfrmPro.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            _errorfrmPro.BlinkRate = 500;

        }
    }
}
