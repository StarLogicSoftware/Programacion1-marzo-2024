
/* comentario largo */
// comentario en linea

// objeto funcion  parametro
//Console.WriteLine("Weeeenas");

/* VARIABLES
 * Entero -> int -> numeros sin decimales
 * Real -> float -> numero con decimales
 * Cadena -> string -> texto
 * Booleano -> bool -> si/no - verdadero/falso - 0/1 */

// Declarar (crear) la variable -> tipo nombre ;
//int Peso;

// Asignacion
//Peso = 25 * 2;

// Salida (con concatenación)
//Console.WriteLine("El peso es: " + Peso + "kg.");


// Pedir el nombre y mostrar "Hola, mi nombre es: --nombre--"
//string nombrePersona;

// Leer algun valor por consola (salida + entrada)
//Console.WriteLine("Ingresá tu nombre");
//nombrePersona = Console.ReadLine();

//Console.WriteLine("Hola, mi nombre es: " + nombrePersona);


// Pedir dos numeros y mostrar el resultado de la suma

//int numero1;
//int numero2;
//int resultado;

//Console.Write("Ingresá el primer numero: ");
//numero1 = int.Parse(Console.ReadLine()); // se lee el texto y se convierte a int

//Console.Write("Ingresá el segundo numero: ");
//numero2 = int.Parse(Console.ReadLine());

//resultado = numero1 + numero2;

//Console.WriteLine("El resultado es: " + resultado);

// Pedir 3 notas y mostrar el promedio

int nota1;
int nota2;
int nota3;
int promedio;

Console.Write("Ingresá la primer nota: ");
nota1 = int.Parse(Console.ReadLine());

Console.Write("Ingresá la segunda nota: ");
nota2 = int.Parse(Console.ReadLine());

Console.Write("Ingresá la tercer nota: ");
nota3 = int.Parse(Console.ReadLine());

promedio = (nota1 + nota2 + nota3) / 3;

Console.WriteLine("El resultado es: " + promedio);


//    reprobado     6 regular 8     >8  promocioando
// 0------------6---------------8--------------10

if (promedio > 6)
{
    if (promedio > 8)
    {
        Console.WriteLine("Promocionado");
    }
    else
    {
        Console.WriteLine("Regular");
    }
}
else
{
    Console.WriteLine("Desaprobado");
}

/* Recoleccion de basura
 Hacer un programa que pida el dia de la semana "lunes, martes, miercoles, etc
 Y me diga si tengo que sacar organicos, inorganicos o no sacar la basura
    Reglas:
        organico -> lunes, miercoles o viernes
        inorganico -> martes y jueves
        no sacar -> sabado o domingo
*/




//if (promedio >= 6)
//{
//    Console.WriteLine("Aprobado");
//}
//else
//{
//    Console.WriteLine("Desaprobado");
//}

//// Condicional if -> si?
//if (resultado >= 6)
//{
//    Console.WriteLine("Aprobado");
//}
//else // sinó
//{
//    Console.WriteLine("Desaprobado");
//}


