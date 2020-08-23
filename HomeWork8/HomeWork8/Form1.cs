using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork8
{
    public partial class Form1 : Form
    {
        MethodInfo[] mi;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            mi = dt.GetType().GetMethods();
            for (int i = 0; i < mi.Length; i++)
            {
               txtBoxDT.Text += mi[i].Name + "  \n";
            }
            txtBox.Text = mi[0].Name;

        }

        private void UpDown_ValueChanged(object sender, EventArgs e)
        {
            txtBox.Text = mi[(int)UpDown.Value].Name;
        }
    }
}
