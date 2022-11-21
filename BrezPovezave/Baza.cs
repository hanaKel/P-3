using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace BrezPovezave
{
    class Baza
    {
        // tukaj se nahaja moja baza
        private string lokacija_baze = @"C:\Users\Ldon Kranjec\source\repos\BrezPovezave_Filmi\BrezPovezave\filmi.sqlite";
        // povezava baza izhodna tabela s podatki
        SQLiteDataAdapter data_adapter;

        public DataSet ds
        {
            get;
            set;
        }


        /// <summary>
        /// Izvedemo sql ukaz in shranimo vse podatke iz baze v dataset
        /// </summary>
        /// <param name="sql_ukaz"></param>
        public void IzvediUkaz(string sql_ukaz)
        {
            //Povezemo bazo
            SQLiteConnection povezi = new SQLiteConnection("Data source=" + lokacija_baze);
            //Izvedemo ukaz
            this.data_adapter = new SQLiteDataAdapter(sql_ukaz, povezi);

            this.ds = new DataSet();
            //Prenesemo vse podatke v naše tabele v programu
            data_adapter.Fill(this.ds);
        }


        /// Dodamo nov film v bazo
        public void NovFilm(string ime, string leto, string ocena)
        {
            DataRow vrsta = ds.Tables[0].NewRow();

            vrsta["naslov"] = ime;
            vrsta["leto"] = leto;
            vrsta["ocena"] = ocena;


            ds.Tables[0].Rows.Add(vrsta);

        }

        /// <summary>
        /// Prenesemo nove filme v bazo
        /// </summary>
        public void Dodaj()
        {
            this.data_adapter.Update(this.ds);
        }

    }



}

