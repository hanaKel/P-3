using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razred_Krogla
{
    public class Krogla : IComparable<Krogla>
    {
        private int[] _sredisce = new int [2];
        private int _polmer;


        // Če polmer nastavimo na neg. število, sprožimo izjemo!
        public Krogla(int[] sr, int pol)  // tukaj je če so vhodni podatki neg. polmer
        {
            this._sredisce = sr;
            if (pol < 0)
            {
                throw new Exception("Polmer ne sme biti negativen.");
            }
            this._polmer = pol;
        }

        // lasnost polmer
        public int Polmer
        {
            get { return this._polmer; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Polmer ne sme biti negativen!");
                }
                this._polmer = value;
            }

        }

        // lasnost sredisce
        public int [] Sredisce
        {
            get { return this._sredisce; }
            set { this._sredisce = value; }
        }

        /// <summary>
        /// Metoda volumen krogle
        /// </summary>
        /// <param name="krogla"></param>
        /// <returns></returns>
        public static double Volumen(Krogla krogla)
        {
            double volumen = (4 * Math.PI * krogla.Polmer * krogla.Polmer * krogla.Polmer)/4;
            return volumen;
        }

        //Bralna lastnost obseg
        public double Obseg
        {
            get { return 2 * Math.PI * this.Polmer; }
        }

        /// <summary>
        /// Možnot množenja iz obeh strani
        /// </summary>
        /// <param name="osnoven"></param>
        /// <param name="mnozenec"></param>
        /// <returns></returns>
        public static Krogla operator *(Krogla osnovna, int mnozenec)
        {
            if (mnozenec < 0)
            {
                throw new Exception("Kroglo ne moremo mnoziti z negativnim faktorjem");
            }
            Krogla nova_krogla = new Krogla(osnovna.Sredisce , osnovna.Polmer * mnozenec);
            return nova_krogla;
        }

        public static Krogla operator *(int mnozenec, Krogla osnovna)
        {
            //Samo obrnemo, da se uporabi metoda, ki smo jo definirali za obratni vrstni red
            return osnovna * mnozenec;
        }

        
        /// <summary>
        ///  Metoda lega pove ali se krogli sekata
        /// </summary>
        /// <param name="prva"></param>
        /// <param name="druga"></param>
        /// <returns></returns>
        public static string Lega(Krogla prva, Krogla druga)
        {
            int x1 = prva.Sredisce[0];
            int y1 = prva.Sredisce[0];
            int x2 = druga.Sredisce[1];
            int y2 = druga.Sredisce[1];
            
            double razdalja = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
           double vsotaPolmerov = prva.Polmer + druga.Polmer;

            if (razdalja > vsotaPolmerov)
            {
                return $"Krogli s središčem v {prva.Sredisce} in polmerjem {prva.Polmer} ter {druga.Sredisce} in polmerjem {druga.Polmer} nimata skupnih tock";
            }

            if (razdalja == vsotaPolmerov)
            {
                return $"Krogli s središčem v {prva.Sredisce} in polmerjem {prva.Polmer} ter {druga.Sredisce} in polmerjem {druga.Polmer} se dotikata"; 
            }

            return $"Krogli s središčem v {prva.Sredisce} in polmerjem {prva.Polmer} ter {druga.Sredisce} in polmerjem {druga.Polmer} se sekata"; 
            


        }

        /// <summary>
        /// Metoda za pretvarjenje v niz
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string sr = "";
            foreach (int st in Sredisce)
            {
                string s = st.ToString();
                sr += s;
            }
            return $"Krogla s srediscem {sr} in polmerjem {Polmer}.";
        }


        /// <summary>
        /// Urejamo krogle po volumnu
        /// </summary>
        /// <param name="primerjava_Krogla"></param>
        /// <returns></returns>
        public int CompareTo(Krogla primerjava_Krogla)
        {
            //Primerjamo volumnu
            return Krogla.Volumen(this).CompareTo(Krogla.Volumen(primerjava_Krogla));
        }

        /// <summary>
        ///  Vrne kroglo z najvecjim polmerom
        /// </summary>
        /// <param name="tabela_krogel"></param>
        /// <returns></returns>

        public static Krogla NajvecjiR(Krogla[] tabela_krogel)
        {
            // prazana tabela vrne null
            if (tabela_krogel.Length == 0)
            {
                return null;
            }

            // shranim podatke prvega in je to moja referenca za primerjanje z ostalimi 
            Krogla najvisji = tabela_krogel[0];
            int najvisji_polmer = najvisji.Polmer;

            // grem po tabeli in iščem kater bo najvisji
            for (int i = 0; i < tabela_krogel.Length; i++)
            {
                if (tabela_krogel[i].Polmer >= najvisji_polmer)
                {
                    najvisji = tabela_krogel[i];
                    najvisji_polmer = najvisji.Polmer;
                }
            }

            // V novo kroglo dam te podatke in ga vrnem kot najvišjega iz tabele
            Krogla nova_krogla = new Krogla(najvisji.Sredisce, najvisji.Polmer);
            return nova_krogla;

        }
            static void Main(string[] args)
            {
            int[] sr1 = new[] { 1,1 };
            Krogla testna = new Krogla(sr1, 1);
            Console.WriteLine(testna);
            Console.WriteLine(Krogla.Volumen(testna));
            Console.WriteLine(testna.Obseg);
            Console.WriteLine(testna * 3);
            Console.WriteLine(5 * testna);
            int[] sr2 = new[] { 2, 2 };
            Krogla testna2 = new Krogla(sr2, 2);
            Console.WriteLine(Krogla.Lega(testna, testna2));
            }
        }
    }
