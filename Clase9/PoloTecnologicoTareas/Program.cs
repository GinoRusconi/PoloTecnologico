Random numeroRandom = new Random();
bool continuar = true;


int[,] carton;
do
{
    int blancas;
    int minValue;
    int maxValue;
    bool cartonValido;
    int intentos = 0;
    do
    {
        cartonValido = false;
        blancas = 0;
        minValue = 1;
        maxValue = 10;
        carton = new int[9, 3];
        intentos++;

        // Crear platilla de bingo para rellenar
        do
        {
            // 0 = libre 91=blanca 92=Ya no es posible
            int filaRandom = numeroRandom.Next(0, 3);
            int columnaRandom = numeroRandom.Next(0, 9);
            if (carton[columnaRandom, filaRandom] == 0)
            {
                if (columnaRandom >= 0 && columnaRandom <= 6)
                {
                    //comprobar 2 derecha
                    if (carton[columnaRandom + 1, filaRandom] == 91 && carton[columnaRandom + 2, filaRandom] == 91)
                    {
                        carton[columnaRandom, filaRandom] = 92;
                        continue;
                    }
                }
                if (columnaRandom >= 2 && columnaRandom <= 8)
                {
                    //comprueba 2 izq
                    if (carton[columnaRandom - 1, filaRandom] == 91 && carton[columnaRandom - 2, filaRandom] == 91)
                    {
                        carton[columnaRandom, filaRandom] = 92;
                        continue;
                    }
                }
                if (columnaRandom >= 1 && columnaRandom <= 7)
                {
                    //comprobar izq y derecha
                    if (carton[columnaRandom - 1, filaRandom] == 91 && carton[columnaRandom + 1, filaRandom] == 91)
                    {
                        carton[columnaRandom, filaRandom] = 92;
                        continue;
                    }
                }
                if (filaRandom == 2)
                {
                    //comprueba 2 arriba
                    if (carton[columnaRandom, filaRandom - 1] == 91 && carton[columnaRandom, filaRandom - 2] == 91)
                    {
                        carton[columnaRandom, filaRandom] = 92;
                        continue;
                    }
                }
                if (filaRandom == 0)
                {
                    //comprueba 2 arriba
                    if (carton[columnaRandom, filaRandom + 1] == 91 && carton[columnaRandom, filaRandom + 2] == 91)
                    {
                        carton[columnaRandom, filaRandom] = 92;
                        continue;
                    }
                }
                if (filaRandom == 1)
                {
                    if (carton[columnaRandom, filaRandom - 1] == 91 && carton[columnaRandom, filaRandom + 1] == 91)
                    {
                        carton[columnaRandom, filaRandom] = 92;
                        continue;
                    }
                }

                carton[columnaRandom, filaRandom] = 91;
                blancas++;
            }
        } while (blancas < 12);


        for (int columna = 0; columna < 9; columna++)
        {
            int contCartonValido = 0;
            for (int filas = 0; filas < 3; filas++)
            {
                if (carton[columna, filas] != 91)
                {
                    contCartonValido++;
                }
            }
            if (contCartonValido == 3)
            {
                cartonValido = true;
                break;
            }
        }

        for (int fila = 0; fila < 3; fila++)
        {
            int contCartonValido = 0;
            int tresEnFila = 0;
            for (int columna = 0; columna < 9; columna++)
            {
                if (carton[columna, fila] != 91)
                {
                    contCartonValido++;
                    tresEnFila++;
                }
                else
                {
                    tresEnFila = 0;
                }

                if (tresEnFila > 2)
                {
                    break;
                }
            }
            if (contCartonValido != 5 || tresEnFila > 2)
            {
                cartonValido = true;
                break;
            }
        }


    } while (cartonValido);


    // Rellena numeros
    for (int columna = 0; columna < 9; columna++)
    {

        for (int fila = 0; fila < 3; fila++)
        {
            int numeroAleatoriaAAgregar = numeroRandom.Next(minValue, maxValue);
            bool libre = true;

            if (carton[columna, fila] != 91)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (numeroAleatoriaAAgregar == carton[columna, i])
                    {
                        fila--;
                        libre = false;
                        break;
                    }
                }

                if (libre)
                {
                    carton[columna, fila] = numeroAleatoriaAAgregar;
                }
            }
        }
        if (columna == 7)
        {
            minValue = 80;
            maxValue = 91;
        }
        else
        {
            minValue = maxValue;
            maxValue += 10;
        }

    }

    //Mayor a menor
    for (int columna = 0; columna < 9; columna++)
    {
        int aux;

        for (int i = 0; i < 2; i++)
        {
            int distanciaDeRetroceso = 1;
            for (int j = 1; j < 3; j++)
            {
                if (carton[columna, j] == 91)
                {
                    distanciaDeRetroceso = 2;
                    continue;
                }
                if (carton[columna, j] < carton[columna, j - distanciaDeRetroceso] && carton[columna, j - distanciaDeRetroceso] != 91)
                {
                    aux = carton[columna, j];
                    carton[columna, j] = carton[columna, j - 1];
                    carton[columna, j - 1] = aux;
                }
            }
        }
    }

    // Imprimir Carton
    for (int fila = 0; fila < 3; fila++)
    {
        for (int columna = 0; columna < 9; columna++)
        {
            if (carton[columna, fila] == 91)
            {
                Console.Write("▒▒ ");
            }
            else if (carton[columna, fila] <= 9)
            {
                Console.Write($"0{carton[columna, fila]} ");
            }
            else
            {
                Console.Write(carton[columna, fila] + " ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine($"Se ah intentado {intentos} veces");
    Console.WriteLine("---------------------------------------------------");
    Console.WriteLine("Desea generar otro carton? S/N");
    if (Console.ReadLine() == "n")
    {
        continuar = false;
    }

} while (continuar);


