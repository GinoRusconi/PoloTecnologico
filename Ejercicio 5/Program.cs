bool continuar = true;

while (continuar)
{
    Console.Clear();
    Console.WriteLine("Hola, introduzca su nombre");

    String nombrePerson = Console.ReadLine();
    Console.WriteLine($"¡Hola {nombrePerson}!");

    Console.WriteLine("Desea continuar? Si=S, No=N");
    String opcionContinuar = Console.ReadLine();

    if (opcionContinuar != null)
    {
        opcionContinuar = opcionContinuar.ToUpper();
        if (opcionContinuar == "N")
        {
            continuar = false;
        }
        else if (opcionContinuar != "S")
        {
            continuar = false;
            Console.WriteLine("Opcion no valida");
        }
    }
}
Console.WriteLine("Programa finalizado");
Console.ReadLine();