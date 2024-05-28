/*
        --- LISTADO DE TAREAS ---
CREAR UN PROGRAMA PARA LISTA DE TAREAS QUE DEBE:
    1- Poder cargar tareas a realizar
    2- Debe cargar un titulo y un cuerpo o descripcion de la tarea
    3- Se pueden cargar, listar, ver y eliminar tareas
    4- Se debe usar un menu para las diferentes opciones
PARTE 2 DEL PROGRAMA
    5- Poder editar una tarea
    6- Poder marcar tarea como completada
    7- Marcar con color rojo la terminada y la verde la sin terminar
 */


Tarea tarea1 = new Tarea();

Menu();

void Menu()
{
    string opcion;

    Console.WriteLine(" --- Sistema de tareas ---");
    Console.WriteLine();
    Console.WriteLine("1- Cargar nueva tarea");
    Console.WriteLine("2- Listar tareas");
    Console.WriteLine("3- Ver una tarea");
    Console.WriteLine("4- Eliminar una tarea");
    Console.WriteLine();
    Console.Write("Opcion elegida: ");
    opcion = Console.ReadLine();
    switch (opcion)
    {
        case "1": // Cargar
            tarea1.Cargar();

            Console.Clear();
            Menu();
            break;
        case "2": // Listar

            Console.Clear();
            Menu();
            break;
        case "3": // Ver tarea
            tarea1.Ver();
            Console.WriteLine("Presione una tecla para continuar....");
            Console.ReadKey();
            Console.Clear();
            Menu();
            break;
        case "4": // Eliminar tarea

            Console.Clear();
            Menu();
            break;

        default: // cualquier opcion que no sea las anteriores
            Console.Clear(); // "limpia" la consola de texto viejo
            Console.WriteLine("La opcion no es correcta");
            Menu();
            break;
    }
}

class Tarea
{
    public string Titulo;
    public string Descripcion;
    public void Cargar()
    {
        Console.WriteLine("----------- Nueva Tarea -----------");
        Console.Write("Titulo: ");
        Titulo = Console.ReadLine();
        Console.Write("Descripcion: ");
        Descripcion = Console.ReadLine();
    }
    public void Ver()
    {
        Console.WriteLine("----------- Tarea -----------");
        Console.WriteLine($"Titulo: {Titulo}");
        Console.WriteLine($"Descripcion: {Descripcion}");
    }
}