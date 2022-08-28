using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razred_Bager

{
    public class Bager 
    {
        //konstruktor, kjer nastavimo težo bagra (v kilogramih), njegovo ime (niz), leto izdelave in ceno (v evrih).

        private int teza;
        private string ime;
        private int leto_izdelave;
        private int cena;

        // nastavimo zacetne vrednosti
        public Bager()
        {
            this.teza = 1000;
            this.ime = "Bager1";
            this.leto_izdelave = 2015;
            this.cena = 40000;
        }

        //lastnosti za branje / spreminjanje cene
        // za branje leta izdelave(leta izdelave naj se ne da spreminjati)
        // za branje teže(teže naj se ne da nastavljati).

        public override string ToString()
        {
            return $"{this.ime};{this.teza};{this.leto_izdelave};{this.cena}";
        }

        // Pri tem upoštevajte, da: sta cena in teža sta lahko le pozitivni celi števili
        //  Pri tem upoštevajte, da: leto izdelave je med 1990 
        //  letnico uporabe programa, naziv pa le niz, ter da bi radi pri izpisu objekta na zaslon dobili izpis oblike »Bager #naziv težak #teža stane #cena EUR«.

        public Bager(string ime, int teza, int leto, int cena)
        {
            this.ime = ime;
            if (teza <= 0)
            {
                throw new Exception("Teza ni pravilno podana!");
            }
            this.teza = teza;

            if (leto < 1990 || leto > DateTime.Now.Year)
            {
                throw new Exception("Neprimerena letnica");
            }
            this.leto_izdelave = leto;

            this.cena = cena;

        }
        public void Izpis()
        {
            Console.WriteLine($"Bager {this.Ime} težak {this.Teza} stane {this.Cena} EUR");
        }

        public int Teza
        {
            get { return this.teza; }
        }

        public int Cena
        {
            get { return this.cena; }
        }
        public int LetoIzdelave
        {
            get { return this.leto_izdelave; }
        }

        public string Ime
        {
            get { return this.ime; }
        }

        //  Izpišite najtežji bager v tabeli bagrov. 
        public static void Najteznji(Bager[] tabela_bagrov)
        {
            if (tabela_bagrov.Length == 0)
            {
                throw new Exception("Tabela bagrov je prazna");
            }
            Bager najtezji = tabela_bagrov[0];
            foreach (Bager posamezni in tabela_bagrov)
            {
                if (posamezni.Teza > najtezji.Teza)
                {
                    najtezji = posamezni;
                }
            }

            najtezji.Izpis();
        }

        // Vse bagre, ki so dražji od 20000€, pocenite za 10%. 
        public static void Poceni(Bager[] tabela_bagrov)
        {
            foreach (Bager posamezni in tabela_bagrov)
            {
                if (posamezni.cena >= 20000)
                {
                    posamezni.cena = (int)(posamezni.cena * ((100 - 10) / 100));
                }
            }
        }

        // Uredite tabelo bagrov po starosti. Če sta dva bagra iste letnice, je prej tisti, ki je lažji.



        // Ostranite iz tabele vse bagre, ki so starejši od 12 let.
        public static void OdstraniNajstarejse(ref Bager[] tabela_bagrov)
        {
            if (tabela_bagrov.Length == 0)
            {
                throw new Exception("Tabela bagrov je prazna");
            }
            List<Bager> ustrezni = new List<Bager>();
            foreach (Bager posamezni in tabela_bagrov)
            {
                int starost = DateTime.Now.Year - posamezni.leto_izdelave;
                if (starost >= 12)
                {
                    ustrezni.Add(posamezni);
                }   
            }
            tabela_bagrov = ustrezni.ToArray();
        }



        static void Main(string[] args)
        {
        }
    }
}
