using PruebaTecnicaConRepositorio;
const int cantidadLimiteVenta = 20;

TicketRepositorio repositorio = new TicketRepositorio();

repositorio.GuardarTicket(new Ticket()
{
    Nombre = "Nombre 1",
    Apellido = "Apellido 1",
    NroAsiento = 1,
    Pelicula = "alguna",
    Valor = 1500
});

Menu();

void Menu()
{
    string opcionMenu;

    Console.WriteLine("Sistema de venta de tickets");
    Console.WriteLine();
    Console.WriteLine("1. Vender ticket");
    Console.WriteLine("2. Ver vendidos");
    Console.WriteLine("4. Marcar asistencia");
    Console.WriteLine("3. Calcular total ventas");
    Console.WriteLine("5. Ver asistencia");
    Console.WriteLine();
    Console.Write("Elija una opcion: ");
    opcionMenu = Console.ReadLine();

    switch (opcionMenu)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Vender nuevo ticket");
            Console.WriteLine();

            if (repositorio.ObtenerCantidadTickets() < cantidadLimiteVenta)
            {
                var nuevoTicket = new Ticket();

                bool pudoCargar = nuevoTicket.Cargar(cantidadLimiteVenta);
                if (pudoCargar)
                {
                    repositorio.GuardarTicket(nuevoTicket);
                }
            }
            else
            {
                Console.WriteLine($"Se alcanzo el limite de tickets {cantidadLimiteVenta}");
            }

            ResetMenu();
            break;

        case "2":
            Console.WriteLine("Tickets vendidos");
            Console.WriteLine();

            foreach (var item in repositorio.ObtenerTodos())
            {
                Console.WriteLine($"Nombre: {item.Nombre}");
                Console.WriteLine($"Apellido: {item.Apellido}");
                Console.WriteLine($"Nro Asiento: {item.NroAsiento}");
                Console.WriteLine($"Pelicula: {item.Pelicula}");
                Console.WriteLine($"Valor: {item.Valor}");
                Console.WriteLine();
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
            }

            ResetMenu();
            break;

        case "3":
            Console.WriteLine("Total vendido");
            Console.WriteLine();

            int Total = 0;

            foreach (var item in repositorio.ObtenerTodos())
            {
                Total += item.Valor;
            }

            Console.WriteLine($"Total: ${Total}");

            ResetMenu();
            break;

        case "4": // Marcar asistencia

            AsignarAsistencia(repositorio.ObtenerTodos());

            ResetMenu();
            break;

        case "5": // Ver asistencia
            int asistentes = 0;
            int ausentes = 0;

            foreach (var item in repositorio.ObtenerTodos())
            {
                item.MostrarAsistenciaTicket();

                if (item.Presente)
                {
                    asistentes++;
                }
                else
                {
                    ausentes++;
                }
            }

            Console.WriteLine($"Asistentes: {asistentes}");
            Console.WriteLine($"Ausentes: {ausentes}");
            ResetMenu();
            break;

        default:
            Console.WriteLine("Opcion incorrecta");
            Menu();
            break;
    }
}

void ResetMenu()
{
    Console.WriteLine("Presione una tecla para continuar...");
    Console.ReadKey();
    Console.Clear();
    Menu();
}

void AsignarAsistencia(List<Ticket> listado)
{
    Console.WriteLine("Tickets vendidos");
    Console.WriteLine("Seleccione uno a ingresar");
    Console.WriteLine();

    int numeroTicket = 1;

    foreach (var item in listado)
    {
        Console.WriteLine($"{numeroTicket}-> {item.Nombre} {item.Apellido} - asiento {item.NroAsiento}");
        Console.WriteLine("-----------------------------");

        numeroTicket++;
    }

    Console.WriteLine();
    Console.Write("Ticket elegido: ");
    int opcion = int.Parse(Console.ReadLine()) - 1;

    Ticket ticketElegido = listado[opcion];

    ticketElegido.Presente = true;
}