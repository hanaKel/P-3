using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dat_ObrniBesedo
{
    class Datoka_Minus
    {
        /// <summary>
        /// Obrne besedo 
        /// </summary>
        /// <param name="niz"></param>
        /// <returns></returns>
        public static string Obrni_niz(string niz)
        {
            char[] tabela_znakov = niz.ToCharArray();
            Array.Reverse(tabela_znakov);
            return new string(tabela_znakov);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="imeVhod"></param>
        /// <param name="imeIzhod"></param>

        public static void Obrni(string imeVhod, string imeIzhod)
        {
            // če datoteki ni izpiši 42 vrtic na izhodno datoteko
            StreamReader branje;
            string pot = @"C:\Users\Ldon Kranjec\source\repos\Datoteka_ObrnjenaBeseda\Dat_ObrniBesedo\";
            try
            {
                branje = File.OpenText(imeVhod);
            }
            catch //datoteka ne obstaja
            {
                StreamWriter napaka_pisanje = File.CreateText(pot+imeIzhod);
                Console.WriteLine("ni datoteke");
                for (int i = 0; i < 42; i++)
                {
                    napaka_pisanje.WriteLine("Tudi pri težjih problemih smo že odpovedali!");
                }
                napaka_pisanje.Close();
                return;
            }



            StreamWriter pisanje = File.CreateText(pot+imeIzhod);
            string vrstica;
            string obrnjena;
            while ((vrstica = branje.ReadLine()) != null)
            {
                string[] besede_vrs = vrstica.Split(' '); //odstranimo prazne elemente
                foreach (string posamezna in besede_vrs)
                {
                    if (posamezna[0] == '-') // če se beseda začne z minusom, jo obrnemo
                    {
                        obrnjena = Obrni_niz(posamezna);
                        obrnjena = obrnjena.Remove(obrnjena.Length - 1); // brez minusa
                        pisanje.Write(obrnjena);
                    }
                    else
                    {
                        pisanje.Write(posamezna);
                    }
                    pisanje.Write(" ");
                }
                pisanje.WriteLine();
            }

            branje.Close();
            pisanje.Close();

        }
        static void Main(string[] args)
        {
            string branje = @"C:\Users\Ldon Kranjec\source\repos\Datoteka_ObrnjenaBeseda\Dat_ObrniBesedo\vhod.txt";
            // na datoteko, bom napisala najprej besedilo z minusi, nato zagnala metodo Obrni
            // kjer se bodo spremenjene vrstice prepisale na novo dateko!
            StreamWriter pisi = File.CreateText(branje);
            pisi.WriteLine("Peter -spet zamuja.");
            pisi.WriteLine("Jaz sem -napisala narobe");
            pisi.WriteLine("Tudi -jaz.");
            pisi.Close();
            string pisanje = "izhod.txt";
            Obrni(branje, pisanje);
        }
    }
}
