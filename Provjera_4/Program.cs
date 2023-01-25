using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Napišite program koji će za definirani niz tipa double pronaći član koji najmanje odstupa od 
prosječne vrijednosti niza. Program mora raditi ispravno za proizvoljni broj članova niza.*/

namespace Provjera_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] niz = { 5.7, 4.9, 10.6, 7.77, 1.48, 15.73 };
            double prosjek = 0;
            double najblizi= niz[0];
            double a, b;

            for (int i = 0; i < niz.Length; i++)
            {
                prosjek += niz[i];
            }
            prosjek = prosjek / niz.Length;

            for (int i = 0; i < niz.Length-1; i++)
            {
                a = Math.Abs(prosjek - niz[i]);
                b = Math.Abs(prosjek - niz[i + 1]);
                if (a<b)
                {
                    najblizi=niz[i];
                }
                else
                {
                    if(Math.Abs(prosjek - niz[i + 1]);)
                    najblizi = niz[i + 1];
                }
            }

            Console.WriteLine(najblizi);

            

            Console.ReadKey();
        }
    }
}
