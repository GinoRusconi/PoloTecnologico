using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilateros.Model
{
    internal class Cuadrado : Cuadrilatero
    {
        public Cuadrado(double[,] vertices) : base(vertices) { } 

        public override double CalcularArea()
        {
            Area = Math.Pow(LadoA, 2);
            return Area;
        }
    }

}
