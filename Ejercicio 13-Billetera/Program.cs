using Ejercicio_13_Billetera.Modelo;

List<Billetera> billeteras = new List<Billetera>();
int billeterasCreadas = 1;
int opcion;
do
{
    do
    {
        Console.Clear();
        Console.WriteLine("Bienvenido a la administración de billeteras, ¿que acción desea Realizar?");
        Console.WriteLine("Opción 1: Crear Billetera");
        Console.WriteLine("Opción 2: Mostrar una Billetera");
        Console.WriteLine("Opción 3: Comprobar total de dinero en una billetera");
        Console.WriteLine("Opción 4: Combinar 2 billeteras creando una nueva");
        Console.WriteLine("Opción 5: Salir");

        opcion = Convert.ToInt32(Console.ReadLine());

    } while (opcion <= 0 && opcion >= 6);

    int numeroDeBilletera;
    int numeroDeBilletera2;
    bool numeroDeBilleteraValido = true;
    switch (opcion)
    {
        case 1:
            Billetera billetera = new Billetera();
            billetera.CrearBilletera(billeterasCreadas++);
            billeteras.Add(billetera);
            Console.WriteLine($"Se a creado la billetera con exito su ID es {billetera.iD}");
            Console.WriteLine("------------------------");
            Console.WriteLine("Presione Cualquier tecla");
            Console.ReadLine();
            break;
        case 2:
            Console.WriteLine("Que billetera desea revisar?. Indique con un numero");
            do
            {
                numeroDeBilletera = Convert.ToInt32(Console.ReadLine());
                foreach (var item in billeteras)
                {
                    if (item.iD == numeroDeBilletera)
                    {
                        numeroDeBilleteraValido = false;
                    }
                }
                if (numeroDeBilleteraValido == true)
                {
                    Console.Clear();
                    Console.WriteLine("Esa billetera no existe");
                }
            } while (numeroDeBilleteraValido);
            billeteras[numeroDeBilletera-1].MostrarContenidoDeBilletera();
            Console.WriteLine("------------------------");
            Console.WriteLine("Presione Cualquier tecla");
            Console.ReadLine();
            break;
        case 3:
            Console.WriteLine("Que billetera desea comprobar el total de dinero?. Indique con un numero de iD");
            do
            {
                numeroDeBilletera = Convert.ToInt32(Console.ReadLine());
                foreach (var item in billeteras)
                {
                    if (item.iD == numeroDeBilletera)
                    {
                        numeroDeBilleteraValido = false;
                    }
                }
                if (numeroDeBilleteraValido == true)
                {
                    Console.Clear();
                    Console.WriteLine("Esa billetera no existe");
                }
            } while (numeroDeBilleteraValido);
            Console.WriteLine($"El total de esta billetera es: {billeteras[numeroDeBilletera-1].Total()}");
            Console.WriteLine("------------------------");
            Console.WriteLine("Presione Cualquier tecla");
            Console.ReadLine();
            break;
        case 4:
            
            do
            {
                Console.WriteLine("Ingrese el id de la primer billetera");
                numeroDeBilletera = Convert.ToInt32(Console.ReadLine());
                foreach (var item in billeteras)
                {
                    if (item.iD == numeroDeBilletera)
                    {
                        numeroDeBilleteraValido = false;
                    }
                }
                if (numeroDeBilleteraValido == true)
                {
                    Console.Clear();
                    Console.WriteLine("Esa billetera no existe");
                }
            } while (numeroDeBilleteraValido);

            do
            {
                Console.WriteLine("Ingrese el id de la Segunda billetera");
                numeroDeBilletera2 = Convert.ToInt32(Console.ReadLine());
                foreach (var item in billeteras)
                {
                    if (item.iD == numeroDeBilletera2)
                    {
                        numeroDeBilleteraValido = false;
                    }
                }
                if (numeroDeBilleteraValido == true)
                {
                    Console.Clear();
                    Console.WriteLine("Esa billetera no existe");
                }
            } while (numeroDeBilleteraValido);
            
            Billetera nuevaBilletera = billeteras[numeroDeBilletera - 1].Combinar(billeteras[numeroDeBilletera2 - 1], billeterasCreadas++);
            Console.WriteLine($"Se ah creado una nueva billetera con ID {nuevaBilletera.iD}");
            billeteras.Add(nuevaBilletera);
            billeteras[numeroDeBilletera-1].LimpiarBilletera();
            billeteras[numeroDeBilletera2-1].LimpiarBilletera();
            Console.WriteLine($"Las billeteras de id {billeteras[numeroDeBilletera - 1].iD} y {billeteras[numeroDeBilletera2 - 1].iD} han sido limpiadas");
            Console.WriteLine("------------------------");
            Console.WriteLine("Presione Cualquier tecla");
            Console.ReadLine();
            break;
    }
    Console.Clear();
} while (opcion !=5) ;