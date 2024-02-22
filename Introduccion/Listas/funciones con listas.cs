
// Listas (colecciones)  de objetos
Persona alumno = new Persona();
Persona profesor = new Persona();
Persona secretario = new Persona();

alumno.Nombre = "Carlos";
alumno.Apellido = "Ferrer";

profesor.Nombre = "Carlos";
profesor.Apellido = "Fumo";

secretario.Nombre = "Alex";
secretario.Apellido = "Segovia";

// declarar (crear) una lista
List<Persona> inscriptos = new List<Persona>();

// insertar (guardar) elementos
inscriptos.Add(alumno);
inscriptos.Add(profesor);
inscriptos.Add(secretario);

//-------------------------------------------------------------
// Actualizar el nombre de una de las personas de la lista
#region actualizar
/* Pasos
    1- buscar el elemento a actualizar
    2- eliminar el original
    3- cambiar el nombre
    4- guardar en la lista
 */

// Paso 1
Persona busqueda;
//        predicado ->  nombre-temporal => condicion (como un if)
busqueda = inscriptos.Find(x => x.Nombre == "Carlos");
// Paso 2
inscriptos.Remove(busqueda);
// Paso 3
busqueda.Nombre = "Nicolas";
// Paso 4
inscriptos.Add(busqueda);
#endregion
//-------------------------------------------------------------

// busqueda de todos los elementos que coinciden con el predicado
//List<Persona> busqueda; // el resutlado siempre a una lista
////        predicado ->  nombre-temporal => condicion (como un if)
//busqueda = inscriptos.FindAll(x => x.Nombre == "Carlos");

//foreach (var item in busqueda)
//{
//    Console.WriteLine($"El apellido es: {item.Apellido}");
//}

//--------------------------------------------------------------

// busqueda de un solo elemento
//Persona busqueda;
////        predicado ->  nombre-temporal => condicion (como un if)
//busqueda = inscriptos.Find(x => x.Nombre == "Carlos");

//Console.WriteLine($"El apellido es: {busqueda.Apellido}");

//-------------------------------------------------------------

//// busqueda de un solo elemento (el ultimo agregado)
//Persona busqueda;
////        predicado ->  nombre-temporal => condicion (como un if)
//busqueda = inscriptos.FindLast(x => x.Nombre == "Carlos");

//Console.WriteLine($"El apellido es: {busqueda.Apellido}");

//-------------------------------------------------------------

// Recorrer o listar cada uno de los items de la lista
//foreach (var item in inscriptos)
//{
//    Console.WriteLine($"Nombre: {item.Nombre} {item.Apellido}");
//}

// eliminar (borrar) un elemento
//inscriptos.Remove(profesor);

// vaciar (quitar todos los elementos) de la lista
//inscriptos.Clear();

// Ver cuantos items hay dentro de la lista
Console.WriteLine($"Cantidad de items: {inscriptos.Count}");

class Persona
{
    public string Nombre;
    public string Apellido;
}
