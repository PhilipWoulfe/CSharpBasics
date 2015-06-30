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

        // button 1 click
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ClickBut(sender, 1);
            
        }

        // button 2 click
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ClickBut(sender, 2);
        }

        // button 3 click
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            ClickBut(sender, 3);
        }

        // button 4 click
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            ClickBut(sender, 4);
        }

        // button 5 click
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            ClickBut(sender, 5);
        }

        // button 6 click
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            ClickBut(sender, 6);
        }

        // button 7 click
        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            ClickBut(sender, 7);
        }

        // button 8 click
        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            ClickBut(sender, 8);
        }

        // button 9 click
        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            ClickBut(sender, 9);
        }

        // button 10 click
        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            ClickBut(sender, 10);
        }

        // button 11 click
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            ClickBut(sender, 11);
        }

        // button 12 click
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            ClickBut(sender, 12);
        }

       
        // What to do if a button is clicked method
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

        // Check if button text is a number or letter
        private static bool IsNumeric(object Expression)
        {
            double retNum;

            bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }
    }
}
