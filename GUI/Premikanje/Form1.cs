using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Premikanje
{
    public partial class Form1 : Form
    {
        int x = 600;
        int y = 100;
        
        public Form1()
        {
            InitializeComponent();
        }


        // kliknem dvakrat na ozadje da pridem do tega
        private void Form1_Load(object sender, EventArgs e)
        {
            casovnik.Interval = 1; // premik na 1 sek
            casovnik.Start();

            timer.Interval = 1;
            timer.Start();

            label_P3.Visible =  true;

        }

        // da se label premika levo-desno
        private void casovnik_Tick(object sender, EventArgs e)
        {
            label_fmf.SetBounds(x, y, 1, 1);

            /* desno -> levi
            x++;
            if(x>=800)
            {
                x = 1;
            }
            */
            // levo -> desni
            x--;
            if (x < 1)
            {
                x = 600;
            }
        }

        // da label utripa
        private int cas = 1;
        private void timer_Tick(object sender, EventArgs e)
        {
            while (cas < 1000)
            {
                cas++;
                if (cas/2 == 0)
                {
                    label_P3.Visible = true;
                }
                else
                {
                    label_P3.Visible = false;
                }

                cas++;
            }
        }
    }








}
