using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13_Billetera.Modelo
{
    internal class Billetera
    {
        private int[,] _billeteraVirtual = new int[2, 7];

        public int iD { get; set; }
        public int BilletesDe10 
        {
            set 
            { 
                _billeteraVirtual[0,0] = value;
            }
            
        }
        public int BilletesDe20
        {
            set
            {
                _billeteraVirtual[0,1] = value;
                _billeteraVirtual[1,1] = 20;
            }

        }
        public int BilletesDe50
        {
            set
            {
                _billeteraVirtual[0,2] = value;
                _billeteraVirtual[1,2] = 50;
            }

        }
        public int BilletesDe100
        {
            set
            {
                _billeteraVirtual[0,3] = value;
                _billeteraVirtual[1,3] = 100;
            }

        }
        public int BilletesDe200
        {
            set
            {
                _billeteraVirtual[0,4] = value;
                _billeteraVirtual[1,4] = 200;
            }

        }
        public int BilletesDe500
        {
            set
            {
                _billeteraVirtual[0,5] = value;
                _billeteraVirtual[1,5] = 500;
            }

        }
        public int BilletesDe1000
        {
            set
            {
                _billeteraVirtual[0,6] = value;
                _billeteraVirtual[1,6] = 1000;
            }

        }

        //Sumar billetes y devolver total
        public double Total()
        {
            double total=0;
            for (int i = 0; i < 7; i++)
            {
                total += _billeteraVirtual[0,i] * _billeteraVirtual[1,i];
            }
            return total;
        }

        // recibir una billetera y conbinar
        public Billetera Combinar(Billetera billetera2)
        {
            
            Billetera billeteraNueva = new Billetera();

            for (int i = 0; i < 7; i++)
            {
                billeteraNueva._billeteraVirtual[0,i] = _billeteraVirtual[0,i] + billetera2._billeteraVirtual[0,i];
                billeteraNueva._billeteraVirtual[1, i] = _billeteraVirtual[1, i];
            }
            
            return billeteraNueva;
        }

        public void MostrarContenidoDeBilletera()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"El contenido de la billetera {iD} es:");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Billetes De {_billeteraVirtual[1,i]}: {_billeteraVirtual[0,i]}");
            }
        }

    }

    
}
