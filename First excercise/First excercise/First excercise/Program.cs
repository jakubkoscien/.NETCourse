using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_excercise
{
    /*
        Zadanie 1.1 
        Napisz program, który oblicza pole prostokąta. 
        Wartości boków można podać z klawiatury. 
        (Opcjonalnie) Jako rozwinięcie aplikacji można dodać obliczenia dla innych figur.
    */
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Jakie pole chcesz obliczyc?\n");
                Console.WriteLine("1. Kwadrat\n");
                Console.WriteLine("2. Trojkat\n");
                Console.WriteLine("3. Trapez\n");
                Console.WriteLine("4. Okrag\n");
                int wybor = Convert.ToInt32(Console.ReadLine());
                
                switch (wybor)
                {
                    case 1:

                        Console.WriteLine("Podaj dlugosci bokow prostokata:\n");
                        double bokA = Convert.ToDouble(Console.ReadLine());
                        double bokB = Convert.ToDouble(Console.ReadLine());

                        Prostokat pr = new Prostokat(bokA, bokB);
                        Console.WriteLine(pr.ObliczPole());

                        Figury.koniec();
                        
                        break;

                    case 2:

                        Console.WriteLine("Wpisz dlugosc podstawy i wysokosc trojkata:\n");
                        double trojA = Convert.ToDouble(Console.ReadLine());
                        double trojH = Convert.ToDouble(Console.ReadLine());

                        Trojkat troj = new Trojkat(trojA, trojH);
                        Console.WriteLine(troj.ObliczPole());

                        Figury.koniec();

                        break;

                    case 3:

                        Console.WriteLine("Wpisz dlugosci podstaw trapezu oraz jego wysokosc\n");
                        Trapez tra = new Trapez();
                        tra.a = Convert.ToDouble(Console.ReadLine());
                        tra.b = Convert.ToDouble(Console.ReadLine());
                        tra.h = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(tra.ObliczPole());

                        Figury.koniec();

                        break;

                    case 4:

                        Console.WriteLine("Wpisz dlugosc promienia kola:\n");
                        Okrag okr = new Okrag();
                        okr.r = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(okr.ObliczPole());

                        Figury.koniec();

                        break;

                }

            }

            

        }
    }
}
