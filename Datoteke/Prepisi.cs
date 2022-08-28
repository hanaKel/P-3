using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Datoteke_Prepisi
{
    class Prepisi
    {
        /// <summary>
        /// ki tekstovno datoteko, katere ime je v imeVhod prepiše na novo 
        /// datoteko z imenom, kot ga določa imeIzhod. Pri tem prazne vrstice izpusti.
        /// </summary>
        /// <param name="imeVhod"></param>
        /// <param name="imeIzhod"></param>
        public static void PrepisiDat(string imeVhod, string imeIzhod)

        {
            StreamReader branje;
            // če vhodna datoteka obstaja
            try
            {
                branje = new StreamReader(imeVhod);
            }
            catch (Exception)
            {
                throw new Exception("Datoteke za branje ni mogoče najti!");
            }


            StreamWriter pisanje = File.CreateText(imeIzhod);
            //string vrstica = branje.ReadLine();

            /*
            //vrstica = branje.ReadLine();
            
            while ( vrstica  != null) // dokler ni prazna vrstica, to ni ok ker bi se takoj ustavilo
            {
                Console.WriteLine(vrstica); // izpis vrstic iz dat
                
                if (vrstica[0] != ' ')
                {
                    pisanje.WriteLine(vrstica);
                }
            */
            string[] vrstice = System.IO.File.ReadAllLines(@imeVhod);
            //Preberemo vse vrstice v datoteki.
            foreach (string vrstica in vrstice)
            {
                //preverimo ali vsebuje prazen znak / presledek na prvem mestu
                //potem sklepam, da je prazna vrstica
                if (string.IsNullOrWhiteSpace(vrstica))
                {
                    continue;
                }
                else
                {
                    pisanje.WriteLine(vrstica);

                }
            }
                /*
                foreach(char znak in vrstica)
                {
                    if (znak == ' ')
                    {
                        continue;
                    }
                }
                pisanje.WriteLine(vrstica);
                */

                //vrstica = branje.ReadLine();
            pisanje.Close();
            branje.Close();
        }




        static void Main(string[] args)
        {
            string branje;
            string pisanje;
            /*
            try
            {
                //Neobstojeca datoteka
                branje = @"..\..\..\resitev1.txt";
                pisanje = @"..\..\..\resitev2.txt";
                Prepisi(branje, pisanje);
            }
            catch (Exception e)
            {
            Console.WriteLine("Pri primeru 3 je prislo do napake: " + e);
            }
            */


            //Primer iz navodil, moral bi uspeti
            branje = @"C:\Users\Ldon Kranjec\source\repos\KolikoNajvecjih\Datoteke_Prepisi\imeVhod.txt";
            pisanje = @"C:\Users\Ldon Kranjec\source\repos\KolikoNajvecjih\Datoteke_Prepisi\imeIzhod.txt";
            PrepisiDat(branje, pisanje);


        }
    }
}
