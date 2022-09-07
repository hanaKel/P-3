using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Text.RegularExpressions;

namespace Filmi
{
    public partial class Form1 : Form
    {
        public int Leto_od, Leto_do;
        public double Ocena_od, Ocena_do;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            prikaz.Text = "";
            string pot = @"Data Source=.\filmi.sqlite; Version=3;";
            SQLiteConnection link = new SQLiteConnection(pot);
            link.Open();
            SQLiteCommand ukaz = new SQLiteCommand();
            ukaz.CommandType = CommandType.Text;
            ukaz.Connection = link;
            ukaz.CommandText = "SELECT DISTINCT reziser FROM filmi ORDER BY reziser";
            SQLiteDataReader izpis = ukaz.ExecuteReader();
            

            int i = 0;
            while (izpis.Read())
            {
                comboBox1.Items.Add(izpis[0]);
                i++;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void izbrisiTekst(object sender, EventArgs e)
        {
            leto_od.Text = String.Empty;
            if(leto_do.Text == "") { leto_do.Text = "Do"; }
            if(ocena_od.Text == "") { ocena_od.Text = "Od";}
            if (ocena_do.Text == "") { ocena_do.Text = "Do"; }
        }

        private void izbrisiTekst2(object sender, EventArgs e)
        {
            leto_do.Text = String.Empty;
            if (leto_od.Text == "") { leto_od.Text = "Od"; }
            if (ocena_od.Text == "") { ocena_od.Text = "Od"; }
            if (ocena_do.Text == "") { ocena_do.Text = "Do"; }
        }

        private void izbrisiTekst3(object sender, EventArgs e)
        {
            ocena_od.Text = String.Empty;
            if (leto_do.Text == "") { leto_do.Text = "Do"; }
            if (leto_od.Text == "") { leto_od.Text = "Od"; }
            if (ocena_do.Text == "") { ocena_do.Text = "Do"; }
        }

        private void izbrisiTekst4(object sender, EventArgs e)
        {
            ocena_do.Text = String.Empty;
            if (leto_do.Text == "") { leto_do.Text = "Do"; }
            if (leto_od.Text == "") { leto_od.Text = "Od"; }
            if (ocena_od.Text == "") { ocena_od.Text = "Od"; }
        }

        private void klikNaslov(object sender, EventArgs e)
        {
            if (leto_do.Text == "") { leto_do.Text = "Do"; }
            if (leto_od.Text == "") { leto_od.Text = "Od"; }
            if (ocena_od.Text == "") { ocena_od.Text = "Od"; }
            if (ocena_do.Text == "") { ocena_do.Text = "Do"; }
        }

        private void klikReziser(object sender, EventArgs e)
        {
            if (leto_do.Text == "") { leto_do.Text = "Do"; }
            if (leto_od.Text == "") { leto_od.Text = "Od"; }
            if (ocena_od.Text == "") { ocena_od.Text = "Od"; }
            if (ocena_do.Text == "") { ocena_do.Text = "Do"; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void izvedi_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]+$");
            prikaz.Text = "";
            string pot = @"Data Source=.\filmi.sqlite; Version=3;";
            SQLiteConnection link = new SQLiteConnection(pot);
            link.Open();
            SQLiteCommand ukaz = new SQLiteCommand();
            ukaz.CommandType = CommandType.Text;
            ukaz.Connection = link;
            ukaz.CommandText = "SELECT * FROM filmi";
            if(ocena_od.Text == "Od") {Ocena_od = 0;}
            else{
                if (regex.IsMatch(ocena_od.Text) == false)
                {
                    MessageBox.Show("Ocena mora biti celo število med 1 in 10!", "Napaka pri vhodnih podatkih", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if ((double.Parse(ocena_od.Text) < 1) || (double.Parse(ocena_od.Text) > 10))
                {
                    MessageBox.Show("Ocena mora biti med 1 in 10!", "Napaka pri vhodnih podatkih", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    Ocena_od = double.Parse(ocena_od.Text);
                }
                }

            if(ocena_do.Text == "Do") { Ocena_do = 10; }
            else {
                if (regex.IsMatch(ocena_do.Text) == false)
                {
                    MessageBox.Show("Ocena mora biti celo število med 1 in 10!", "Napaka pri vhodnih podatkih", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if ((double.Parse(ocena_do.Text) < 1) || (double.Parse(ocena_do.Text) > 10))
                {
                    MessageBox.Show("Ocena mora biti med 1 in 10!", "Napaka pri vhodnih podatkih", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (Ocena_od > double.Parse(ocena_do.Text))
                {
                    MessageBox.Show("Ocena 'Od' mora biti manjša od ocene 'Do'!", "Napaka pri vhodnih podatkih", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    Ocena_do = double.Parse(ocena_do.Text);
                }
                }
            
            if (leto_od.Text == "Od") { Leto_od = 0; }
            else {
                if (regex.IsMatch(leto_od.Text) == false)
                {
                    MessageBox.Show("Leto mora biti celo število!", "Napaka pri vhodnih podatkih", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else { 
                    Leto_od = int.Parse(leto_od.Text); 
                    if (Leto_od < 0)
                    {
                        MessageBox.Show("Leto mora biti pozitivno celo število!", "Napaka pri vhodnih podatkih", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    }
                }

            if (leto_do.Text == "Do") { Leto_do = 2022; }
            else {
                if (regex.IsMatch(leto_do.Text) == false)
                {
                    MessageBox.Show("Leto mora biti celo število!", "Napaka pri vhodnih podatkih", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (Leto_od > int.Parse(leto_do.Text))
                {
                    MessageBox.Show("Leto 'Od' mora biti manjše od leto 'Do'!", "Napaka pri vhodnih podatkih", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    Leto_do = int.Parse(leto_do.Text);
                }
                }

            ukaz.CommandText += $" WHERE naslov LIKE '%{naslov.Text}%'";
            if (comboBox1.SelectedIndex > -1)
            {
                ukaz.CommandText += $" AND reziser =  '{comboBox1.Text}'";
            }
            ukaz.CommandText += $" AND leto BETWEEN { Leto_od} AND { Leto_do} AND ocena BETWEEN { Ocena_od} AND { Ocena_do}";
            SQLiteDataReader izpis = ukaz.ExecuteReader();
            int i = 0;
            while (izpis.Read())
            {
                prikaz.Text += (izpis[1].ToString() + " (" + izpis[2].ToString() + "), režija: " + izpis[3].ToString() + ", žanr: " + izpis[4].ToString() + ", ocena: " + izpis[6].ToString() + Environment.NewLine);
                i++;
            }
            if(i == 0)
            {
                prikaz.Text = "V bazi ni ustreznega filma za vaš izbor.";
            }
        }
    }
}
