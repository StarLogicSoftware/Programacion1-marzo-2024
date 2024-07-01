using PruebaTecnica1;
const int cantidadLimiteVenta = 20;
List<Ticket> tickets = new List<Ticket>();

Menu();

void Menu()
{
    string opcionMenu;

    Console.WriteLine("Sistema de venta de tickets");
    Console.WriteLine();
    Console.WriteLine("1. Vender ticket");
    Console.WriteLine("2. Ver vendidos");
    Console.WriteLine("3. Calcular total ventas");
    Console.WriteLine();
    opcionMenu = Console.ReadLine();

    switch (opcionMenu)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Vender nuevo ticket");
            Console.WriteLine();

            if (tickets.Count < cantidadLimiteVenta)
            {
                var nuevoTicket = new Ticket();

                bool pudoCargar = nuevoTicket.Cargar(cantidadLimiteVenta);
                if (pudoCargar)
                {
                    tickets.Add(nuevoTicket);
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

            foreach (var item in tickets)
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

            foreach (var item in tickets)
            {
                Total += item.Valor;
            }

            Console.WriteLine($"Total: ${Total}");

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