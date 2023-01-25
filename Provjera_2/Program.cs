using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Napišite program koji će zatražiti od korisnika da unese dva stringa, te će ih ispisati po
    abecedi u uzlaznom redoslijedu.*/

namespace Provjera_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("unesite 1. string:");
            string prvi = Console.ReadLine();

            Console.WriteLine("unesite 1. string:");
            string drugi = Console.ReadLine();

            do
            {
                if (prvi[i]<drugi[i])
                {
                    Console.WriteLine(prvi + " " + drugi);
                    break;
                }
                else if(prvi[i]>drugi[i])
                {
                    Console.WriteLine(drugi + " " + prvi);
                    break;
                }
                else
                {
                    Console.WriteLine("Stringovi su isti");
                }

                i++;
            } while (i<=prvi.Length || i<=drugi.Length);

            Console.ReadKey();
        }
    }
}
