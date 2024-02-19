
int opcion = 0;
Console.WriteLine("Seleccione una operacion: ");
Console.WriteLine("1-> opcion 1");
Console.WriteLine("2-> opcion 2");
Console.WriteLine("3-> opcion 3");
Console.Write("Opcion elegida: ");
opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
    case 1:
        funcion1();
        break;
    case 2:
        funcion2();
        break;
    case 3:
        funcion3();
        break;
    default:
        Console.WriteLine("La opcion no es valida.");
        break;
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
