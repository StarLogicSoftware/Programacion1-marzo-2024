

// LISTAS -> LIST
// LISTA ES COMO UN ARRAY PERO DE TAMAÑO DINAMICO (crece a medida que le
// colocamos elementos en el interior)


// declarar una lista

//List<int> lista;
//lista = new List<int>();

List<int> lista = new List<int>();
lista.Add(20); // cargo elementos dentro de la lista
lista.Add(15);
lista.Add(25); //
lista.Add(21); // 
lista.Add(3);

int valor = int.Parse(Console.ReadLine());

lista.Add(valor);
//                   _________ saber cuantos elementos hay en la lista
Console.WriteLine(lista.Count);

lista.RemoveRange(2, 3); // borra desde ese indice la cantidad de elementos especificados

lista.Remove(15); // Remover un elemento de adentro de la lista

lista.Insert(1, 30); // inserta un elemento en el indice indicado, corriendo los demas

lista.RemoveAt(2); // remueve un elemento en el indice especificado

Console.WriteLine( lista.IndexOf(21) ); // obtener el indice de ese elemento

//recorrer una lista (mostrar todos sus elementos)
foreach (var item in lista)
{
    Console.WriteLine(item);
}








//int[] dato;
//dato = new int[5];

//int[] dato = new int[5];
//// variable [indice] = valor
//     dato     [0]    =  25;

//dato[1] = 0;
//dato[2] = 12;
//dato[3] = 9;
//dato[4] = 17;

//for (int contador = 0; contador < 5; contador++)
//{
//    Console.WriteLine(dato[contador]);
//}