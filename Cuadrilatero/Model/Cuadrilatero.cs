using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilatero.Model
{
    internal abstract class Cuadrilatero
    {

        private double[,] _Vertices;

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

        public Cuadrilatero(double[,] vertices)
        {
            Vertices = vertices;


            LadoA = Vertices[1,0] - Vertices[0,0];
            Altura = Vertices[1,1] - Vertices[2,1];
            LadoB = Vertices[2,0] - Vertices[3,0];
        }

        public abstract double CalcularArea();
    }
}
