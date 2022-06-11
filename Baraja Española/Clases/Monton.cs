namespace Baraja_Española.Clases
{
    internal class Monton
    {
        private List<Carta> _montonDeCartas = new List<Carta>();


        public void DescartarCarta(Carta cartaDescartada)
        {
            _montonDeCartas.Add(cartaDescartada);
        }

        public void DescartarCarta(Carta[] cartasDescartadas)
        {
            foreach (Carta carta in cartasDescartadas)
            {
                _montonDeCartas.Add(carta);
            }
        }

        public Carta[]? CartasDelMonton()
        {
            if (_montonDeCartas.Count == 0) return null;
            return _montonDeCartas.ToArray();
        }
    }
}
