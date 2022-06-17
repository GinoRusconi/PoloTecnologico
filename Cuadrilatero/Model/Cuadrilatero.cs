using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilatero.Model
{
    internal abstract class Cuadrilatero
    {
        private double _x;
        private double _y;
        private double _area;

        #region Setts and Getters
        public double X 
        {
            get { return _x; } 
            set { _x = (value > 0) ? value : 0; }
        }
        public double Y 
        {
            get { return _y; }
            set { _y = (value > 0) ? value : 0; } 
        }

        public double Area
        {
            get { return _area; }
            set { _area = value; }
        }
        #endregion

        public Cuadrilatero()
        {
            X = SetMedidas("lado X");
        }

        protected double SetMedidas(String nombreDelLado)
        {
            bool checkValue;
            double valorTesteado = 0;
            do
            {
                Console.WriteLine($"Ingrese {nombreDelLado}");
                checkValue = double.TryParse(Console.ReadLine(), out double valor);
                checkValue = (checkValue && valor > 0);
                if (!checkValue) Console.WriteLine("El valor ingresado no es un nuemero, o es mayor a 0");
                else valorTesteado = valor;

            } while (!checkValue);

            return valorTesteado;
        }

        public abstract double CalcularArea();
    }
}
