/* 2 pasos para usar funciones
    1- Declarar la funcion (crearla y decir que tiene que hacer)
    2- Llamar a la funcion (decirle que ejecute el codigo que tiene dentro)
*/

/* Declarar una funcion
 * 3 cosas -> 
    - Valor de retorno (al terminar, me devuelve un dato)
    - Nombre (identificar la funcion)
    - Parametros (datos que le doy para que pueda funcionar)

 * 2 partes ->
 *  - Firma (contiene las 3 cosas anteriores)
 *  - Cuerpo (el codigo a ejecutar)
*/


//Saludar("Nicolas", "Fumo");
//Saludar("Pepe", "Romero");
int resultadoAMostrar;
int dato1;
int dato2;

Console.Write("Ingresa el primer numero");
dato1 = int.Parse(Console.ReadLine());
Console.Write("Ingresa el segundo numero");
dato2 = int.Parse(Console.ReadLine());

resultadoAMostrar = CalcularAreaRectangulo(dato1, dato2);

Console.WriteLine(resultadoAMostrar);

int CalcularAreaRectangulo(int lado1, int lado2)
{
    int resultado;
    int lado3 = int.Parse(Console.ReadLine());
    resultado = lado1 + lado2;

    return resultado;
}

// Declaracion de la funcion Saludar -> no devuelve nada -void-, no recibe parametros ()
void Saludar (string nombre, string apellido)
{
    Console.WriteLine($"Hola {nombre} {apellido}!");
    Console.WriteLine("Estoy siendo llamado desde una funcion!");
}

int Sumar(int n1, int n2)
{
    return n1 + n2;
}

// calcular el area de un rectangulo
