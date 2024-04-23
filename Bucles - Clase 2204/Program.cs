

// Bucles

// bucle FOR -> DEFINIDO

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("Esto va a aparecer 10 veces");
//}

// bucles indefinidos (Mientras -> while / Hacer -> do-while)
// while (pregunta -> verdadero -> hace)

//int dato = 0;

//// Mientras (while)
//while (dato < 5)
//{
//    Console.WriteLine("Ingresa un numero");

//    dato = int.Parse(Console.ReadLine());
//}

//// Hacer (do-while)
//do
//{
//    Console.WriteLine("Ingresa un numero");

//    dato = int.Parse(Console.ReadLine());

//} while (dato < 5) ;

//Console.WriteLine("Se termino el programa");


// Matrices
// Declarar una matriz de 3 celdas
int[] lluvias = new int[3];

lluvias[0] = 10;
lluvias[1] = 25;
lluvias[2] = 0;

Console.WriteLine("La primer lluvia fue de: " + lluvias[0]);
Console.WriteLine("La ultima lluvia fue de: " + lluvias[2]);

for (int contador = 0; contador < 3; contador++)
{
    Console.WriteLine("Lluvia: " + lluvias[contador]);
}