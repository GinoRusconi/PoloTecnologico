namespace Baraja_Española.Clases
{
    internal class Baraja
    {
        private List<Carta> _cartasEnBaraja = new List<Carta>();
        public Baraja()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Carta nuevaCarta = new Carta();
                    nuevaCarta.Palo = nuevaCarta.TipoDePalos[i];
                    nuevaCarta.Valor = j + 1;
                    _cartasEnBaraja.Add(nuevaCarta);    
                    //saltea el 8 y 9
                    if(j == 6) j += 2;
                }
            }
        }

        public Carta[]? CartasEnBaraja 
        { 
            get
            {
                return _cartasEnBaraja.ToArray(); 
            } 
        }
        public void Barajar()
        {
            Random numRandom = new Random();

            for (int VecesBarajada = 0; VecesBarajada < 5; VecesBarajada++)
            {
                for (int posicion = 0; posicion < _cartasEnBaraja.Count; posicion++)
                {
                    int nuevaPosicion = numRandom.Next(0, _cartasEnBaraja.Count);
                    if (posicion == nuevaPosicion) continue;

                    Carta cartaAux = _cartasEnBaraja[nuevaPosicion];
                    _cartasEnBaraja[nuevaPosicion] = _cartasEnBaraja[posicion];
                    _cartasEnBaraja[posicion] = cartaAux;

                }
            }
        }

        public Carta? SiguienteCarta()
        {
            if (_cartasEnBaraja.Count == 0) return null;

            Carta carta = _cartasEnBaraja[_cartasEnBaraja.Count - 1];
            _cartasEnBaraja.RemoveAt(_cartasEnBaraja.Count - 1);
            return carta;
        }

        public int CartasDisponibles()
        {
            return _cartasEnBaraja.Count;
        }

        public Carta[]? DarCartas(int cantidadDeCartas)
        {
            if (cantidadDeCartas > _cartasEnBaraja.Count) return null;

            Carta[] cartas = new Carta[cantidadDeCartas];

            for (int i = 0; i < cantidadDeCartas; i++)
            {
                cartas[i] = _cartasEnBaraja[_cartasEnBaraja.Count - 1];
                _cartasEnBaraja.RemoveAt(_cartasEnBaraja.Count - 1);
            }

            return cartas;
        }
    }
}
