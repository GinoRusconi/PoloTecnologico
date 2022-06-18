using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilatero.Model
{
    internal class Cuadrado : Cuadrilatero
    {
        public Cuadrado() : base() { } 

        public override double CalcularArea()
        {
            Area = Math.Pow(LadoA, 2);
            return Area;
        }
    }

}
