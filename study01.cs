using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyAddressBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Plus1();
        }

        int Plus1()
        {
            int val = 0;

            for (int i = 0; i < 50; i++)
            {
              
                val = val + i;
            }

            return val;
        }
    }
}
