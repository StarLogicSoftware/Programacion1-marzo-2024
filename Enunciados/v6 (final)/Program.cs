
// crear matriz de asientos
using System.ComponentModel.Design;

string[,] asientos = new string[3, 10];
int filaReserva;
int columnaReserva;

// cargamos la matriz con "L"
PrecargarAsientos(asientos);

Menu();

void Menu()
{
    int opcion;

    Console.WriteLine("Sistema de reserva de asientos");
    Console.WriteLine("Ingrese una opcion y rpesione enter:");
    Console.WriteLine();
    Console.WriteLine("1- Ver asientos disponibles");
    Console.WriteLine("2- Reservar asiento");
    Console.WriteLine("3- Salir");
    Console.WriteLine();
    Console.Write("Opcion: ");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            MuestraAsientos(asientos);
            Menu();
            break;
        case 2:
            VerificarAsiento();
            ReservarAsiento(asientos, filaReserva, columnaReserva);
            Menu();
            break;
        case 3:
            Environment.Exit(0);
            break;
    }
}

void VerificarAsiento()
{
    do
    {
        Console.Write("Fila a reservar: ");
        filaReserva = int.Parse(Console.ReadLine());

        Console.Write("Columna a reservar: ");
        columnaReserva = int.Parse(Console.ReadLine());

        // si es invalido, se muestra el mensaje y se vuelve a pedir fila/columna
        if (filaReserva < 1 || filaReserva > 3 ||
                columnaReserva < 1 || columnaReserva > 10)
        {
            Console.WriteLine("La fila/columna esta fuera del rango");
        }

        // mensaje individual por fila y columna
        if (filaReserva < 1 || filaReserva > 3)
        {
            Console.WriteLine("La fila es invalida");
        }
        if (columnaReserva < 1 || columnaReserva > 10)
        {
            Console.WriteLine("La columna es invalida");
        }

    } while (filaReserva < 1 || filaReserva > 3 ||
                columnaReserva < 1 || columnaReserva > 10);
}

void ReservarAsiento(string[,] matriz, int filaAReservar, int columnaAReservar)
{
    // Verificamos que el asiento este libre antes de reservar
    if (matriz[--filaAReservar, --columnaAReservar] == "L")
    {
        // guardar una X en el lugar solicitado 
        matriz[filaAReservar, columnaAReservar] = "X";

        MuestraAsientos(matriz);
    }
    else // en cambio si el asiento ya esta reservado
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Ese asiento ya esta ocupado");
        Console.ForegroundColor = ConsoleColor.Gray;
        MuestraAsientos(matriz);
    }
}

void MuestraAsientos(string[,] Asientos)
{

    for (int fila = 0; fila < 3; fila++)
    {
        for (int columna = 0; columna < 10; columna++)
        {
            if (Asientos[fila, columna] == "L")
            {
                Console.ForegroundColor = ConsoleColor.Green; // L (libre)
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red; // X (ocupado)
            }

            Console.Write($" {Asientos[fila, columna]} "); // con interpolacion

            Console.ForegroundColor = ConsoleColor.White; // general
        }

        Console.WriteLine();
    }
}

void PrecargarAsientos(string[,] matriz)
{
    // cargamos la matriz con "L"
    for (int fila = 0; fila < 3; fila++)
    {
        for (int columna = 0; columna < 10; columna++)
        {
            matriz[fila, columna] = "L";
        }
    }
}
