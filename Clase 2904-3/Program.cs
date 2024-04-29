
/* Sistema para un herrero de protones (v1)
 * Se necesita que realice un calculo del total de perfil estructural de 1/2 pulgada
 * para el armado de portones.
 * El usuario va ingresando valores de las medidas de los segmentos de caños y para
 * finalizar la carga, ingresa 0.
 * 
 * El usuario ingresa el precio por metro de caño.
 * 
 * Una vez finalizada la carga se calcula el total de caño y se muestra:
 *      -> total de caño utilizado
 *      -> total en costo de caños
 */

/* VARIABLES
 * LongitudCadaPerfil -> float
 * TotalPerfils -> float
 * CostoPorMetro -> float
 * CostoTotalCaños -> float
 */

/* PASOS (pseudocodigo)
 * 1- Declarar variables 
 * 2- Mientras la medida no sea cero, seguir pidiendo tramos
 *      Voy sumando cada tramo al total de caños
 * 3- Pedir el precio por metro de caño
 * 4- Calculo el costo en caños
 * 5- Mostrar total de caños y precio total */

float LongitudCadaPerfil;
float TotalPerfiles = 0;
float CostoPorMetro;
float CostoTotalCaños;

do
{
    Console.Write("Ingrese medida del tramo: ");
    LongitudCadaPerfil = float.Parse(Console.ReadLine());

    TotalPerfiles = TotalPerfiles + LongitudCadaPerfil;
} while (LongitudCadaPerfil > 0);

Console.Write("Ingrese precio por metro: ");
CostoPorMetro = float.Parse(Console.ReadLine());

CostoTotalCaños = TotalPerfiles * CostoPorMetro;

Console.WriteLine($"Total en caños: {TotalPerfiles}");
Console.WriteLine($"Total en costo: {CostoTotalCaños}");