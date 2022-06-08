Console.Write("Determine el tamaño de las filas de la matriz: ");
int tamañoFilas = int.Parse(Console.ReadLine());
Console.Write("Determine el tamaño de las columnas de la matriz: ");
int tamañoColumnas = int.Parse(Console.ReadLine());

int[,] matriz = new int[tamañoFilas, tamañoColumnas];
double[] promedio = new double[tamañoColumnas];

Console.Clear();

for (int i = 0; i < tamañoColumnas; i++)
{
    for (int j = 0; j < tamañoFilas; j++)
    {
        Console.Write($"Ingrese numero en la posicion {i + 1},{j + 1} de la matriz: ");
        matriz[j, i] = int.Parse(Console.ReadLine());
        promedio[i] += matriz[j, i];
        Console.Clear();
    }
    promedio[i] = promedio[i] / tamañoFilas;
}

Console.WriteLine("Los valores de la matriz son los siguientes");
Console.WriteLine("-------------------------------------------");

for (int i = 0; i < tamañoFilas; i++)
{
    for (int j = 0; j < tamañoColumnas; j++)
    {
        Console.Write($"{matriz[i, j]} ");
    }
    Console.WriteLine("");
}

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Los promedios de cada columna son");

for (int i = 0; i < promedio.Length; i++)
{
    Console.Write($"{promedio[i]} ");
}
Console.ReadLine();