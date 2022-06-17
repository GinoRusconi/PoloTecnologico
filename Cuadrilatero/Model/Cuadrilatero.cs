using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilatero.Model
{
    internal abstract class Cuadrilatero
    {

        private double[,] _Vertices = new double[4,2];

        private double _Area;

        #region Setts and Getters
        public double[,] Cordenadas
        {
            get { return _Vertices;}
            set { _Vertices = value; }
        }
        public double Area 
        { 
            get { return _Area;} 
            set { _Area = value; }
        }
        #endregion

        public Cuadrilatero()
        {
            for (int Vertice = 0; Vertice < 4; Vertice++)
            {
                for (int cordenada = 0; cordenada < 2; cordenada++)
                {
                    bool checkValue;
                    do
                    {
                        Console.WriteLine($"Ingrese la cordenada {((cordenada == 0) ? 'x': 'y')} del vertice {Vertice+1}");
                        checkValue = double.TryParse(Console.ReadLine(), out double valor);
                        if (!checkValue) Console.WriteLine("El valor ingresado no es un nuemero");
                        else Cordenadas[Vertice,cordenada] = valor;
                    } while (!checkValue);
                }
            }
        }
        public abstract double CalcularArea();
    }
}
