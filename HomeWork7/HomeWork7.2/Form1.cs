using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork7._2
{
    public partial class Form1 : Form
    {
        int Num;
        public Form1()
        {
            InitializeComponent();
            btn.Enabled = false;
            txtBox.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btn.Enabled = true;
            txtBox.Enabled = true;
            txtBox.Text = "";
            lblNum.Text = "";
            lblML.Text = "";
            Random r = new Random();
            Num = r.Next(100);
            lblText.Text = "Попробуй угадать!";
            btnStart.Enabled = false;

        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Length > 0)
            {
                if(int.Parse(txtBox.Text) == Num)
                {
                    lblText.Text = "Поздравления!";
                    lblNum.Text = Num.ToString();
                    btn.Enabled = false;
                    txtBox.Enabled = false;
                    btnStart.Text = "Начать заново";
                    btnStart.Enabled = true;
                }
                else if(int.Parse(txtBox.Text) > Num)
                {
                    lblText.Text = "Попробуй ещё!";
                    lblML.Text = "Меньше";
                    txtBox.Text = "";
                }
                else
                {
                    lblText.Text = "Попробуй ещё!";
                    lblML.Text = "Больше";
                    txtBox.Text = "";
                }
            }
        }
    }
}
