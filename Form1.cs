using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTac
{
    public partial class Form1 : Form
    {
        private string tmp = "X";
        //private string tmp_before;

        public Form1()
        {
            InitializeComponent();
        }

        public bool check()
        {
            if (button1.Text == button2.Text && button1.Text == button3.Text && button1.Text != "")
            {
                return true;
            }
            else if (button4.Text == button5.Text && button4.Text == button6.Text && button4.Text != "")
            {
                return true;
            }
            else if (button7.Text == button8.Text && button7.Text == button9.Text && button7.Text != "")
            {
                return true;
            }
            else if (button1.Text == button4.Text && button1.Text == button7.Text && button1.Text != "")
            {
                return true;
            }
            else if (button2.Text == button5.Text && button2.Text == button8.Text && button2.Text != "")
            {
                return true;
            }
            else if (button3.Text == button6.Text && button3.Text == button9.Text && button3.Text != "")
            {
                return true;
            }
            else if (button1.Text == button5.Text && button1.Text == button9.Text && button1.Text != "")
            {
                return true;
            }
            else if (button3.Text == button5.Text && button3.Text == button7.Text && button3.Text != "")
            {
                return true;
            }
            return false;
        }
        public void Clicked(Button btn)
        {
            string tmp_before;
            int res;
            tmp_before = tmp;
            btn.Text = tmp;
            btn.Enabled = false;
            tmp = tmp == "X" ? "O" : "X";
            if (check())
            {
                //MessageBox.Show("Победил " + tmp,"ура",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                MessageBox.Show("Победил: " + tmp_before, "ура", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clicked(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clicked(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clicked(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clicked(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clicked(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clicked(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clicked(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Clicked(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Clicked(button9);
        }
    }
}
