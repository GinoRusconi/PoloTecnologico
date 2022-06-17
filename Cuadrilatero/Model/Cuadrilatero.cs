using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilatero.Model
{
    internal abstract class Cuadrilatero
    {
        private decimal _x;
        private decimal _y;
        private decimal _area;

        #region Setts and Getters
        public decimal X 
        {
            get { return _x; } 
            set { _x = (value > 0) ? value : 0; }
        }
        public decimal Y 
        {
            get { return _y; }
            set { _y = (value > 0) ? value : 0; } 
        }

        public decimal Area
        {
            get { return _area; }
            set { _area = value; }
        }
        #endregion

        public Cuadrilatero()
        {
            X = SetMedidas("lado X");
        }

        protected decimal SetMedidas(String nombreDelLado)
        {
            bool checkValue;
            decimal valorTesteado = 0;
            do
            {
                Console.WriteLine($"Ingrese {nombreDelLado}");
                checkValue = decimal.TryParse(Console.ReadLine(), out decimal valor);
                checkValue = (checkValue && valor > 0);
                if (!checkValue) Console.WriteLine("El valor ingresado no es un nuemero, o es mayor a 0");
                else valorTesteado = valor;

            } while (!checkValue);

            return valorTesteado;
        }

        public abstract decimal CalcularArea();
    }
}
