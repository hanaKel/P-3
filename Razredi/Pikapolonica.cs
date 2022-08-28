using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razred_Pikapolonica
{
    public class Pikapolonica

    {
        // Življenjska doba pikapolonic se giblje okoli treh let.
        // Vse pikapolonice imajo 7 pik, a jim s starostjo lahko pike zbledijo.
        private int _starost; 
        private int _stevilo_pik;

        public int Starost
        {
            get { return this._starost; }
            set
            {
                if (value < 0 || value > 300) //50 tednov v letu * 3, ker je povprečje 3 ( recimo, da je 6 max.)
                {
                    throw new Exception("Starost pikapolonice je nesmiselna!");
                }
                this._starost = value;
            }
        }

        public int SteviloPik
        {
            get { return this._stevilo_pik; }
            set
            {
                if (value < 0 || value > 7)
                {
                    throw new Exception("Stevilo pik je nesmiselno");
                }
                this._stevilo_pik = value;
            }
        }

        public Pikapolonica(int starost, int stevilo_pik)
        {
            this.Starost = starost;
            this.SteviloPik = stevilo_pik;
        }

        public void NastaviSteviloPik(int st_pik)
        {
            this.SteviloPik = st_pik;
        }

        // metoda, ki bo omogočila, da bomo objekt tipa Polonica
        // pretvorili v niz "Jaz sem PikaPoka, stara m tednov in imam n pik", kjer je m starost pikapolonice in n število njenih pik

        public override string ToString()
        {
            return $"Jaz sem PikaPoka, stara {this.Starost} tednov in imam {this.SteviloPik} pik";
        }

        // Definiraj operator * tako, da bosta izraza 5 * polonca in  polonca * 5 vrnil tabelo
        // 5 novih klonov pikapolonice polonca. V primeru nesmiselnih vrednosti operandov sproži napako!

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mnozitelj"></param>
        /// <param name="mnozenec"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static Pikapolonica[] operator *(Pikapolonica mnozitelj, int mnozenec)
        {
            if (mnozenec < 0)
            {
                throw new Exception("Negativno število kopij! ");
            }
            Pikapolonica[] tabela_kopij = new Pikapolonica[mnozenec];
            for (int i = 0; i < mnozenec; i++)
            {
                tabela_kopij[i] = new Pikapolonica(mnozitelj.Starost, mnozitelj.SteviloPik);
            }
            return tabela_kopij;
        }


        // Sestavi metodo public static int steviloPik(PikaPolonica[] pikapolonice), 
        // ki vrne skupno število pik na vseh pikapolonic, ki so starejše od enega leta.

        /// <summary>
        ///  Vsota
        /// </summary>
        /// <param name="tabela"></param>
        /// <returns></returns>
        public static int VsotaPik(Pikapolonica[] tabela)
        {
            int vsota = 0;
            foreach (Pikapolonica posamezna in tabela)
            {
                if (posamezna.Starost > 52)
                {
                    vsota += posamezna.SteviloPik;
                }
            }
            return vsota;
        }


        static void Main(string[] args)
        {
        }
    }
}
