using System;


namespace Knjiznjica_Metod
{
    class Knjiznica
    {
        /// <summary>
        /// tabelo spremeni tako, da je dvojne velikosti ter
        /// ohrani elemente
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static int[] PodvojiVelikost(int[] t)
        {
            // podvojimo tabelo
            int[] tabela = new int[t.Length * 2]; 
            foreach (int i in t)
            {
                tabela[i] = tabela[i];
            }
            t = tabela;
            return tabela;

        }
        /// <summary>
        /// Vrne tabelo dolžine d, ki ima naključna cela števila med 1 in m
        /// </summary>
        /// <param name="d"> dolžina tabele</param>
        /// <param name=""></param>
        /// <returns></returns>
        public static int[] NakljucnaTabela(int d, int m)
        {
            int[] t = new int[d];
            Random st = new Random();
            for (int i = 0; i < d; i++)
            {

                t[i] = st.Next(d);
            }
            return t;
        }
        /// <summary>
        /// iz tabele celih števil naredi niz, sestavljen iz elementov tabele
        /// ločenih s presledki
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static string TabelaKotNiz(int[] t)
        {
            string niz = "";
            foreach (int i in t)
            {
                niz += i + " ";
            }

            return niz;
        }
        /// <summary>
        /// iz niza naredi tabelo celih števil
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int[] NizKotTabela(string s)
        {
            string[] t = s.Split(' ');
            int[] tabela = new int[t.Length];
            for (int i = 0; i < t.Length; i++)
            {
                tabela[i] = int.Parse(t[i]);
            }
            return tabela;
        }

        static void Main(string[] args)
        {
            int[] t = { 1, 2, 3 };
            Console.WriteLine(TabelaKotNiz(t));
            Console.WriteLine(PodvojiVelikost(t));
            Console.WriteLine(NakljucnaTabela(2, 13));
            Console.WriteLine(NizKotTabela("1 3 4 2"));

        }
    }
}
