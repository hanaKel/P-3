using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrezPovezave
{
    public partial class filmi : Form
    {
        private Baza vsi_podatki = new Baza();
        public filmi()
        {
            InitializeComponent();

            //Naredimo poizvedbo
            this.vsi_podatki.IzvediUkaz("SELECT naslov, leto, ocena FROM filmi");

            //Prikazemo podatke
            izpis_podatkov.DataSource = vsi_podatki.ds.Tables[0];
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            // Uporabnik mora vnesti vse tri podatke
            try
            {
                this.vsi_podatki.NovFilm(txt_naslov.Text, txt_leto.Text, txt_ocena.Text);
            }
            catch
            {
                MessageBox.Show("Vnesi vse podatke!");
            }
            brisalniTimer.Enabled = true;

            try
            {

                int leto = Int32.Parse(txt_leto.Text);
            }
            catch
            {
                MessageBox.Show("Ni pravi vnos leta!");
            }

            // Uporabnik lahko vnese le števila med 1-10.
            int ocena = Int32.Parse(txt_ocena.Text);
            if (ocena > 10)
            {
                MessageBox.Show("Ocena filma je lahko le med 1 in 10 !! ");
                throw new Exception();
            }

            // Uporabnik ne sme vnes datuma večjega od današnjega.
            int datum = Int32.Parse(txt_leto.Text);
            if (datum > 2023)
            {
                MessageBox.Show("Filmov iz prihodnosti ne vnašamo !! ");
                throw new Exception();
            }

        }
    


        private void brisalniTimer_Tick(object sender, EventArgs e)
        {
                // PObrisemo podatke
                txt_naslov.Clear();
                txt_ocena.Clear();
                txt_leto.Clear();

                brisalniTimer.Enabled = false;

        }
    }
}
