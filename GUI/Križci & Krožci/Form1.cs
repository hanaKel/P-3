using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N3_popravki
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer.Start();

        }

        int stevec = 1;

        private void  Zmagovalec()
        {

            // samo se ugotovi kdaj naj izpiše rezultat

            // 1.vr
            if (button1.Text.Contains('x') && button2.Text.Contains('x') && button3.Text.Contains('x'))
            {
                label1.Text = "Zmagovalec je igralec z križci.";
                konecIgre();

            }
            if (button1.Text.Contains('o') && button2.Text.Contains('o') && button3.Text.Contains('o'))
            {
                label1.Text = "Zmagovalec je igralec z krogci.";
                konecIgre();
            }
            // 2.vr
            if (button4.Text.Contains('x') && button5.Text.Contains('x') && button6.Text.Contains('x'))
            {
                label1.Text = "Zmagovalec je igralec z križci.";
                konecIgre();
            }
            if (button4.Text.Contains('o') && button5.Text.Contains('o') && button6.Text.Contains('o'))
            {
                label1.Text = "Zmagovalec je igralec z krogci.";
                konecIgre();
            }
            // 3.vr
            if (button7.Text.Contains('x') && button8.Text.Contains('x') && button9.Text.Contains('x'))
            {
                label1.Text = "Zmagovalec je igralec z križci.";
                konecIgre();
            }
            if (button7.Text.Contains('o') && button8.Text.Contains('o') && button9.Text.Contains('o'))
            {
                label1.Text = "Zmagovalec je igralec z krogci.";
                konecIgre();
            }
            // diagonala 1
            if (button1.Text.Contains('x') && button5.Text.Contains('x') && button9.Text.Contains('x'))
            {
                label1.Text = "Zmagovalec je igralec z križci.";
                konecIgre();
            }
            if (button1.Text.Contains('o') && button5.Text.Contains('o') && button9.Text.Contains('o'))
            {
                label1.Text = "Zmagovalec je igralec z krogci.";
                konecIgre();
            }
            // diagonala 2
            if (button3.Text.Contains('x') && button5.Text.Contains('x') && button7.Text.Contains('x'))
            {
                label1.Text = "Zmagovalec je igralec z križci.";
                konecIgre();
            }
            if (button3.Text.Contains('o') && button5.Text.Contains('o') && button7.Text.Contains('o'))
            {
                label1.Text = "Zmagovalec je igralec z krogci.";
                konecIgre();
            }
        
        }
    
        
        private void konecIgre()
        {
            timer.Stop();
            konec.Text = "KONEC IGRE";
            foreach (Control control in this.Controls)
            {
                if (control is Button btn)
                {
                    btn.Enabled = false;
                }
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (stevec % 2 == 0)
            {
                // bil je 2.igralec
                button1.Text = "o";
            }
            else
            {
                button1.Text = "x";
            }
            stevec++;
            button1.Enabled = false;

            //abel1.Text = Zmagovalec();

            Zmagovalec();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (stevec % 2 == 0)
            {
                // bil je 2.igralec
                button2.Text = "o";
            }
            else
            {
                button2.Text = "x";
            }
            stevec++;
            button2.Enabled = false;

            Zmagovalec();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (stevec % 2 == 0)
            {
                // bil je 2.igralec
                button3.Text = "o";
            }
            else
            {
                button3.Text = "x";
            }
            stevec++;
            button3.Enabled = false;

            Zmagovalec();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (stevec % 2 == 0)
            {
                // bil je 2.igralec
                button4.Text = "o";
            }
            else
            {
                button4.Text = "x";
            }
            stevec++;
            button4.Enabled = false;

            Zmagovalec();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (stevec % 2 == 0)
            {
                // bil je 2.igralec
                button5.Text = "o";
            }
            else
            {
                button5.Text = "x";
            }
            stevec++;
            button5.Enabled = false;

            Zmagovalec();

        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (stevec % 2 == 0)
            {
                // bil je 2.igralec
                button6.Text = "o";
            }
            else
            {
                button6.Text = "x";
            }
            stevec++;
            button6.Enabled = false;

            Zmagovalec();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (stevec % 2 == 0)
            {
                // bil je 2.igralec
                button7.Text = "o";
            }
            else
            {
                button7.Text = "x";
            }
            stevec++;
            button7.Enabled = false;

            Zmagovalec();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (stevec % 2 == 0)
            {
                // bil je 2.igralec
                button8.Text = "o";
            }
            else
            {
                button8.Text = "x";
            }
            stevec++;
            button8.Enabled = false;

            Zmagovalec();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (stevec % 2 == 0)
            {
                // bil je 2.igralec
                button9.Text = "o";
            }
            else
            {
                button9.Text = "x";
            }
            stevec++;
            button9.Enabled = false;

            Zmagovalec();

        }

       


        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {


        }

       

    }


}
    

