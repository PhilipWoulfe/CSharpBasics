using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    class NewCheck:CheckBox
    {
        bool check = false;

        public void CheckChanged(object sender, EventArgs e)
        {
            CheckBox b = (CheckBox)sender;

            if (IsNumeric(b.Text))
            {
                b.Text = "F";
            }
            else
            {
                b.Text = "B";
            }
        }

        private static bool IsNumeric(object Expression)
        {
            double retNum;

            bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }
    }
}
