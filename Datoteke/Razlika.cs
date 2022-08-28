using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izjeme
{
    class ViveLaDifference

    {
        /// <summary>
        /// program, ki uporabnika vpraša po dveh številih: zmanjševancu in odštevancu. 
        /// </summary>
        /// <returns></returns>
        public static double Razlika()
        {
            double zmanjsevanec;
            double odstevanec;

            // Obe števili morata biti realni števili
            try
            {
                Console.Write("Zmanjševanec: ");
                zmanjsevanec = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                throw new Exception("Zmanjševanec mora biti realno število!");
            }

            try
            {
                Console.Write("Odštevanec: ");
                odstevanec = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                throw new Exception("Odštevanec mora biti realno število!");
            }

            // Obe števili morata biti nenegativni števili

            if (zmanjsevanec < 0)
            {
                throw new Exception("Zmanjševanec mora biti nenegativno število!");
            }


            if (odstevanec < 0)
            {
                throw new Exception("Odštevanec mora biti nenegativno število!");
            }

            // odštevanec manjši ali enak zmanjševancu
            if (odstevanec > zmanjsevanec)
            {
                throw new Exception("Odštevanec mora biti manjši od zmanjševanca!");
            }

           double razlika = zmanjsevanec - odstevanec;
            return razlika;




        }
        static void Main(string[] args)
        {
            Console.WriteLine(Razlika());
        }
    }
}
