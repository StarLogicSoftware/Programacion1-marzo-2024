
// BUCLES
// definidos -> se cuantas veces pasan -> for
// indefinidos -> NO se cuantas veces pasan -> while / do-while


//for (int i = 0; i < 5; i++) // definido
//{
//    Console.WriteLine("Hola!");
//}

//while (condicion) // indefinido (pregunta y luego hace)
//{

//}

//do // indefinido (hace y luego pregunta)
//{

//} while (condicion);


// practica bucle for (definido)
// Pedir 10 numeros y mostrar su promedio

//int promedio;
//int sumatoria = 0;
//int cantidadNotas = 8;

//for (int i = 0; i < cantidadNotas; i++)
//{
//    Console.Write("Ingrese el numero: ");
//sumatoria = sumatoria + int.Parse(Console.ReadLine());
//sumatoria += int.Parse(Console.ReadLine());

//}

//promedio = sumatoria / cantidadNotas;

//Console.WriteLine($"El promedio es: {promedio}");

/* Pedir 10 notas y mostrar numero de aprobados y desaprobados
 * (se aprueba con 8 o mas) 
    Aprobados: X
    Desaprobados: X
 */

//int nota;
//int cantidadNotas;
//int aprobados = 0;
//int desaprobados = 0;

//Console.Write("Cantidad de alumnos: ");
//cantidadNotas = int.Parse(Console.ReadLine());

//for (int i = 0; i < cantidadNotas; i++)
//{
//    Console.Write("Ingrese nota: ");
//    nota = int.Parse(Console.ReadLine());

//    if(nota >= 8)
//    {
//        //aprobados = aprobados + 1;// suma 1 a la variable aprobados
//        //aprobados += 1; // igual que arriba pero mas corto
//        aprobados++; // sube de uno en uno
//    }
//    else
//    {
//        desaprobados = desaprobados + 1;
//    }
//}
//Console.WriteLine($"Aprobados: {aprobados}");
//Console.WriteLine($"Desaprobados: {desaprobados}");

// -------------------------------------------
// cantidad de notas indefinidas con do-while
int nota;
int aprobados = 0;
int desaprobados = 0;

do
{
    Console.Write("Ingrese nota: ");
    nota = int.Parse(Console.ReadLine());

    if (nota >= 0)
    {
        if (nota >= 8)
        {
            aprobados++; // sube de uno en uno
        }
        else
        {
            desaprobados++;
        }
    }

} while (nota >= 0);

Console.WriteLine($"Aprobados: {aprobados}");
Console.WriteLine($"Desaprobados: {desaprobados}");
