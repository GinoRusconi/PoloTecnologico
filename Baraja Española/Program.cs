using Baraja_Española.Clases;

Baraja baraja = new Baraja();
Monton monton = new Monton();

int opcion;
do
{
    do
    {
        Console.WriteLine("-----------------------------");
        Console.WriteLine("1 - Barajar");
        Console.WriteLine("2 - Mostrar siguiente carta");
        Console.WriteLine("3 - Mostrar cartas disponibles");
        Console.WriteLine("4 - Dar cartas");
        Console.WriteLine("5 - Mostrar cartas del monton");
        Console.WriteLine("6 - Mostrar baraja");
        Console.WriteLine("7 - Salir");
        Console.Write("Ingrese una opcion: ");
        opcion = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        
    } while (opcion < 1 && opcion > 7);
    
    switch (opcion)
    {
        case 1:
            baraja.Barajar();
            Console.WriteLine("La Baraja ha sido barajada");
            Console.Clear();
            break;
        case 2:
            Carta? carta = baraja.SiguienteCarta();
            if(carta == null)
            {
                Console.WriteLine("Ya no hay cartas en la baraja");
                break;
            }
            Console.WriteLine("La siguiente carta es");
            switch (carta.Palo)
            {
                case "Espada":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "Copa":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "Oro":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "Basto":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
            }
            Console.WriteLine($"{carta.Valor} de {carta.Palo}");
            monton.DescartarCarta(carta);
            Console.ForegroundColor = ConsoleColor.Gray;
            break;
        case 3:
            int cartasDisponibles = baraja.CartasDisponibles();
            Console.WriteLine($"Quedan {cartasDisponibles} cartas disponibles en la baraja");
            break;
        case 4:
            Console.WriteLine("¿Cuantas cartas desea repartir?");
            int cantidadDeCartas = Convert.ToInt32(Console.ReadLine());
            Carta[]? cartas = baraja.DarCartas(cantidadDeCartas);

            if (cartas == null)
            {
                Console.WriteLine("Quedan menos de la cantidad de cartas solicitadas");
                break;
            }
            Console.WriteLine("Las siguientes cartas son: ");
            MostrarCartasObtenidas(cartas);
            monton.DescartarCarta(cartas);
            break;
        case 5:
            Carta[]? cartasDelMonton = monton.CartasDelMonton();
            if (cartasDelMonton == null)
            {
                Console.WriteLine("Aun no hay cartas en el monton");
                break;
            }
            Console.WriteLine("Las cartas del monton son:");
            MostrarCartasObtenidas(cartasDelMonton);
            break;
        case 6:
            if(baraja.CartasEnBaraja == null)
            {
                Console.WriteLine("Ya no quedan cartas en la baraja");
            }
            MostrarCartasObtenidas(baraja.CartasEnBaraja);
            break;
    }

} while (opcion != 7);

Console.ReadLine();

static void MostrarCartasObtenidas(Carta[]? cartas)
{
    foreach (Carta item in cartas)
    {
        switch (item.Palo)
        {
            case "Espada":
                Console.ForegroundColor = ConsoleColor.Cyan;
                break;
            case "Copa":
                Console.ForegroundColor = ConsoleColor.Red;
                break;
            case "Oro":
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;
            case "Basto":
                Console.ForegroundColor = ConsoleColor.Green;
                break;
        }
        Console.WriteLine($"{item.Valor} de {item.Palo}");
    }
    Console.ForegroundColor = ConsoleColor.Gray;
}
