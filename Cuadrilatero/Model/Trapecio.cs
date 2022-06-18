using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilatero.Model
{
    internal class Trapecio : Cuadrilatero 
    {
        public Trapecio() : base() { }

        public override double CalcularArea()
        {
            Area = ((LadoA + LadoB) / 2) * Altura;
            return Area;
        }
    }
}
