
/* Calcular el salario de un empleado que trabaja por hora
 * El precio por hora lo ingresa el usuario
 * Si la cantidad de horas trabajadas son mas de 10, se paga un 10% extra
 * Mostrar al terminar el programa:
 *  - El total de horas
 *  - El precio a pagar por las horas trabajadas
 *  - El valor del procentaje que le corresponde
 *  - El total (subtotal + valor del procentaje)
 */

/* Variables:
 * -> HorasTrabajadas -> int
 * -> SalarioPorHora -> int
 * -> SalarioPorcentaje -> float
 * -> TotalAPagar -> flaot
 * -> Subtotal -> int
 */

/* Pasos a seguir (algoritmo)
 * 1- Declarar variables
 * 2- Pedir el precio por hora y la cantidad de horas que trabajó
 * 3- Calcular el subtotal (horas * precioHora)
 * 4- Si horas trabajadas son mayores que 10
 *      entonces -> calculo el valor del porcentaje (10% del subtotal) (subtotal * 10 / 100)
 *      sino -> nada
 * 5- Calcular el totalAPagar -> subtotal + porcentaje
 * 6- Mostrar toda la informacion
 */

int HorasTrabajadas;
int SalarioPorHora;
float SalarioPorcentaje = 0;
float TotalAPagar;
int Subtotal;

Console.Write("Ingrese el precio por hora: ");
SalarioPorHora = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de horas trabajadas por el operario: ");
HorasTrabajadas = int.Parse(Console.ReadLine());

Subtotal = SalarioPorHora * HorasTrabajadas;

if (HorasTrabajadas > 10)
{
    SalarioPorcentaje = Subtotal * 10 / 100;
}

TotalAPagar = Subtotal + SalarioPorcentaje;

Console.WriteLine($"Total de horas: {HorasTrabajadas}");
Console.WriteLine($"Salario por horas: {Subtotal}");
Console.WriteLine($"Porcentaje por mas de 10 horas: {SalarioPorcentaje}");
Console.WriteLine($"Total a pagar: {TotalAPagar}");