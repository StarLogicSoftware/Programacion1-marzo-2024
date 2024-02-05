
// crear matriz de asientos
string[,] asientos = new string[3,10];
int filaReserva;
int columnaReserva;

// cargamos la matriz con "L"
for (int fila = 0; fila < 3; fila++)
{
	for (int columna = 0; columna < 10; columna++)
	{
        asientos[fila, columna] = "L";
    }
}

// Reserva de un asiento
Console.Write("Fila a reservar: ");
filaReserva = int.Parse(Console.ReadLine());

Console.Write("Columna a reservar: ");
columnaReserva = int.Parse(Console.ReadLine());

//filaReserva = filaReserva - 1;
//columnaReserva = columnaReserva - 1;

// guardar una X en el lugar solicitado 
asientos[--filaReserva, --columnaReserva] = "X";

// mostrar todos los asientos
for (int fila = 0; fila < 3; fila++)
{
    for (int columna = 0; columna < 10; columna++)
    {
        //Console.Write( asientos[fila, columna] ); // forma facil
        Console.Write($" {asientos[fila, columna]} "); // con interpolacion
    }

    Console.WriteLine();
}
