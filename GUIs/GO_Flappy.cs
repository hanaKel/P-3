using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class GO_Flappy : Form
    {
        const int ENOTAGORDOL = 5;
        const int ZAC_HITROST = 4;
        const int ZAMIK_LEVO = -100;
        const int ZAMIK_DESNO = 50;
        int premik = ENOTAGORDOL;
        int hitrost = ZAC_HITROST;
        int tocke = 0;

        public GO_Flappy()
        {
            InitializeComponent();
        }

        private void tipkaDol(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                premik = -ENOTAGORDOL;
            }
        }

        private void tipkaGor(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                premik = ENOTAGORDOL;
            }
        }

        private void timerIgra_Tick(object sender, EventArgs e)
        {
            // premaknemo ptiča
            ptic.Top += premik;
            oviraDol.Left -= hitrost;
            oviraGor.Left -= hitrost;
            // ko smo dovolj levo, gremo na desni rob
            if (oviraDol.Left < ZAMIK_LEVO)
            {
                oviraDol.Left = this.Width + ZAMIK_DESNO;
                tocke++;
            }
            if (oviraGor.Left < ZAMIK_LEVO - 30)
            {
                oviraGor.Left = this.Width + ZAMIK_DESNO + 50;
                tocke++;
            }

            label_tocke.Text = "TOČKE: "+tocke.ToString();


            if (ptic.Bounds.IntersectsWith(tla.Bounds) ||
                ptic.Bounds.IntersectsWith(oviraDol.Bounds) ||
                ptic.Bounds.IntersectsWith(oviraGor.Bounds) ||
                ptic.Top < -20)
            {
                konecIgre();
            }
        }

        private void konecIgre()
        {
            timerIgra.Stop();
            konec.Text = "KONEC IGRE";
        }

        private void zacni_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(zacni);
            timerIgra.Start();

        }

        private void label_tocke_Click(object sender, EventArgs e)
        {

        }
    }
}

