using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Miha je napisal metodo

static int[] Kopija(int[] t) { return t; }

ki naj bi vrnila kopijo tabele. Da bi se prepričal, kako deluje, je napisal še metodo

static void Izpisi(string ime, int[] t) { ... }

ki izpiše ime (tabele) in vse njene elemente v eni vrstici. Vse skupaj je uporabil v programu

static void Main(string[] args) {
   int[] a = {1, 2, 3}; int[] b = Kopija(a);
   Console.WriteLine("Prej: "); Izpisi("a", a); Izpisi("b", b);
   a[1] = b[2]; a[2] = b[1];
   Console.WriteLine("Potem: "); Izpisi("a", a); Izpisi("b", b);
}

A se mu račun ni čisto izšel ...

        Napiši metodo Izpisi in poglej kakšen izpis je dobil Miha.
        Popravi metodo Kopija tako, da bo program pravilno deloval.

*/

namespace Zamenjava_Elementov
{
    class ZamenjavaEL
    {
        static int[] Kopija(int[] t)
        {
            int[] kopija = new int[t.Length];
            t.CopyTo(kopija, 0);
            return kopija;
        }

        static void Izpisi(string ime, int[] t)
        {
            Console.Write(ime + ": ");
            foreach (int stevilo in t)
            {
                Console.Write(stevilo + " ");
            }
        }

        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            int[] b = Kopija(a);
            Console.WriteLine("Prej: ");
            Izpisi("a", a);
            Izpisi("b", b);
            a[1] = b[2];
            a[2] = b[1];
            Console.WriteLine("Potem: ");
            Izpisi("a", a);
            Izpisi("b", b);
        }
    }
}
