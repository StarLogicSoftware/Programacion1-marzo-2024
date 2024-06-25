// LISTAS DE OBJETOS
List<Persona> clientes = new List<Persona>();

Persona per1 = new Persona();
per1.Nombre = "Francisco";
per1.Edad = 27;

Persona per2 = new Persona();
per2.Nombre = "Marcos";
per2.Edad = 32;

Persona per3 = new Persona();
per3.Nombre = "Marcos";
per3.Edad = 40;

clientes.Add(per1);
clientes.Add(per2);
clientes.Add(per3);

// Find() Busca el primero que coincide con la busqueda                             
Persona personaBuscada1 = clientes.Find(item => item.Nombre == "Marcos");
//                                     funcion lambda (verdadero o falso)

// Find() Busca el ultimo que coincide con la busqueda  
Persona personaBuscada2 = clientes.FindLast(item => item.Nombre == "Marcos");

// Busca todos los elementos que coinciden con la busqueda. DEVUELVE UNA LISTA
List<Persona> personasBuscadas = clientes.FindAll(item => item.Nombre == "Marcos");

foreach (var item in personasBuscadas)
{
    Console.WriteLine(item.Edad);
}

// Equivalente a la funcion lambda del Find()
//foreach (var item in clientes)
//{
//    if(item.Nombre == "Francisco" && item.Edad > 20)
//    {
//        personaBuscada = item;
//    }
//}

// Obtiene un cliente segun el indice con el que esta guardado en la lista
//Persona personaDeLaLista = clientes[1];

// Recorre una lista uno por uno, saca un cliente y muestra su nombre
//for (int indice = 0; indice < clientes.Count; indice++)
//{
//    var persona = clientes[indice];

//    Console.WriteLine($"Nombre: {persona.Nombre}");
//}

// Recorre una lista uno por uno, saca un cliente y muestra su nombre
//foreach (var item in clientes)
//{
//    Console.WriteLine($"Nombre: {item.Nombre}");
//}

// Remueve un elemento de la lista
//clientes.Remove(personaDeLaLista);

// lista.Count se usa para obtener la cantidad de elementos guardados dentro de la lista
//Console.WriteLine($"Cantidad de clientes: {clientes.Count}");

class Persona
{
    public string Nombre;
    public int Edad;
}