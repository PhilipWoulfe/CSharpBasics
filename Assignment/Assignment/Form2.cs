using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ClickBut(sender, 1);
            
        }
        
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ClickBut(sender, 2);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            ClickBut(sender, 3);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            ClickBut(sender, 4);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            ClickBut(sender, 5);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            ClickBut(sender, 6);
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            ClickBut(sender, 7);
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            ClickBut(sender, 8);
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            ClickBut(sender, 9);
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            ClickBut(sender, 10);
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            ClickBut(sender, 11);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            ClickBut(sender, 12);
        }

       
        
        private void ClickBut(object o, int i)
        {
            CheckBox b = (CheckBox)o;

           
            
            if (IsNumeric(b.Text))
            {
                b.Text = "B";
                b.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                b.Text = i.ToString();
                b.BackColor = System.Drawing.Color.Gray;
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
