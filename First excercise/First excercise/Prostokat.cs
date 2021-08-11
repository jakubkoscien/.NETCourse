using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_excercise
{
    class Prostokat : Figury
    {
        private double _a { get; set; }
        private double _b { get; set; }
        public Prostokat(double a, double b)
        {
            _a = a;
            _b = b;
        }

        public override double ObliczPole()
        {
            pole = _a * _b;
            return pole;
        }
    }

}
