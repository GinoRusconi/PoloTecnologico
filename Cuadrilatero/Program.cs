using Cuadrilatero.Model;


int opcion;
do
{
    do
    {
        Console.WriteLine("***************************");
        Console.WriteLine("Elija que tipo de cuadrilatero \n" +
                          "desea calcular su area");
        Console.WriteLine("1- Cuadrado");
        Console.WriteLine("2- Rectangulo");
        Console.WriteLine("3- Trapecio");
        Console.WriteLine("4- Salir");
        opcion = int.Parse(Console.ReadLine());

    } while (opcion <0 && opcion > 5);

    switch (opcion)
    {
        case 1:
            Cuadrado cuadrado = new Cuadrado();
            Console.WriteLine($"El area del Cuadrado es: {cuadrado.CalcularArea()}");
            break;
        case 2:
            Rectangulo rectangulo = new Rectangulo();
            Console.WriteLine($"El area del Rectangulo es: {rectangulo.CalcularArea()}");
            break;
        case 3:
            Trapecio trapecio = new Trapecio();
            Console.WriteLine($"El area del Trapecio es: {trapecio.CalcularArea()}");
            break;
    }
    Console.WriteLine("Presione una tecla para continuar");
} while (opcion != 4);
