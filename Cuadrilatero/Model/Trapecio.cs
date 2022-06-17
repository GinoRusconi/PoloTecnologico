using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilatero.Model
{
    internal class Trapecio : Cuadrilatero
    {
        private decimal _altura;

        #region Setts and Getters
        public decimal Altura 
        {
            get { return _altura; } 
            set { _altura = value; } 
        }
        #endregion

        public Trapecio() : base()
        {
            Console.WriteLine("Ingrese Altura");
            Y = SetMedidas("lado Y");
            Altura = SetMedidas("Altura");
        }
        
        public override decimal CalcularArea()
        {
            Area = ((X + Y) / 2)* Altura;
            return Area;
        }
    }
}
