using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilateros.Model
{
    internal class Trapecio : Cuadrilatero 
    {
        public Trapecio(double[,] vertices) : base(vertices) { }

        public override double CalcularArea()
        {
            Area = ((LadoA + LadoB) / 2) * Altura;
            return Area;
        }
    }
}
