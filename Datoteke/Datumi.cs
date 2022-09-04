using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace N3_datoteke
{
    class Program
    {
        public static void Datumi(string vhod, string izhod)
        {
            string pot = @"C:\Users\Ldon Kranjec\source\repos\Izpit_lanskoleto1\N3_datoteke\";
            StreamReader bralec = File.OpenText(pot + vhod);
            // preverim ali vhodna datotek sploh obstaja
            bool datotekaObstaja = File.Exists(@vhod);
            if (datotekaObstaja == false)
            {
                Console.WriteLine("Datoteka ne obstaja!");
            }
            //če je datoteka prazna
            var vsebina = new FileInfo(pot+vhod);
            if (vsebina.Length == 0)
            {
                Console.WriteLine("Datoteka je prazna.");
            }
            

            // datoteka za pisanje
            StreamWriter pisanje = File.CreateText(@"C:\Users\Ldon Kranjec\source\repos\Izpit_lanskoleto1\N3_datoteke\" + izhod);
            // preberem kaj vse vsebuje datoteka
            string[] vrstice = System.IO.File.ReadAllLines(pot+vhod);
            foreach (string vrstica in vrstice)
            {
                if (vrstica.Contains('.')) // če vrstica vsebuje piko
                {
                    string[] razbitje = vrstica.Split('.'); // razbijem na pike
                    if (razbitje.Length == 3) // če razbijem na dve piki, dobim tri števila.
                    {
                        try
                        {
                            string dan = razbitje[0];
                            string mesec = razbitje[1];
                            string leto = razbitje[2];

                            if (dan.Length == 2 && mesec.Length == 2 && leto.Length == 4)
                            {
                                pisanje.WriteLine(vrstica);
                            }
                        }
                        catch (FormatException e) // neustrezne preskočim
                        {
                            continue;
                        }
                    }
                }
            }
            pisanje.Close();
            bralec.Close();
        }

        static void Main(string[] args)
        {
            string branje = @"C:\Users\Ldon Kranjec\source\repos\Izpit_lanskoleto1\N3_datoteke\vhodna.txt";
            // na datoteko, bom napisala najprej besedilo z oblepaji, nato zagnala metodo BrezOklepajev
            // kjer se bodo olepšane vrstice prepisale na novo dateko!
            StreamWriter pisi = File.CreateText(branje);
            pisi.WriteLine("Ta vrstica ni datum!");
            pisi.WriteLine("15.10.2000");
            pisi.WriteLine("5.5.2002");
            pisi.WriteLine("01.01.2001");
            pisi.WriteLine("Dovolj testov.");
            pisi.Close();


            Datumi("vhodna.txt", "datumi.txt");
        }

    }
}
