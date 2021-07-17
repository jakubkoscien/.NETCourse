using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_excercise
{
    class Trojkat : Figury
    {
        public Trojkat(double a, double h)
        {
            this.a = a;
            this.h = h;
        }
        public override double ObliczPole()
        {
            pole = (a * h) / 2;
            return pole;
        }
    }

}
