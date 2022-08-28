using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razred_Vektor2
{

    /// <summary>
    /// Definiraj razred Vektor, ki predstavlja dvodimenzionalen vektor z lastnostmi X, Y  tipa int, ki 
    /// predstavljata prvo, drugo komponento vektorja. Lastnosti naj bo mogoče javno brati in nastavljati.  
    /// </summary>

    //Dodaj konstruktor, ki dobi podane vse komponente vektorja
    public class Vektor
    {
        private int x;
        private int y;
        
        static void Main(string[] args)
        {
        }

        public Vektor(int a, int b)
        {
            this.x = a;
            this.y = b;
            
        }

        

        public int komponenta_x
        {
            get { return this.x; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Vektor mora biti v prvem oktantu");
                }
                this.x = value;
            }
        }

        public int komponenta_y
        {
            get { return this.y; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Vektor mora biti v prvem oktantu");
                }
                this.y = value;
            }
        }



        /// <summary>
        /// Dodaj javno lastnost Dolžina tipa double, 
        /// ki predstavlja dolžino vektorja. Lastnost naj bo mogoče javno brati, nastavljati pa seveda ne. 
        /// </summary>
        public double Dolzina
        {
            get { return Math.Pow(Math.Pow(this.x, 2) + Math.Pow(this.y, 2) , 0.5); }
        }

        /// <summary>
        /// Razredu redefiniraj metodo ToString tako, da bo kompleksno število
        /// predstavljeno z nizom "(X, Y, Z)"  (npr. "(2, 3, 1)". 
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
            return $"({this.x}, {this.y})";
        }

        /// <summary>
        /// Definiraj operator + tako, da bo izraz z + u vrnil nov objekt razreda vektor, ki bo vsota vektorjev z in u. 
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static Vektor operator +(Vektor v1, Vektor v2)
        {
            Vektor u = new Vektor(v1.x + v2.x, v1.y + v2.y);
            return u;
        }
    }
}