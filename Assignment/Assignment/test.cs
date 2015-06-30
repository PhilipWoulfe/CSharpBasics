using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment;

namespace Assignment
{
    class test
    {
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            String course = textBox1.Text;
            String date = textBox2.Text;
            String price = textBox3.Text;

            // check text boxes aren't blank
            if (course != "" && date != "" && price != "")
            {
                // check date is valid
                if (isValid(date))
                {
                    // Create new course object and add to arrya                 
                }
                else
                {
                    MessageBox.Show("Invalid Date.", "Error");
                }                
            }
            else
            {
                MessageBox.Show("Error, input missing", "Error Message!");
            }
        }
    }
}
