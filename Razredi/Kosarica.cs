using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Razred_Vozilo;

namespace Razred_Kosarica
{
    public class Kosarica<T>
    {

        //razred Kosarica, ki naj vsebuje en sam objekt poljubnega tipa (namig: generični tip).
        //Ta objekt naj bo privaten, zato sestavi tudi ustrezne metode za branje oz.spreminjanje podatkov
        private T _podatek;

        public Kosarica(T podatek)
        {
            this.podatek = podatek;
        }

        public T podatek
        {
            get { return this._podatek; }
            set { this._podatek = value; }
        }

        /// <summary>
        /// V razredu prekrij tudi metodo ToString, ki naj vrne niz, ki ga dobimo s klicem metode ToString na objektu, ki ga hranimo v razred
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this._podatek.ToString();
        }

    }

    /// <summary>
    /// Nato sestavi testni program, kjer ustvariš vsaj pet objektov tipa Kosarica,ki hranijo niz, celo število, objekt nekega tvojega tipa (Oseba, Zajec, Vozilo, Ulomek ...),
    /// realno število in tabelo celih števil (ki naj vsebuje vsaj štiri števila). 
    /// Vse te objekte tudi izpiši na zaslon.
    /// Zakaj so pri zadnjem objektu težave? Kaj pa pri tretjem z vašim objektom? Od česa je odvisna "pravilnost" izpisa?
    /// </summary>
    /// <param name="args"></param>

    class Testiranje
    {
        static void Main(string[] args)
        {
            // niz
            string tests = "KosaricaKosara";
            Kosarica<string> teststring = new Kosarica<string>(tests);
            Console.WriteLine(teststring);
            // celo število
            int testi = 5;
            Kosarica<int> testint = new Kosarica<int>(testi);
            Console.WriteLine(testint);
            // objekt Vozilo
            // Izpiše se "Avto z kapaciteto tanka: 100l ima še 100l goriva njegova poraba je 5l/100km";
            Vozilo avtomobil = new Vozilo(100, 5);
            Kosarica<Vozilo> avto = new Kosarica<Vozilo>(avtomobil);
            Console.WriteLine(avto);
            //dec. število
            double testd = 5.7;
            Kosarica<double> testdouble = new Kosarica<double>(testd);
            Console.WriteLine(testdouble);
            //tabela
            //Pri tem se pojavijo težave, saj iz te tabele se ne more narediti string izpis tabele
            int[] testit = new int[] { 4, 2, 4, 2 };
            Kosarica<int[]> testinttab = new Kosarica<int[]>(testit);
            Console.WriteLine(testinttab);
        }
    }
}
