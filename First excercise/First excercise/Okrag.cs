using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_excercise
{
    class Okrag : Figury
    {
        public override double ObliczPole()
        {
            pole = 3.14 * r * r;
            return pole;
        }
    }

}
