using Cuadrilateros.Model;


int opcion;
do
{
    do
    {
        Console.WriteLine("***************************");
        Console.WriteLine("Elija que tipo de cuadrilatero \n" +
                          "desea calcular su Area");
        Console.WriteLine("1- Cuadrado");
        Console.WriteLine("2- Rectangulo");
        Console.WriteLine("3- Trapecio");
        Console.WriteLine("4- Salir");
        opcion = int.Parse(Console.ReadLine());

    } while (opcion <0 && opcion > 5);

    Console.Clear();
    switch (opcion)
    {
        case 1:
            Console.WriteLine("1***********2");
            Console.WriteLine("*           *");
            Console.WriteLine("*           *");
            Console.WriteLine("*           *");
            Console.WriteLine("*           *");
            Console.WriteLine("4***********3");
            Cuadrado cuadrado = new Cuadrado(ObtenerCoordenadas());
            MostrarArea(cuadrado);
            break;
        case 2:
            Console.WriteLine("1*****************2");
            Console.WriteLine("*                 *");
            Console.WriteLine("*                 *");
            Console.WriteLine("*                 *");
            Console.WriteLine("4*****************3");
            Rectangulo rectangulo = new Rectangulo(ObtenerCoordenadas());
            MostrarArea(rectangulo);
            break;
        case 3:
            Console.WriteLine("      1***********2");
            Console.WriteLine("     *             *");
            Console.WriteLine("    *               *");
            Console.WriteLine("   *                 *");
            Console.WriteLine("  *                   *");
            Console.WriteLine(" *                     *");
            Console.WriteLine("4***********************3");
            Trapecio trapecio = new Trapecio(ObtenerCoordenadas());
            MostrarArea(trapecio);
            break;
    }
} while (opcion != 4);

double[,] ObtenerCoordenadas()
{
    double[,] vertices = new double[4,2];
    for (int Vertice = 0; Vertice < 4; Vertice++)
    {
        for (int coordenada = 0; coordenada < 2; coordenada++)
        {
            bool checkValue;
            do
            {
                Console.WriteLine($"Ingrese la coordenada {((coordenada == 0) ? 'X' : 'Y')} del vertice {Vertice + 1}");
                checkValue = double.TryParse(Console.ReadLine(), out double valor);
                if (!checkValue) Console.WriteLine("El valor ingresado no es un nuemero");
                else vertices[Vertice, coordenada] = valor;
            } while (!checkValue);
        }
    }
    return vertices;

    
}

void MostrarArea(Cuadrilatero cuadrilatero)
{
    if (cuadrilatero.CalcularArea() < 1) Console.WriteLine("Una o mas coordenadas fueron erroneas");
    else
    {
        Console.WriteLine($"El Area del {cuadrilatero.GetType().Name} es {cuadrilatero.CalcularArea()}");
        Console.WriteLine("******************************");
        Console.WriteLine("Presione enter parar continuar");
    }
    Console.ReadLine();
    Console.Clear();
}