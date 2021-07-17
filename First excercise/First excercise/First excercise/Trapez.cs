using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_excercise
{
    class Trapez : Figury
    {
        public override double ObliczPole()
        {
            pole = ((a + b) * h) / 2;
            return pole;
        }
    }

}
