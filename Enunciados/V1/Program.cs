
// crear matriz de asientos
string[,] asientos = new string[3, 10];
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

// Verificamos que el asiento este libre antes de reservar
if (asientos[--filaReserva, --columnaReserva] == "L")
{
    // guardar una X en el lugar solicitado 
    asientos[filaReserva, columnaReserva] = "X";
}
else // en cambio si el asiento ya esta reservado
{
    Console.WriteLine("Ese asiento ya esta ocupado");
}


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
