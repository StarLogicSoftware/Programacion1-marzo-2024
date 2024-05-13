
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

/* PASOS (pseudocodigo inicial)
 * 1- Declarar variables 
 * 2- Mientras la medida no sea cero, seguir pidiendo tramos
 *      Voy sumando cada tramo al total de caños
 * 3- Pedir el precio por metro de caño
 * 4- Calculo el costo en caños
 * 5- Mostrar total de caños y precio total */


/* Tarea 06/05 
    -> Pensar como pasar cada uno de los pasos del problema a funciones definiendo:
        - Valor de retorno (si lo tuviese)
        - Nombre de la funcion 
        - Parametros (si los tuviese) 
*/

// --- Variables para caño de 1/2 ---
float TotalPerfilesMedia = 0;
float CostoPorMetroCañoMedia;
float CostoTotalCañosMedia;

// --- Variables para caño de 3/4 ---
float TotalPerfilesTresCuartos = 0;
float CostoPorMetroCañoTresCuartos;
float CostoTotalCañosTresCuartos;

string OpcionMenu; // Variable para guardar la opcion del menú

// --- Bucle do-while para mostrar el menu repetidas veces hasta que el usuario quiera salir
do
{
    // --- Opciones a mostrar en el menú ---
    Console.WriteLine("Elegir medida de perfil: ");
    Console.WriteLine("1- Caño de 1/2");
    Console.WriteLine("2- Caño de 3/4");
    Console.WriteLine("3- Dejar de cargar perfiles");
    Console.WriteLine();
    Console.Write("Elija una opcion: ");
    OpcionMenu = Console.ReadLine();

    switch (OpcionMenu) // --- Switch para hacer segun la opcion elegida en "OpcionMenu" ---
    {
        case "1": // ----- Cargar caño de 1/2 -----------------------------

            TotalPerfilesMedia = IngresarDatosPerfiles("Ingrese medida tramo de 1/2: ");

            break; // ----- Fin Cargar caño de 1/2 -----------------------------

        case "2": // ----- Cargar caño de 3/4 -----------------------------

            TotalPerfilesTresCuartos = IngresarDatosPerfiles("Ingrese medida tramo de 3/4: ");

            break;  // ----- Fin Cargar caño de 1/2 -----------------------------

        case "3": // ----- Calcular todo -----------------------------

            // --- Pedir el precio de cada tipo de caño ---
            CostoPorMetroCañoMedia = PedidoDatoReal("Ingrese precio por metro del caño de 1/2: ");
            CostoPorMetroCañoTresCuartos = PedidoDatoReal("Ingrese precio por metro del caño de 3/4: ");

            // --- Calcular el costo total de cada tipo de caño ---
            CostoTotalCañosMedia = CalcularCostoTotal(TotalPerfilesMedia, CostoPorMetroCañoMedia);
            CostoTotalCañosTresCuartos = CalcularCostoTotal(TotalPerfilesTresCuartos,CostoPorMetroCañoTresCuartos);

            // --- Mostrar toda la informacion al cliente ---
            Console.WriteLine();
            Console.WriteLine($"Total en caños de 1/2: {TotalPerfilesMedia}");
            Console.WriteLine($"Total en costo de 1/2: {CostoTotalCañosMedia}");

            Console.WriteLine($"Total en caños de 3/4: {TotalPerfilesTresCuartos}");
            Console.WriteLine($"Total en costo de 3/4: {CostoTotalCañosTresCuartos}");

            break; // --- Fin Calcular todo ---

        default: // --- Si la eleccion no coincide con el menu, se muestra esto y luego vuelve a aparecer el menu
            Console.WriteLine("Opcion incorrecta");
            break;
    }
} while (OpcionMenu != "3");





float IngresarDatosPerfiles (string mensaje)
{
    float TotalDePerfiles = 0;
    float LongitudDelPerfil;
    do
    {
        LongitudDelPerfil = PedidoDatoReal(mensaje);
        if (LongitudDelPerfil > 0)
        {
            TotalDePerfiles = TotalDePerfiles + LongitudDelPerfil;
        }

    } while (LongitudDelPerfil > 0);

    return TotalDePerfiles;
}
float PedidoDatoReal(string mensaje)
{
    Console.Write(mensaje);
    return float.Parse(Console.ReadLine());
}

float CalcularCostoTotal (float totalPerfil, float costoPorMetro)
{
    return totalPerfil * costoPorMetro;
}




float PedidoDatoEntero(string mensaje)
{
    Console.Write(mensaje);
    return int.Parse(Console.ReadLine());
}








// Llamar una funcion
// CalcularTotal(25, "pepe", true);
// CalcularTotal(99, "carlos", false);

// declaracion (crarla)
// firma -> logica
// valor de retorno - nombre - parametro/s
// void CalcularTotal (int dato1, string nombre, bool hacer) { ... }

//int totalFactura = Suma(25, 40);
//int totalRecibo = Suma(45, 21);


//int Suma (int n1, int n2)
//{
//    int resultado = n1 + n2;

//    return resultado;
//}