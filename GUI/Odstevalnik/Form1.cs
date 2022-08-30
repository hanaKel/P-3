using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Odstevalnik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gumb_zacni_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }


        private void gumb_ustavi_Click(object sender, EventArgs e)
        {
            odtsevalnik.Enabled = false;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            odtsevalnik.Text = "9";
        }

        private void gumb_ponastavi_Click(object sender, EventArgs e)
        {
            odtsevalnik.Text = "9";
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            int trenutno = int.Parse(odtsevalnik.Text);
            if (trenutno <= 0)
            {
                odtsevalnik.Text = "9";
            }
            else
            {
                odtsevalnik.Text = (trenutno - 1).ToString();
            }
        }

        private void odtsevalnik_Click(object sender, EventArgs e)
        {

        }
    }
}
