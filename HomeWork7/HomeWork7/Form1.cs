using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork7
{
    public partial class Form1 : Form
    {
        Stack<int> comands;
        public Form1()
        {
            InitializeComponent();
            comands = new Stack<int>();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnStart.Text = "Играть!";
            btnCancel.Text = "Отменить";
            btnReset.Text = "Сброс";
            lblNumber.Text = "0";
            lblNum.Text = "0";
            lblCommands.Text = "0";
            this.Text = "Удвоитель";

        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            lblCommands.Text = (int.Parse(lblCommands.Text) + 1).ToString();
            comands.Push(1);
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            if (int.Parse(lblNumber.Text) != 0)
            {
            lblCommands.Text = (int.Parse(lblCommands.Text) + 1).ToString();
                comands.Push(2);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            lblCommands.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            lblNum.Text = r.Next(100).ToString() ;
            btnCancel.Enabled = true;
            btnCommand1.Enabled = true;
            btnCommand2.Enabled = true;
            btnReset.Enabled = true;
            btnStart.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (comands.Count > 1)
            {

                if (comands.Peek() == 2)
                {
                    lblNumber.Text = (int.Parse(lblNumber.Text) / 2).ToString();
                    comands.Pop();
                }
                else
                {
                    lblNumber.Text = (int.Parse(lblNumber.Text) - 1).ToString();
                    comands.Pop();
                }
                lblCommands.Text = (int.Parse(lblCommands.Text) - 1).ToString();
            }
        }
    }
}
