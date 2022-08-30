using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Napiši metodo : void Krajsaj(int[] t), ki iz vseh števil v dani tabeli celih števil pobriše vse števke 3. 
Tako npr. iz tabele [13,23,333,112,3] nastane [1,2,112]. Metodo preveri v programu.
*/

namespace Trojk_PaNe
{
    class TrojkPaNe
    {
        /// <summary>
        /// Iz tabele t izbriše vsa števila t.
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static string Krajsaj(int[] t)
        {
            // ker izbrišemo tudi 33 ali 133, vse kar vsebuje število 3
            string[] tabela = new string[t.Length];
            for (int i = 0; i < t.Length; i++)
            {
                tabela[i] = t[i] + "";
            }

            string[] brez_trojk = new string[t.Length];
            for (int i = 0; i < tabela.Length; i++)
            {
                string stevilo = "";
                foreach (char znak in t)
                {
                    if (znak != '3')
                    {
                        stevilo += znak; ///shranim vse kar ni 3
                    }
                }
                if (stevilo != "") ///če je število sestavljeno iz samih trojk imamo prazen niz
                {
                    brez_trojk[i] = stevilo;
                }
            }

            /*int[] koncna = new int[brez_trojk.Length];
            for (int i = 0; i < brez_trojk.Length; i++)
            {
                koncna[i] = int.Parse(brez_trojk[i]);
            }

            return (koncna);
            */

            // resitev v string:
            string resitev = "";
            foreach(string st in brez_trojk)
            {
                resitev += st+"";
                
            }
            return (resitev);


    }
        static void Main(string[] args)
        {

            /*Console.WriteLine("Napiši števila ločena s presledkom");
            string niz = Console.ReadLine();
            int st_stevil = niz.Split(' ').Length;
            int[] brez = new int[st_stevil];
            for (int i = 0; i < st_stevil; i++)
            {
                brez[i] = int.Parse(niz.Split(' ')[i]);
            }
            */

            int[] primer = new int []{13, 23, 333, 112, 3};
            Console.WriteLine(Krajsaj(primer));
        }
    }
}
