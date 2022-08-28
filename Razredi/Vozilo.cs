using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razred_Vozilo
{
    public class Vozilo
    {
        // Razred Vozilo s privatnimi polji gorivo, kapaciteta, poraba
        private double gorivo; //litri
        private double kapaciteta; //litri
        private double poraba;  //litri na 100 km

        /// <summary>
        /// konstruktor, ki dobi podani vrednosti za polji kapaciteta ter poraba, 
        /// trenutno zalogo goriva pa nastavi kar enako kapaciteti. V primeru nesmiselnih podatkov sproži izjemo!
        /// </summary>
        /// <param name="kapaciteta"></param>
        /// <param name="poraba"></param>
        /// <exception cref="Exception"></exception>
        public Vozilo(double kapaciteta, double poraba)
        {
            if (kapaciteta < 0)
            {
                throw new Exception("Kapaciteta ne more biti negativna!");
            }

            if (poraba <= 0 || poraba > kapaciteta)
            {
                throw new Exception("Podana je nesmiselna poraba vozila");
            }

            this.gorivo = kapaciteta;
            this.kapaciteta = kapaciteta;
            this.poraba = poraba;
        }

       
        public override string ToString()
        {
            return $"Avto z kapaciteto tanka: {this.kapaciteta}l ima še {this.gorivo}l goriva njegova poraba je {this.poraba}l/100km";
        }

        public double GetGorivo()
        {
            return this.gorivo;
        }

        /// <summary>
        /// lastnost PreostaliKilometri tipa double, ki vrne število kilometrov, ki jih vozilo še lahko prevozi s trenutno zalogo goriva. 
        /// </summary>
        public double PreostaliKilometri
        {
            get { return this.gorivo / this.poraba * 100; }
        }

        /// <summary>
        /// metodo Crpalka, ki vozilo napolni z gorivom.  Polnimo vedno "polno". 
        /// </summary>
        public void Crpalka()
        {
            this.gorivo = this.kapaciteta;
        }

        /// <summary>
        /// metodo, ki sprejme tabelo števil tipa double, ki predstavlja zaporedje dolžin poti (v kilometrih), ki jih želimo opraviti z vozilom. Pri tem število 0 predstavlja točenje goriva na bencinski črpalki.  
        /// Torej [200, 0, 100, 60, 0, 100] opisuje pot, kjer najprej vozimo 200 km, nato polnimo, prevozimo 100, nato še 60 km, polnimo in vozimo še 100km.
        /// </summary>
        /// <param name="poti"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool Prevozi(double[] poti)
        {
            double trenutno = this.gorivo;
            foreach (double pot in poti)
            {
                if (pot < 0)
                {
                    throw new Exception("Pot ne more biti negativna");
                }

                if (pot == 0)
                {
                    if (trenutno == this.kapaciteta)
                    {
                        throw new Exception("Imaš poln tank. ");
                    }
                    else
                    {
                        
                        trenutno = this.kapaciteta;
                    }
                }

                trenutno -= pot / 100 * this.poraba;
                if (trenutno < 0)
                {
                    return false;
                }

            }
            this.gorivo = trenutno;
            return true;
        }

        static void Main(string[] args)
        {
        }
    }
}
