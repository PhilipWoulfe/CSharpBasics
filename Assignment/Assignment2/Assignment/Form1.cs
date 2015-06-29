using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Assignment.Course;

namespace Assignment
{
    public partial class Form1 : Form
    {
        List<String> dataList = new List<String>();
        int count = 0;
        Course[,] courseArr = new Course[100, 10];
        int nextCourse = 0;
        int nextDate = 0;

        public Form1()
        {
            InitializeComponent();
            listBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String course = textBox1.Text;
            String date = textBox2.Text;
            String price = textBox3.Text;
            String places = "FFFFFFFFFFFF";

            if (course != "" && date != "" && price != "")
            {
                if (isValid(date))
                {
                    listBox1.Enabled = true;
                    // MessageBox.Show(listBox1.Items.Count.ToString());
                    for (int i = 0; i < courseArr.Length; i++)
                    {
                        for (int j = nextDate; j < 10; j++)
                        {   
                            
                            if (courseArr[i,0] != null & course == courseArr[i, 0].getName())
                            {
                                courseArr[i, j] = new Course(course, date, price, places, i, j);
                            }
                            
                        }
    
                    }
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

        private Boolean isValid(string num)
        {
            int day, month, year;
            day = int.Parse(num.Substring(0, num.IndexOf("/")));
            month = int.Parse(num.Substring(num.IndexOf("/") + 1, num.LastIndexOf("/") - num.IndexOf("/") - 1));
            year = int.Parse(num.Substring(num.LastIndexOf("/") + 1));

            bool valid = false;
            bool isLeap = false;

            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                isLeap = true;
            }

            if (day < 1 || day > 31 || month < 1 || month > 12)
            {
                valid = false;
            }
            else
            {
                if ((month == 4 || month == 6 || month == 9 || month == 11) && day > 30)
                {
                    valid = false;
                }
                else if (month == 2 && isLeap && day > 29)
                {
                    valid = false;
                }
                else if (month == 2 && !isLeap && day > 28)
                {
                    valid = false;
                }
                else
                {
                    valid = true;
                }
            }


            return valid;


        }

        /*
        private Boolean IsTwo(int i)
        {
            if (i == 2)
            {
                return true;
            }
            else
            {
                 
            }
        }
        */
        private int listCount(List<String> l, String s)
        {
            foreach (var newvar in l)
            {
                if (newvar == s)
                {
                    count++;
                }
            }
            MessageBox.Show(count + "");
            return count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var myForm = new Form2();
            //myForm.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                MessageBox.Show(index.ToString());
            }
        }
    }
}
