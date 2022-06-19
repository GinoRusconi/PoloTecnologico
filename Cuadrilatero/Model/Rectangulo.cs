using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilateros.Model
{
    internal class Rectangulo : Cuadrilatero
    {
        public Rectangulo(double[,] vertices) : base(vertices) { }

        public override double CalcularArea()
        {
            Area = LadoA * Altura;
            return Area;
        }
    }
}
