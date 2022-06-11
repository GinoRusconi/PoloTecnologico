using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baraja_Española.Clases
{
    internal class Carta
    {
        private int _valor;
        private string _palo;
        private string[] _tipoDePalos = new string[]
        {
            "Espada", "Basto", "Copa", "Oro"
        };
        private 
         
        #region GettersAndSetters
        public int Valor
        {
            get => _valor;
            set
            {
                if(value > 0 && value < 13)
                {
                    _valor = value;
                }
            } 
        }
        public string Palo
        {
            get => _palo;
            set
            {
                if(value != null)
                {
                    _palo = value;
                }
            }
        }
        
        public string[] TipoDePalos
        {
            get => _tipoDePalos;
        }
        #endregion
    }
}
