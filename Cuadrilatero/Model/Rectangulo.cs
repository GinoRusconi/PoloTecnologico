using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilatero.Model
{
    internal class Rectangulo : Cuadrilatero
    {
        public Rectangulo () : base()
        {
            Y = SetMedidas("lado Y"); 
        }

        public override double CalcularArea()
        {
            Area = X * Y;
            return Area;
        }
    }
}
