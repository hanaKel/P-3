using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N3_razred
{
    public class Krog : IComparable<Krog>
    {

        private int[] _sredisce = new int[2];
        private int _polmer;

        public Krog(int[] sr, int pol)
        {
            if (pol <= 0)
            {
                throw new Exception("Polmer mora biti pozitivno število!");
            }
            this._sredisce = sr;
            this._polmer = pol;
        }

        // lasnosti polmer in središče, polmer mora biti vedno pozitiven ne smemo ga nastaviti na neg.

        public int Polmer
        {
            get { return this._polmer; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Negativni polmer");
                }
                this._polmer = value;
            }
        }

        public int [] Sredisce
        {
            get { return this._sredisce; }
            set { this._sredisce = value; }
        }


        /// <summary>
        ///  Metoda ploščina kroga
        /// </summary>
        /// <returns></returns>
        public double Ploscina()
        {
            return (Math.PI * Math.Pow(this._polmer, 2));
        }

        /// <summary>
        /// Bralna lasnost obseg
        /// </summary>
        /// <returns></returns>
        public double BeriObseg
        {
            get { return 2 * Math.PI * this._polmer; }
        }

        //Mnozenje z pozitivnih faktorjem, na obeh straneh 
        public static Krog operator *(Krog osnoven, int mnozenec)
        {
            if (mnozenec < 0)
            {
                throw new Exception("Kroga ne moremo mnoziti z negativnim faktorjem");
            }
            Krog nov_krog = new Krog(osnoven.Sredisce , osnoven.Polmer * mnozenec);
            return nov_krog;
        }

        public static Krog operator *(int mnozenec, Krog osnoven)
        {
            //Samo obrnemo, da se uporabi metoda, ki smo jo definirali za obratni vrstni red
            return osnoven * mnozenec;
        }

        /// <summary>
        ///  Metoda pove ali se sekata
        /// </summary>
        /// <param name="prvi"></param>
        /// <param name="drugi"></param>
        /// <returns></returns>

        public static string lega(Krog prvi, Krog drugi)
        {

            int xPrvi = prvi.Sredisce[0];
            int yPrvi = prvi.Sredisce[1];
            int xDrugi = drugi.Sredisce[0];
            int yDrugi = drugi.Sredisce[1];

            double razdalja = Math.Sqrt(Math.Pow(xDrugi - xPrvi, 2) + Math.Pow(yDrugi - yPrvi, 2));

            double vsotaPolmerov = prvi.Polmer + drugi.Polmer;

            if (razdalja > vsotaPolmerov)
            {
                return "kroga nimata skupnih tock";
            }

            if (razdalja == vsotaPolmerov)
            {
                return "kroga se dotikata";
            }

            return "kroga se sekata";


        }

        /// <summary>
        /// Pretvarjanje v niz
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Krog ima sredisce v ({Sredisce[0].ToString()}.{Sredisce[1].ToString()}) in polmer dolzine {Polmer} enot";
        }

        /// <summary>
        /// Razdalja od (0,0) do prvega in drugega kroga.
        /// </summary>
        /// <param name="drugi"></param>
        /// <returns></returns>
        public int CompareTo(Krog drugi)
        {
            int x1 = Sredisce[0];
            int y1 = Sredisce[1];
            int x2 = drugi.Sredisce[0];
            int y2 = drugi.Sredisce[1];
            //Primerjamo razdalji od (0,0):
            double prva_razdaja = Math.Sqrt(Math.Pow(0 - x1, 2) + Math.Pow(0 - y1, 2));
            double druga_razdalja = Math.Sqrt(Math.Pow(0 - x2, 2) + Math.Pow(0 - y2, 2));

            return prva_razdaja.CompareTo(druga_razdalja);
        }


        /// <summary>
        ///  Metoda poišče in vrne največji krog oz krog z največjim radijem.
        /// </summary>
        /// <param name="tabelaKrogov"></param>
        /// <returns></returns>
        public static Krog NajvecjiR(Krog[] tabela_krogov)
        {
            if (tabela_krogov.Length == 0)
            {
                return null;
            }
            // shranim podatke prvega in je to moja referenca za primerjanje z ostalimi 
            Krog najvisji = tabela_krogov[0];
            int najvisji_polmer = najvisji.Polmer;

            // grem po tabeli in iščem kater bo najvisji
            for (int i = 0; i < tabela_krogov.Length; i++)
            {
                if (tabela_krogov[i].Polmer >= najvisji_polmer)
                {
                    najvisji = tabela_krogov[i];
                    najvisji_polmer = najvisji.Polmer;
                }
            }

            // V nov krog dam te podatke in ga vrnem kot najvišjega iz tabele
            Krog nova_krog = new Krog(najvisji.Sredisce, najvisji.Polmer);
            return nova_krog;

        }




        static void Main(string[] args)
        {
            int[] sr1 = new int[] { 0, 0 };
            Krog a = new Krog (sr1,5);
            Console.WriteLine(a.Ploscina());
            
            int[] sr2 = new int[] { 3, -2 };
            Krog b = new Krog(sr2,2);
            Console.WriteLine(Krog.lega(a, b));
            Console.WriteLine(b.BeriObseg);
            Console.WriteLine((2 * b * 1).Polmer);
            
            int[] sr3 = new int[] { 8, -2 };
            Krog c = new Krog(sr3,3);
            Console.WriteLine(Krog.lega(a, c));
            Console.WriteLine(Krog.lega(b, c));
            


           
           


        }
    }
}

