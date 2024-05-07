string OpcionMenu;

Console.WriteLine("Elegir medida de perfil: ");
Console.WriteLine("1- Caño de 1/2");
Console.WriteLine("2- Caño de 3/4");
Console.WriteLine("3- Dejar de cargar perfiles");
Console.WriteLine();
Console.Write("Elija una opcion: ");
OpcionMenu = Console.ReadLine();

/*if (OpcionMenu == "1")
//{
//    Console.WriteLine("Caño de 1/2");
//}
//else if (OpcionMenu == "2")
//{
//    Console.WriteLine("Caño de 3/4");
//}
//else if (OpcionMenu == "3")
//{
//    Console.WriteLine("Dejar de cargar");
//}
//else
//{
//    Console.WriteLine("Opcion incorrecta");
//} */

switch (OpcionMenu)
{
    case "1":
        Console.WriteLine("Caño de 1/2");
        break;

    case "2":
        Console.WriteLine("Caño de 3/4");
        break;

    case "3":
        Console.WriteLine("Dejar de cargar");
        break;

    default:
        Console.WriteLine("Opcion incorrecta");
        break;
}