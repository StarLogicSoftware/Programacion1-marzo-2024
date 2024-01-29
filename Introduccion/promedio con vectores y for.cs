int[] notas = new int[50];
int promedio;
int sumatoriaNotas = 0;

// usando FOR
for (int i = 0; i < 50; i++)
{
    Console.Write("ingrese nota: ");
    notas[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 50; i++)
{
    Console.WriteLine($"Nota: {notas[i]}");
}

for (int indice = 0; indice < 50; indice++)
{
    //sumatoriaNotas = sumatoriaNotas + notas[i];
    sumatoriaNotas += notas[indice];
}

promedio = sumatoriaNotas / 50;

Console.WriteLine($"El promedio es: {promedio}");
