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

        private double _LadoA;
        private double _LadoB;
        private double _Altura;
        private double _Area;

        #region Setts and Getters
        public double[,] Vertices
        {
            get { return _Vertices;}
            set { _Vertices = value; }
        }
        public double Area 
        { 
            get { return _Area;} 
            set { _Area = value; }
        }

        public double LadoA 
        {
            get { return _LadoA;} 
            set { _LadoA = value;} 
        }
        public double LadoB
        {
            get { return _LadoB; }
            set { _LadoB = value; }
        }
        public double Altura
        {
            get { return _Altura; }
            set { _Altura = value; }
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
                        else Vertices[Vertice,cordenada] = valor;
                    } while (!checkValue);
                }
            }

            LadoA = Vertices[1,0] - Vertices[0,0];
            Altura = Vertices[1,1] - Vertices[2,1];
            LadoB = Vertices[2,0] - Vertices[3,0];
        }
        public abstract double CalcularArea();
    }
}
