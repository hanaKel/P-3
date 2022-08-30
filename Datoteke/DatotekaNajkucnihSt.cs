using System;
using System.IO;

namespace Datoteka3
{
    class DatotekaNakljucnihSt
    {
        /// <summary>
        /// Ustavri datoteko,kjer se v vrstici od 1 do maxvrstic pojavi od 1 do maxstevil stevilk ki imajo vrednost od 1 do maxvrednost
        /// </summary>
        /// <param name="ime"></param>
        /// <param name="maxvrstic"></param>
        /// <param name="maxstevil"></param>
        /// <param name="maxvrednost"></param>
        /// <param name="poravnava"></param>
        public static void Ustvari(string ime, int maxvrstic, int maxstevil, int maxvrednost, int poravnava = 0)
        {
            StreamWriter pisanje = File.CreateText(@"C:\Users\Ldon Kranjec\source\repos\V03\Datoteka3\" + ime);
            Random nakljucno = new Random();

            for (int vrsta = 0; vrsta < nakljucno.Next(maxvrstic) + 1; vrsta++)
            {
                int koliko_stevil = nakljucno.Next(maxstevil) + 1;
                for (int stevilo = 0; stevilo < koliko_stevil; stevilo++)
                {
                    pisanje.Write(Poravnaj(nakljucno.Next(maxvrednost) + 1, poravnava));
                    if (stevilo != koliko_stevil - 1)
                    {
                        pisanje.Write(' ');
                    }
                }
                pisanje.WriteLine();
            }
            pisanje.Close();

        }
        /// <summary>
        /// Vzame stevilo in pred njega postavi toliko presledkov da je skupaj presledkov in stevk enako kot poravnava
        /// </summary>
        /// <param name="stevilo"></param>
        /// <param name="st_presledkov"></param>
        /// <returns>return string</returns>
        public static string Poravnaj(int stevilo, int poravnava)
        {
            string niz_stevka = "" + stevilo;
            if (poravnava == 0)
            {
                return niz_stevka;
            }
            return new String(' ', poravnava - niz_stevka.Length) + niz_stevka;
        }

        /// <summary>
        /// Prebere vrstice iz datoteke in jih izpise
        /// </summary>
        /// <param name="ime"></param>
        public static void Preberi(string ime)
        {
            StreamReader branje = File.OpenText(@"C:\Users\Ldon Kranjec\source\repos\V03\Datoteka3\" + ime);
            string vrstica;
            while ((vrstica = branje.ReadLine()) != null)
            {
                Console.WriteLine(vrstica);
            }
            branje.Close();
        }
        static void Main(string[] args)
        {
            Ustvari("vaja.txt", 5, 5, 15, 5);
            Preberi("vaja.txt");
        }
    }
}