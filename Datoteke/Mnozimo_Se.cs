using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Datoteke_mnozimoSe
{
    class Mnozimo_Se

    {
        public static string Zmnozek(string imeVhod)
        {
            StreamReader branje;
            try
            {
                branje = new StreamReader(imeVhod);
            }
            catch (Exception)
            {
                throw new Exception("Datoteke za branje ni mogoče najti!");
            }



            //string vrstica = branje.ReadLine();
            string[] vrstice = System.IO.File.ReadAllLines(@imeVhod);
            //int dolz = vrstice.Length;
            //List<char> stevila = (new char[dolz]).ToList();
            

            int stevec = 1;
            int imenovalec = 1;


            foreach (string vrstica in vrstice)
            {
                
                // če je v vrstici 1 znak / imamo ulomek
                if (vrstica.Contains("/"))
                {
                    string[] razbitje = vrstica.Split('/');
                    if ( razbitje.Length == 2)
                    {
                        
                        int stevec2 = int.Parse(razbitje[0]);
                        int imenovalec2 = int.Parse(razbitje[1]);
                        stevec = stevec * stevec2;
                        imenovalec = imenovalec * imenovalec2;
                    }
                    else  // to je nekaj čudnega v vrstici, če je več /
                    {
                        continue;
                    }
                }


                //sicer gledamo kot na cel ulomek oz. stevilo
                // ce se ne da, sprozi izjemo. npr v neki vrstici je string
                try
                {
                    
                    int stevec2 = int.Parse(vrstica);
                    stevec = stevec * int.Parse(vrstica);
                }
                catch (Exception)
                {
                    continue;
                }
            }

            if (imenovalec==1)
            {
                return $"{stevec}";
            }
            return $"{stevec}/{imenovalec}";
        }

        
        static void Main(string[] args)
        {
            // primer iz navodil naloge
            //string primer1 = Zmnozek(@"C:\Users\Ldon Kranjec\source\repos\KolikoNajvecjih\Datoteke_mnozimoSe\stevila.txt");
            //Console.WriteLine(primer1);
            // primer, kjer ni datoteke podane
            //string primer2 = Zmnozek(@"C:\Users\Ldon Kranjec\source\repos\KolikoNajvecjih\Datoteke_mnozimoSe\stevila123.txt");
            //Console.WriteLine(primer2);
            // primer, kjer so v datoteki tudi stringi 
            string primer3 = Zmnozek(@"C:\Users\Ldon Kranjec\source\repos\KolikoNajvecjih\Datoteke_mnozimoSe\stevila1.txt");
            Console.WriteLine(primer3);



        }
    }
}
