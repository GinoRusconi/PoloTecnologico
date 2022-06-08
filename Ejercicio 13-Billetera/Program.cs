using Ejercicio_13_Billetera.Modelo;

List<Billetera> billeteras = new List<Billetera>();

do
{
    int opcion;
    do
    {
        Console.Clear();
        Console.WriteLine("Bienvenido a la administracion de billeteras, que accion desea hacer?");
        Console.WriteLine("Opcion 1: Crear Billetera");
        Console.WriteLine("Opcion 2: Mostrar una Billetera");
        Console.WriteLine("Opcion 3: Comprobar total de dinero en una billetera");
        Console.WriteLine("Opcion 4: Combinar 2 billeteras creando una nueva");
    
        opcion = Convert.ToInt32(Console.ReadLine());

    } while (opcion > 0 && opcion < 5);

    switch (opcion)
    {
        case 1:
            Billetera billetera = new Billetera();


            break;
    }

    Billetera billetera1 = new Billetera()
    {
        iD = 1,
        BilletesDe10 = 12,
        BilletesDe20 = 25,
        BilletesDe50 = 10,
        BilletesDe100 = 11,
        BilletesDe200 = 18,
        BilletesDe500 = 16,
        BilletesDe1000 = 5
    };

    Billetera billetera2 = new Billetera()
    {
        iD = 2,
        BilletesDe10 = 1,
        BilletesDe20 = 12,
        BilletesDe50 = 30,
        BilletesDe100 = 41,
        BilletesDe200 = 28,
        BilletesDe500 = 16,
        BilletesDe1000 = 1
    };

    Billetera billetera3 = new Billetera()
    {
        iD = 3,
        BilletesDe10 = 2,
        BilletesDe20 = 5,
        BilletesDe50 = 18,
        BilletesDe100 = 31,
        BilletesDe200 = 13,
        BilletesDe500 = 26,
        BilletesDe1000 = 9
    };

    billeteras.Add(billetera1);
    billeteras.Add(billetera2);
    billeteras.Add(billetera3);


    foreach (var billetera in billeteras)
    {
        billetera.MostrarContenidoDeBilletera();
        Console.WriteLine();
    }


    Billetera billetera4 = billetera1.Combinar(billetera2);
    Console.WriteLine();

    billetera4.MostrarContenidoDeBilletera();

    Console.ReadLine();


} while (true);