using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_excercise
{
    abstract class Figury
    {
        public abstract double ObliczPole();

        public double pole, a, b, h, r;

        public static void koniec()
        {
            Console.WriteLine("Nacisnij dowolny przycisk aby kontynuowac...\n");
            Console.ReadKey();
        }

    }

}
