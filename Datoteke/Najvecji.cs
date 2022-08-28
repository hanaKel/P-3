using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericniTipi_KolikoNajvecjih
{
     public class Najvecji
        {
        /// <summary>
        /// Napiši metodo, ki za poljubno tabelo objektov, ki jih lahko 
        /// med sabo primerjamo, vrne število elementov, ki so enaki največjemu elementu. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tabela"></param>
        /// <returns></returns>
        public static int StNajvecji<T>(T[] tabela) where T : IComparable
        
        {
            if (tabela.Length == 0)
            {
                return 0;
            }
            //zacetne vrednosti
            int st = 1;
            T trenutno_najvecji = tabela[0];

            for (int i = 1; i<tabela.Length; i++)
            {
                if (tabela[i].CompareTo(trenutno_najvecji) > 0)
                {
                    //Ce smo nasli vecjega
                    st = 1;
                    trenutno_najvecji = tabela[i];
                }
                else if (tabela[i].CompareTo(trenutno_najvecji) == 0)
                  {
                    st++;
                  }
            }
            return st;
            
        }


        static void Main(string[] args)
        {

        }
    }
}
