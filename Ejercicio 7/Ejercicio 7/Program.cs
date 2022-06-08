int[] numerosIngresados = new int[10];
int acumulador = 0;

Console.WriteLine("Ingrese 10 numeros");

for (int i = 0; i < numerosIngresados.Length; i++)
{
    Console.WriteLine("---------------------------------------------------------");
    Console.Write($"Ingrese el numero {i + 1}: ");
    numerosIngresados[i] = int.Parse(Console.ReadLine());
    acumulador += numerosIngresados[i];
    Console.Clear();
}

Console.Write("Los numeros ingresados fueron : ");

for (int i = 0; i < numerosIngresados.Length; i++)
{
    Console.Write($"{numerosIngresados[i]} ");
}

Console.WriteLine("");
Console.WriteLine("---------------------------------------------------------");
Console.WriteLine($"El Mayor numero es : {numerosIngresados.Max()}");
Console.WriteLine($"El Menor numero es : {numerosIngresados.Min()}");
Console.WriteLine($"La suma de todos los numeros es: {acumulador}");
Console.WriteLine($"El promedio es: {acumulador / 10}");

Console.ReadLine();