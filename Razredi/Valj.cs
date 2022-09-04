using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_popravki
{
    class Valj : IComparable<Valj>  // za primerjanje valjev med sabo 
    {
        // vhodni podatki so double in ne int
        private double _visina;
        private double _polmer;

        public Valj(double vis, double pol)
        {
            this._visina = vis;
            if (pol < 0)
            {
                throw new Exception("Polmer ne sme biti negativen.");
            }
            this._polmer = pol;
        }

        //Lastnosti
        // Visina ne sme biti negativna 
        public double Visina
        {
            get { return this._visina; }
            set
            {
                if (value >= 0)
                {
                    this._visina = value;
                }
                else
                {
                    throw new Exception("Visina ne sme biti negativna.");
                }
            }
        }

        // tukaj ni set-a !!!
        public double Polmer
        {
            get { return this._polmer; }
        }

        /// <summary>
        /// Vrne volumen valja V = Pi * r^2 * v
        /// </summary>
        /// <param name="valj"></param>
        /// <returns>volumen</returns>
        public static double Volumen(Valj valj)
        {
            double volumen = Math.PI * valj.Polmer * valj.Polmer * valj.Visina;
            return volumen;
        }

        //Bralna lastnost obseg

        public double Obseg
        {
            get { return 2 * Math.PI * this.Polmer; }
        }

        //Mnozenje z pozitivnih faktorjem, na obeh straneh 
        public static Valj operator *(Valj osnoven, int mnozenec)
        {
            if (mnozenec < 0)
            {
                throw new Exception("Valja ne moremo mnoziti z negativnim faktorjem");
            }
            Valj nov_valj = new Valj(osnoven.Visina * mnozenec, osnoven.Polmer);
            return nov_valj;
        }

        public static Valj operator *(int mnozenec, Valj osnoven)
        {
            //Samo obrnemo, da se uporabi metoda, ki smo jo definirali za obratni vrstni red
            return osnoven * mnozenec;
        }

        //Metoda za pretvarjanje v niz
        public override string ToString()
        {
            return $"Valj z višino {Visina} in polmerjem {Polmer}.";
        }

        
        /// <summary>
        /// Primerjanje dveh vajlov po volumnu, da jih lahku urejamo
        /// </summary>
        /// <param name="primerjava_Valj"></param>
        /// <returns></returns>
        public int CompareTo(Valj primerjava_Valj)
        {
            //Primerjamo volumna
            return Valj.Volumen(this).CompareTo(Valj.Volumen(primerjava_Valj));
        }


        // Vrne najnizji valj v tabeli, ce jih je vec vrne tistega, ki je zadnji

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tabela_valjev"></param>
        /// <returns></returns>

        public static Valj NajnizjiValj(Valj[] tabela_valjev)
        {
            // prazana tabela vrne null
            if (tabela_valjev.Length == 0)
            {
                return null;
            }

            // shranim podatke prvega in je to moja referenca za primerjanje z ostalimi 
            Valj najnizji = tabela_valjev[0];
            double najnizja_visina = najnizji.Visina;

            // grem po tabeli in iščem kater bo najmanjši
            for (int i = 0; i < tabela_valjev.Length; i++)
            {
                if (tabela_valjev[i].Visina <= najnizja_visina)
                {
                    najnizji = tabela_valjev[i];
                    najnizja_visina = najnizji.Visina;
                }
            }

            // V nov valj dam te podatke in ga vrnem kot najnižjega iz tabele
            Valj nov_valj = new Valj(najnizji.Visina, najnizji.Polmer);
            return nov_valj;
        }



        // testi

        static void Main(string[] args)
        {

            Valj testni = new Valj(1, 2);
            Console.WriteLine(testni);

            Valj levi = testni * 2;
            Console.WriteLine(levi);
            Valj desni = 2 * levi;
            Console.WriteLine(desni);

            Console.WriteLine(desni.Obseg);
            Console.WriteLine(Valj.Volumen(desni));

            Valj[] tabela = new Valj[3];
            tabela[0] = testni;
            tabela[1] = levi;
            tabela[2] = desni;
            Console.WriteLine(Valj.NajnizjiValj(tabela));
        }
    }
}