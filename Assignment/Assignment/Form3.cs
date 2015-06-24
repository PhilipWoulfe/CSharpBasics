using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment;

namespace Assignment
{
    public partial class Form3 : Form
    {
        NewCheck newCheck1;

        public Form3()
        {
            InitializeComponent();
            newCheck1 = new NewCheck();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
