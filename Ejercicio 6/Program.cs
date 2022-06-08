int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);
bool numeroAdivinado = true;
int contadorDeIntentos = 0;

Console.WriteLine("Un Numero aleatorio entr 1 y 21 a sido creado, descubrelo");

do
{

    Console.WriteLine("---------------------------");
    Console.WriteLine("Ingrese un valor para comprobar");
    int numeroAComprobar = int.Parse(Console.ReadLine());
    contadorDeIntentos++;
    Console.Clear();

    if (numeroAComprobar == numeroSecreto)
    {
        numeroAdivinado = false;
    }
    else if (numeroAComprobar > numeroSecreto)
    {
        Console.WriteLine($"El numero {numeroAComprobar} ingresado es mayor al numero secreto");
        Console.WriteLine($"Usted lo intento {contadorDeIntentos} veces");
    }
    else
    {
        Console.WriteLine($"El numero {numeroAComprobar} ingresado es menor al numero secreto");
        Console.WriteLine($"Usted lo intento {contadorDeIntentos} veces");
    }

} while (numeroAdivinado);

Console.WriteLine("---------------------------");
Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era: {numeroSecreto}");
Console.WriteLine($"lo has intentado {contadorDeIntentos}");
Console.ReadLine();