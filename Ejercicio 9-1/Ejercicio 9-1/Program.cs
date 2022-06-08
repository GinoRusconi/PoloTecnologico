Console.WriteLine("Introdusca la longitud del vector");
int longitudVector = int.Parse(Console.ReadLine());

int[] vector = new int[longitudVector];

Random random = new Random();

for (int i = 0; i < vector.Length; i++)
{
    vector[i] = random.Next(100);
}

Console.WriteLine("");
Console.WriteLine("-----------------------");
Console.WriteLine("Vector creado aleatoriamente");

foreach (var item in vector)
{
    Console.Write(item + " ");
}

int aux;
for (int i = 0; i < vector.Length / 2; i++)
{
    aux = vector[vector.Length - i - 1];

    vector[vector.Length - i - 1] = vector[i];

    vector[i] = aux;
}

Console.WriteLine("");
Console.WriteLine("-----------------------");
Console.WriteLine("Vector Invertido");

foreach (var item in vector)
{
    Console.Write(item + " ");
}

aux = 0;
for (int i = 0; i < vector.Length - 1; i++)
{
    for (int j = 1; j < vector.Length; j++)
    {
        if (vector[j] < vector[j - 1])
        {
            aux = vector[j];
            vector[j] = vector[j - 1];
            vector[j - 1] = aux;
        }
    }
}

Console.WriteLine("");
Console.WriteLine("-----------------------"); ;
Console.WriteLine("Vector ordenado de menor a mayor");

foreach (var item in vector)
{
    Console.Write(item + " ");
}

Console.ReadLine();