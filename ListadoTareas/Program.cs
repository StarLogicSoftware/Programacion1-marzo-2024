﻿/*
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


List<Tarea> tareas = new List<Tarea>();

// Info de prueba para tener pre-cargadas algunas tareas
Tarea t1 = new Tarea();
t1.Titulo = "tarea 1";
t1.Descripcion = "Descripcion 1";
tareas.Add(t1);

Tarea t2 = new Tarea();
t2.Titulo = "tarea 2";
t2.Descripcion = "Descripcion 2";
tareas.Add(t2);

Tarea t3 = new Tarea();
t3.Titulo = "tarea 3";
t3.Descripcion = "Descripcion 3";
tareas.Add(t3);

Tarea t4 = new Tarea()
{
    Titulo = "Titulo 4",
    Descripcion = "Descripcion 4",
};

tareas.Add(new Tarea()
{
    Titulo = "T5",
    Descripcion = "D5"
});


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

            Tarea tareaCargar = new Tarea();

            tareaCargar.Cargar();

            tareas.Add(tareaCargar);

            Console.Clear();
            Menu();
            break;


        case "2": // Listar

            foreach (var item in tareas)
            {
                Console.WriteLine($" -> {item.Titulo}");
            }
            Console.WriteLine(); // salto de linea para separar elementos

            // Pausa para que se puedan ver los elementos antes de borrar la consola
            Console.WriteLine("Presione una tecla para continuar....");
            Console.ReadKey();

            Console.Clear();
            Menu();

            break;


        case "3": // Ver tarea

            Tarea tarea = BuscarTarea(tareas);

            tarea.Ver();

            Console.WriteLine("Presione una tecla para continuar....");
            Console.ReadKey();
            Console.Clear();
            Menu();
            break;

        case "4": // Eliminar tarea

            Tarea tareaBorrar = BuscarTarea(tareas);

            tareas.Remove(tareaBorrar);

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

Tarea BuscarTarea(List<Tarea> listadoTareas)
{
    int contador = 1;
    int tareaAVer;

    foreach (var item in listadoTareas)
    {
        Console.WriteLine($"{contador} -> {item.Titulo}");
        contador++;
    }

    Console.WriteLine(); // espacio en blanco para no mezclar cosas
    Console.Write("Ingrese tarea a ver: ");
    tareaAVer = int.Parse(Console.ReadLine());

    tareaAVer -= 1;
    Tarea tarea = tareas[tareaAVer];

    return tarea;
    // return tareas[tareaAVer]; // -> alternativa corta
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

