/* Solicitar una nota y mostrar:
    "Promocionado: nota es mayor o igual que 8 
    "Regular: nota es mayor o igual que 4 y menor que 8
    "Reprobado: nota es menor que 4 */

int nota;

Console.Write("Ingrese la nota: ");
nota = int.Parse(Console.ReadLine());

if (nota >= 8)
{
    Console.WriteLine("Promocionado");
}
else
{
    if (nota >= 4)
    {
        Console.WriteLine("Regular");
    }
    else
    {
        Console.WriteLine("Reprobado");
    }
}

// operadores logicos
// && (ampersand) "y" || (pleca) "o"

if (nota >= 4 && nota < 8)
{

}



/* Pedir 3 numeros y mostrar el mayor de ellos */

int numero1;
int numero2;
int numero3;

Console.Write("Ingrese primer numero: ");
numero1 = int.Parse(Console.ReadLine());

Console.Write("Ingrese segundo numero: ");
numero2 = int.Parse(Console.ReadLine());

Console.Write("Ingrese tercer numero: ");
numero3 = int.Parse(Console.ReadLine());

if(numero1 > numero2)
{
    if(numero1 > numero3)
    {
        Console.WriteLine($"El numero mayor fue {numero1}");
    }
    else
    {
        Console.WriteLine($"El numero mayor fue {numero3}");
    }
}
else
{
    if(numero2 > numero3)
    {
        Console.WriteLine($"El numero mayor fue {numero2}");
    }
    else
    {
        Console.WriteLine($"El numero mayor fue {numero3}");
    }
}

if(numero1 > numero2 && numero1 > numero3)
{
    Console.WriteLine($"El numero mayor fue {numero1}");
}

if (numero2 > numero1 && numero2 > numero3)
{
    Console.WriteLine($"El numero mayor fue {numero2}");
}

if (numero3 > numero2 && numero3 > numero1)
{
    Console.WriteLine($"El numero mayor fue {numero3}");
}
