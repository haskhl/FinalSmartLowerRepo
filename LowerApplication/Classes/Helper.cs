using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowerApplication.Classes
{
    public class Helper
    {
        public static void SetComboBox(ComboBoxEx cbx, string valuemem, string displaymem, List<object> ds)
        {
            if(cbx != null && ds !=null)
            {
                cbx.DataSource = ds;
                cbx.ValueMember = valuemem;
                cbx.DisplayMember = displaymem;
            }
        }
    }
}
