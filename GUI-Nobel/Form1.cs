using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Nobel
{
    public partial class Form1 : Form
    {
        private int Leto_od, Leto_do;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            izpis.Text = "";

            try
            {
                Leto_od = int.Parse(izberiLetoOd.Text);
                Leto_do = int.Parse(izberiLetoDo.Text);
                if(Leto_od > Leto_do)
                {
                    MessageBox.Show("Napačen vnos letnic!", "Napaka pri vhodu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Napačen vnos letnic!", "Napaka pri vhodu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                

            }

            Dictionary<string, string> podrocja = new Dictionary<string, string>()
            {
                {"Chemistry", "Kemija"},
                {"Peace", "Mir"},
                {"Medicine", "Medicina"},
                {"Literature", "Literatura"},
                {"Physics", "Fizika" },
                {"Economics", "Ekonomija"}
            };

            List<string> vsa_podrocja = new List<string>();
            string dolocena = "";
            foreach (string podrocje in lista.CheckedItems)
            {
                vsa_podrocja.Add("'" + podrocja.FirstOrDefault(x => x.Value == podrocje).Key + "'");
            }
            if (vsa_podrocja.Count != 0)
            {
                dolocena = "(" + string.Join(", ", vsa_podrocja) + ")";
            }

            string povezovalniNiz = "Server= baza.fmf.uni-lj.si; User Id= student11; Password= student; Database= nobel2012;";
            NpgsqlConnection povezava = new NpgsqlConnection(povezovalniNiz);
            string ukaz = $"SELECT * FROM Nobel WHERE yr BETWEEN {Leto_od} AND {Leto_do}";
            if (dolocena != "")
            {
                ukaz += $" AND subject IN {dolocena}";
            }
            ukaz += " ORDER BY yr, subject";
            NpgsqlCommand izvedi = new NpgsqlCommand(ukaz, povezava);
            povezava.Open();
            NpgsqlDataReader beri = izvedi.ExecuteReader();
            while (beri.Read())
            {
                string področje = beri["subject"].ToString();
                int leto = beri.GetInt32(0);
                string oseba = beri.GetString(2);
                izpis.Text += ($" {področje} - {leto} : {oseba})" + Environment.NewLine);
            }
        }
    }
}
