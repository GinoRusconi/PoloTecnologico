using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13_Billetera.Modelo
{
    internal class Billetera
    {
        private int[,] _billeteraVirtual = new int[7, 2]
        {
            {10,0},{20,0},{50,0},{100,0},{200,0},{500,0},{1000,0}
        };

        public int iD { get; set;}
        public int BilletesDe10 
        {
            get { return _billeteraVirtual[0,0]; }
            set 
            { 
                _billeteraVirtual[0,1] = value;
            }
            
        }
        public int BilletesDe20
        {
            get { return _billeteraVirtual[1, 0]; }
            set
            {
                _billeteraVirtual[1,1] = value;
            }

        }
        public int BilletesDe50
        {
            get { return _billeteraVirtual[2, 0]; }
            set
            {
                _billeteraVirtual[2,1] = value;
            }

        }
        public int BilletesDe100
        {
            get { return _billeteraVirtual[3, 0]; }
            set
            {
                _billeteraVirtual[3,1] = value;
            }

        }
        public int BilletesDe200
        {
            get { return _billeteraVirtual[4, 0]; }
            set
            {
                _billeteraVirtual[4,1] = value;
            }

        }
        public int BilletesDe500
        {
            get { return _billeteraVirtual[5, 0]; }
            set
            {
                _billeteraVirtual[5,1] = value;
            }

        }
        public int BilletesDe1000
        {
            get { return _billeteraVirtual[6, 0]; }
            set
            {
                _billeteraVirtual[6,1] = value;
            }

        }

        //Sumar billetes y devolver total
        public double Total()
        {
            double total=0;
            for (int i = 0; i < 7; i++)
            {
                total += _billeteraVirtual[i,0] * _billeteraVirtual[i,1];
            }
            return total;
        }

        // recibir una billetera y conbinar
        public Billetera Combinar(Billetera billetera1, Billetera billetera2, int idNuevaBilletera)
        {
            
            Billetera billeteraNueva = new Billetera();
            billeteraNueva.iD = idNuevaBilletera;

            for (int i = 0; i < 7; i++)
            {
                billeteraNueva._billeteraVirtual[i,1] = billetera1._billeteraVirtual[i,1] + billetera2._billeteraVirtual[i,1];
                billeteraNueva._billeteraVirtual[i,0] = billetera1._billeteraVirtual[i,0];
            }
            
            return billeteraNueva;
        }

        public void LimpiarBilletera()
        {
            for (int i = 0; i < 7; i++)
            {
                _billeteraVirtual[i, 1] = 0;
            }
        }

        public void MostrarContenidoDeBilletera()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"El contenido de la billetera {iD} es:");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Billetes De {_billeteraVirtual[i,0]}: {_billeteraVirtual[i,1]}");
            }
        }

        public void CrearBilletera(int idBilletera)
        {
            iD = idBilletera;
            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Ingrese los billetes de {_billeteraVirtual[i, 0]}:");
                
                _billeteraVirtual[i,1] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
