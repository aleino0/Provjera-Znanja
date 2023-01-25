using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Fibonaccijev niz definiran je na sljedeći način: 
• prvi član niza je 0 
• drugi član niza je 1 
• svaki sljedeći član niza jednak je zbroju prethodna dva člana 
Napišite program koji će zatražiti od korisnika da unese broj n, te će izračunati n-ti član 
Fibonaccijevog niza.*/

namespace Provjera_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int konacni=0;

            Console.WriteLine("Unesite broj");
            int broj=Convert.ToInt32(Console.ReadLine());
            int[] fib= new int[broj+5];
            fib[0] = 0;
            fib[1] = 1;

            for (int i = 0; i < broj;i++)
            {
                fib[i + 2] = fib[i] + fib[i + 1];
                konacni =fib[i+2];
            }

            Console.WriteLine(broj + ". član Fibonaccijevog niza je " + konacni);

            Console.ReadKey();
        }
    }
}
