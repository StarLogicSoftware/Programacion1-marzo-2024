
/* Sistema para un herrero de protones (v1)
 * Se necesita que realice un calculo del total de perfil estructural de 1/2 pulgada
 * y de 3/4 para el armado de portones.
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

float LongitudMedia;
float TotalPerfilesMedia = 0;
float CostoPorMetroCañoMedia;
float CostoTotalCañosMedia;

float LongitudTresCuartos;
float TotalPerfilesTresCuartos = 0;
float CostoPorMetroCañoTresCuartos;
float CostoTotalCañosTresCuartos;

do
{
    // TAREA
    // MODIFICAR EL BUCLE PARA QUE TRABAJE CON LAS DOS MEDIDAS DE CAÑO
    Console.Write("Ingrese medida del tramo: ");
    LongitudMedia = float.Parse(Console.ReadLine());

    TotalPerfilesMedia = TotalPerfilesMedia + LongitudMedia;

} while (LongitudMedia > 0);

Console.Write("Ingrese precio por metro del caño de 1/2: ");
CostoPorMetroCañoMedia = float.Parse(Console.ReadLine());

Console.Write("Ingrese precio por metro del caño de 3/4: ");
CostoPorMetroCañoTresCuartos = float.Parse(Console.ReadLine());

CostoTotalCañosMedia = TotalPerfilesMedia * CostoPorMetroCañoMedia;
CostoTotalCañosTresCuartos = TotalPerfilesTresCuartos * CostoPorMetroCañoTresCuartos;

Console.WriteLine($"Total en caños de 1/2: {TotalPerfilesMedia}");
Console.WriteLine($"Total en costo de 1/2: {CostoTotalCañosMedia}");

Console.WriteLine($"Total en caños de 3/4: {TotalPerfilesTresCuartos}");
Console.WriteLine($"Total en costo de 3/4: {CostoTotalCañosTresCuartos}");