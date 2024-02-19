
Menu();

void Menu()
{
    int opcion = 0;

    Console.ForegroundColor = ConsoleColor.Green; // color del texto

    Console.WriteLine("Seleccione una operacion: ");

    Console.ForegroundColor = ConsoleColor.Gray;

    Console.WriteLine("1-> opcion 1");
    Console.WriteLine("2-> opcion 2");
    Console.WriteLine("3-> Salir");
    Console.Write("Opcion elegida: ");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            funcion1();
            Menu();
            break;

        case 2:
            funcion2();
            Menu();
            break;

        case 3: // opcion salir
            Environment.Exit(0); // codigo para cerrar el programa
            break;

        default:
            Console.Clear(); // limpia (borra) la consola.
            Console.BackgroundColor = ConsoleColor.Red; // color de fondo
            Console.WriteLine("La opcion no es valida.");
            Console.BackgroundColor = ConsoleColor.Black;
            Menu();
            break;
    }
}
void funcion1()
{
    Console.WriteLine("elegida opcion 1");
}
void funcion2()
{
    Console.WriteLine("elegida opcion 2");
}
void funcion3()
{
    Console.WriteLine("elegida opcion 3");
}
