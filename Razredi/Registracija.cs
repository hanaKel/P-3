
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Razred_Registracija
{
    /// <summary>
    /// 
    /// </summary>
    public class Registracija
    {
        private string _obmocje;
        private string _registracija;
        private static string[] vsa_obmocija = new string[] { "LJ", "KR", "KK", "MB", "MS", "KP", "GO", "CE", "SG", "NM", "PO" };

        public Registracija(string obmocje, string registracija)
        {
            this.obmocje = obmocje;
            this.registracija = registracija;
        }

        /// <summary>
        /// Izpisemo registrsko  obmocje : registracija
        /// </summary>
        /// <returns>return string</returns>
        public override string ToString()
        {
            return $"{this._obmocje} : {this._registracija}";
        }

        /// <summary>
        /// Lastnost obmocje, ki poskrbi za pravilnost obmocja
        /// Lahko je samo dolzine dva oz. dveh črk iz zgornjega seznama
        /// </summary>
        public string obmocje
        {
            get { return this._obmocje; }
            set
            {
                if (value.Length != 2)  // more biti dolžine 2
                {
                    throw new Exception("Ni pravilne dolžine!");
                }

                if (!vsa_obmocija.Contains(value)) // more biti iz navedelih območij 
                {
                    throw new Exception("To območje ni pravo!");
                }

                foreach (char crka in value)  // samo črke
                {
                    if (!char.IsLetter(crka))
                    {
                        throw new Exception("Vsebuje lahko le črke!");
                    }
                }
                this._obmocje = value;
            }
        }

        /// <summary>
        /// Lastnost registracije preveri ali je pravilnega zapisa
        /// </summary>
        public string registracija
        {
            get { return this._registracija; }
            set
            {
                if (value.Length != 5)  // ustrezna dolzina je 5
                {
                    throw new Exception("Ni prave dolžine");
                }
                this._registracija = value;
            }
        }

        // Testni del : Napiši testni program, ki ustvari tabelo 100 registrskih številk 
        static void Main(string[] args)
        {
            Random rng = new Random();
            //generator registrskih
            Registracija[] tabela_reg = new Registracija[100];
            string znaki = "ABCDEFGHIJKLMNOPRSTUVZ0123456789";
            StringBuilder reg = new StringBuilder();

            int st = 100;
            // sto registerskih
            for (int i = 0; i < st; i++)
            {
                //obmocje - dovoljeno iz zgoraj podane tabele
                string obmocje = Registracija.vsa_obmocija[rng.Next(Registracija.vsa_obmocija.Length)];
                for (int j = 0; j < 5; j++)
                { 
                    // generator registerske
                    reg.Append(znaki[rng.Next(znaki.Length)]);
                }
                tabela_reg[i] = new Registracija(obmocje, reg.ToString());
                reg.Clear();
            }


            foreach (Registracija obmReg in tabela_reg)
            {
                Console.WriteLine(obmReg);
            }

        }
    }
}