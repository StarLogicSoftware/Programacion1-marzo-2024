

int CantidadLluvias;
// Se pide primero la cantidad para saber de cuantas celdas es la matriz
Console.Write("Cantidad de lluvias a ingresar: ");
CantidadLluvias = int.Parse(Console.ReadLine());

int[] lluvias = new int[CantidadLluvias];
int totalLluvias = 0;
float promedio = 0;
int lluviaMayor = 0;

// Es para cargar cada lluvia
for (int i = 0; i < CantidadLluvias; i++)
{
    Console.Write("Ingrese los mm de lluvia: ");
    lluvias[i] = int.Parse(Console.ReadLine());
}

// recorremos cada lluvia para obtener el total y el mayor de lluvias
for (int i = 0; i < CantidadLluvias; i++)
{
    totalLluvias = totalLluvias + lluvias[i];

    if (lluviaMayor < lluvias[i])
    {
        lluviaMayor = lluvias[i];
    }
}

promedio = totalLluvias / CantidadLluvias;

// la comun (no se recomienda) pero es mas facil
Console.Write("El promedio de lluvias es: ");
Console.WriteLine(promedio);
// concatenacion
Console.WriteLine("El promedio de lluvias es: " + promedio);
// interpolacion
Console.WriteLine($"El promedio de lluvias es: {promedio}");

Console.WriteLine($"La lluvia mayor fue de: {lluviaMayor}");