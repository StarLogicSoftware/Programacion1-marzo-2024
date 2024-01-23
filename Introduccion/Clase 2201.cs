/* 
Crear un programa para calcular el sueldo de un empleado

El pago al operario se hace calculando:
las horas trabajadas por el costo por hora

Mostrar "El pago correspondiente es: $XXXX"
 
--- pasos: ------------------------------------------------
Crear 3 variables para horas, costoxhora y total a pagar

muestro aviso de que tiene que ingresar el usuario
leo el valor y guardo en variable si hace falta, lo convierto a int
x2
calculo el valor total y lo guardo en la variable restante

Muestro en pantalla "El pago correspondiente es: $XXXX"
*/
int horasTrabajadas;
int costoPorHora;
int totalAPagar;

Console.Write("Cantidad de horas trabajadas: ");
horasTrabajadas = int.Parse( Console.ReadLine() );

Console.Write("Precio por hora: ");
costoPorHora = int.Parse(Console.ReadLine());

totalAPagar = horasTrabajadas * costoPorHora;

Console.Write("El pago correspondiente es: ");
Console.WriteLine(totalAPagar);

// Interpolacion de Strings
// habilitar la interpolacion -> colocando $ antes de la primer "
// el valor de la variable va entre { }

Console.WriteLine($"El pago correspondiente es: {totalAPagar}");



/* Numeros con decimales (float) */
float numero;
numero = float.Parse(Console.ReadLine());
Console.WriteLine($"El numero es: {numero}"); 

// indice de masa corporal
// Pedir altura y peso a la persona y mostrar su IMC
// IMC = peso / (altura * altura)

float peso;
float altura;
float imc;

Console.Write("Peso de la persona: ");
peso = float.Parse(Console.ReadLine());

Console.Write("Altura de la persona: ");
altura = float.Parse(Console.ReadLine());

imc = peso / (altura * altura);

Console.WriteLine($"IMC = {imc}");

/* 
Una juegueteria tiene que enviar juguetes a un deposito.
El envio son payasos y muñecas, donde dependiendo del peso, es 
el monto que cobra el transportista para llevarlos.
Pesos:
    payasos -> 112 gr
    muñecas -> 95 gr
costo por kg de envio: $70

Mostrar el costo total del envio. 
Si el envio supera los 1000 pesos mostrar que no se puede enviar */

int cantPayasos;
int cantMuñecas;
float totalEnvio;
int totalPayasos;
int totalMuñecas;
float totalKg;

int pesoPayaso = 112;
int pesoMuñeca = 95;
int costoEnvioKg = 70;

Console.Write("Cantidad de payasos: ");
cantPayasos = int.Parse(Console.ReadLine());

Console.Write("Cantidad de muñecas: ");
cantMuñecas = int.Parse(Console.ReadLine());

// calcular total de payasos y muñecas
totalPayasos = cantPayasos * pesoPayaso;
totalMuñecas = cantMuñecas * pesoMuñeca;

totalKg = (totalPayasos + totalMuñecas) / 1000;

totalEnvio = totalKg * costoEnvioKg;

if (totalEnvio <= 1000)
{
    Console.WriteLine($"Total del envio: {totalEnvio}");
}
else
{
    Console.WriteLine("No se puede enviar. No hay plata");
}


// condicionales

int edad;

Console.Write("Ingrese edad: ");
edad = int.Parse(Console.ReadLine());

//   condicion
if (edad >= 18) // si edad es mayor o igual a 18?
{ // hago esto
    // Codigo SI se cumple la condicion
}
else // sino
{ // hago esto
  // Codigo si NO se cumple la condicion
}
/*
< menor que 
> mayor que
== es igual
!= es diferente
<= menor o igual
>= mayor o igual
 */


// Pedir nombre y edad a dos personas, mostrar el nombre
// de la persona con edad mayor
int edad1;
string nombre1;
int edad2;
string nombre2;

Console.Write("Nombre 1: ");
nombre1 = Console.ReadLine();
Console.Write("Edad 1: ");
edad1 = int.Parse(Console.ReadLine());

Console.Write("Nombre 2: ");
nombre2 = Console.ReadLine();
Console.Write("Edad 2: ");
edad2 = int.Parse(Console.ReadLine());

if (edad1 > edad2)
{
    Console.WriteLine($"{nombre1} es mayor");
}
else
{
    Console.WriteLine($"{nombre2} es mayor");
}
