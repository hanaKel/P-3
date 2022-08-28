using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razred_Racun
{
    /// <summary>
    /// razred Racun, ki ima privatno polje valuta tipa string, ter privatni polji stanje in tecaj, obe tipa double. 
    /// </summary>
    public class Racun
        {
            private string valuta;
            private double stanje;
            private double tecaj;

        /// <summary>
        /// konstruktor, ki dobi podani vrednosti za polji valuta ter tecaj, trenutno stanje na računu pa nastavi na 0. 
        /// </summary>
        /// <param name="valuta"></param>
        /// <param name="tecaj"></param>
        public Racun(string valuta, double tecaj)
            {
                this.valuta = valuta;
                this.tecaj = tecaj;
                this.stanje = 0;
            }


        public override string ToString()
            {
                return $"Stanje: {this.stanje}{this.valuta}, kar je {this.StanjeEUR}EUR";
            }

        /// <summary>
        /// lastnost StanjeEUR tipa double, ki vrne stanje na računu v evrih. 
        /// Stanja na računu preko te lastnosti ne moremo spreminjati. 
        /// </summary>
        public double StanjeEUR
            {
                get { return this.stanje * this.tecaj; }
            }

        /// <summary>
        /// javno metodo Polog, ki kot argument dobi znesek v evrih tipa double, ki ga položimo na račun. 
        /// Pri tem se opravi pretvorba v valuto, ki se shranjuje na računu. 
        /// </summary>
        /// <param name="znesek_v_eur"></param>
        public void Polog(double znesek_v_eur)
            {
                this.stanje += znesek_v_eur / this.tecaj;
            }

            static void Main(string[] args)
            {
            }
        }
    }

