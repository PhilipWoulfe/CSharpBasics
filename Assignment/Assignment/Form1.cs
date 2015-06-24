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
    
    public partial class Form1 : Form
    {

        List<String> dataList = new List<String>();
        int count = 0;
        String[] nameArr = new String[100];
        String[] dateArr = new String[100];
        String[] costArr = new String[100];
        String[] availArr = new String[100];
 

        
        public Form1()
        {
            InitializeComponent();
            listBox1.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String course = textBox1.Text;
            String date = textBox2.Text;
            String price = textBox3.Text;

            if (course != "" && date != "" && price != "")
            {
                if (isValid(date))
                {
                    
                    count = listCount(dataList, course);
                    if (count < 10)
                    {
                        listBox1.Enabled = true;
                        // MessageBox.Show(listBox1.Items.Count.ToString());

                        if (listBox1.Items.Count == 0)
                        {
                            listBox1.Items.Add(course);
                            dataList.Add(course);
                            dataList.Add(date);
                            dataList.Add(price);
                            dataList.Add("FFFFFFFFFF");
                        }
                        else
                        {
                            for (int i = 0; i < listBox1.Items.Count; i++)
                            {
                                // MessageBox.Show(i + "");


                                if (course != listBox1.Items[i].ToString())
                                {
                                    listBox1.Items.Add(course);
                                    dataList.Add(course);
                                    dataList.Add(date);
                                    dataList.Add(price);
                                    dataList.Add("FFFFFFFFFF");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Too many courses of the same name!", "Error");
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Test");
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

        private int listCount(List<String> l, String s)
        {
            foreach(var newvar in l)
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

        
    }
}
