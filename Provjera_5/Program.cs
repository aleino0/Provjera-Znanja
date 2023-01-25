using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Definirajte klasu NebeskoTijelo sa sljedećim varijablama članicama:
• varijable tipa double
BrzinaOkoOsi 
BrzinaOkoSunca 
Definirajte klase Planet i Satelit izvedene iz klase NebeskoTijelo, te im definirajte sljedeće 
konstruktore:
Planet(double, double) 
Satelit(double, double) 
koji će dodijeliti vrijednosti proslijeđenih argumenata naslijeđenim varijablama članicama
Definirajte dva objekta Zemlja i Mjesec tipova Planet i Satelit.*/

namespace Provjera_5
{
    class NeboskoTijelo
    {
        public double brzinaOkoOsi;
        public double brzinaOkoSunca;
    }

    class Planet : NeboskoTijelo
    {
        public Planet(double brzinaOkoOsi, double brzinaOkoSunca)
        {
            this.brzinaOkoOsi = brzinaOkoOsi;
            this.brzinaOkoSunca = brzinaOkoSunca;

        }
    }
    class Satelit : NeboskoTijelo
    {
        public Satelit(double brzinaOkoOsi, double brzinaOkoSunca)
        {
            this.brzinaOkoOsi = brzinaOkoOsi;
            this.brzinaOkoSunca = brzinaOkoSunca;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Planet zemlja = new Planet(50.55, 16.4);
            Satelit mjesec = new Satelit(70.3, 30.24);

            Console.ReadKey();
        }
    }
}
