using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*
 Miha želi napisati program, ki po vrsti

        Ustvari tekstovno datoteko z imenom "vaja.txt" in vanjo napiše "To je moja datoteka!"
        Prebere datoteko in izpiše njeno prvo vrstico
        Ko uporabnik vnese svoje ime, v datoteko doda vrstico z imenom.
        Nato prebere novo datoteko in na zaslon izpiše vse oštevilčene vrstice nove datoteke.

Program je že začel pisati, a ne dela. Ali znaš njegovo kodo popraviti?

string f = "u:\vaja.txt";
StreamWriter pisanje = File.CreateText(f);
pisanje.WriteLine(To je moja datoteka);
streamReader branje = File.OpenText(f);
string vrstica = branje.ReadLine();
branje.Close(); pisanje.WriteLine(vrstica);
StreamWriter dodajanje = File.CreateText(f);
string ime = branje.ReadLine("Vnesi ime: ")
dodajanje.WriteLine(ime);
dodajanje.Close();
StreamReader novobranje = File.OpenText(f);
int i = 0;
while ((vrstica = novobranje.ReadLine()) != null) {
    Console.WriteLine(++i + ": " + vrstica);
}
novobranje.Close();

        Prepričaj se, da zadnji del kode (številčenje vrstic) deluje pravilno. Zakaj? Ali znaš to zapisati na bolj tradicionalen način?
        Program spremeni tako, da uporabnik sam vnese ime datoteke? Ali znaš to narediti na 'varen' način? (Ime? Kje se ustvari? Že obstaja?)

*/



namespace Datoteka1
{
    class ToJe_MojaDat
    {
        /// <summary>
        /// Izpise vse vrstice v datoteki ostevilcene od 1 naprej
        /// </summary>
        /// <param name="f"></param>
        private static void Izpis(string f)
        {
            StreamReader branje = File.OpenText(f);
            int i = 0;
            string vrstica;
            while ((vrstica = branje.ReadLine()) != null)
            {
                Console.WriteLine(++i + ": " + vrstica);
            }
            branje.Close();
        }

        /// <summary>
        /// Uporabnika vprasa po imenu in ga zapise na konec datoteke na lokaciji f
        /// </summary>
        /// <param name="f"></param>
        private static void VnesiIme(string f)
        {
            StreamWriter dodajanje = File.AppendText(f);
            Console.WriteLine("Vnesi ime: ");
            string ime = Console.ReadLine();

            dodajanje.WriteLine(ime);
            dodajanje.Close();
        }

        /// <summary>
        /// Prebere datoteko in izpise prvo vrstico
        /// </summary>
        /// <param name="f"></param>
        private static void BeriDatoteko(string f)
        {
            StreamReader branje;
            string vrstica;

            branje = File.OpenText(f);
            vrstica = branje.ReadLine();
            branje.Close();
            Console.WriteLine(vrstica);
        }

        /// <summary>
        /// Ustvari datoteko za pisanje na lokaciji f in notri zapise "to je moja datoteka"
        /// </summary>
        /// <param name="f"></param>
        private static void UstvariDatoteko(string f)
        {
            StreamWriter pisanje = File.CreateText(f);
            pisanje.WriteLine("To je moja datoteka");
            pisanje.Close();
        }

        static void Main(string[] args)
        {
            // Ustvari datoteko
            string f = @"C:\Users\Ldon Kranjec\source\repos\V03\Datoteka1/vaja.txt";
            UstvariDatoteko(f);

            // Beremo datoteko in izpišemo v konzolo
            BeriDatoteko(f);

            // Vnesi ime in ga izpiše
            VnesiIme(f);

            // Oštevilči ter izpiše vrstice iz datoteke
            Izpis(f);
        }
    }
}

