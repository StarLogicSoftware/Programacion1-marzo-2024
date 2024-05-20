/*  PRACTICA POO - Ejercicio 1
 Hacer un programa para calcular el promedio de notas de un curso de 5 personas.
 Cada examen se necesita saber la nota y el nombre del alumno.
 Tareas:
    1- Obtener el promedio del curso
    2- La nota mayor y la nota menor
    3- Mostrar nombre del alumno de la nota mayor
 */

/* Machetito suave
-> 5 objetos
-> 1 clase -> Examen (justifique su respuesta)
-> propiedades: nombre, apellido, calificacion
-> metodos: MostrarInformacion, Cargar
*/

Examen examen1 = new Examen();
Examen examen2 = new Examen();
Examen examen3 = new Examen();
Examen examen4 = new Examen();
Examen examen5 = new Examen();

examen1.Cargar();
examen2.Cargar();
examen3.Cargar();
examen4.Cargar();
examen5.Cargar();

int Promedio;

Promedio = (examen1.Nota + examen2.Nota
    + examen3.Nota + examen4.Nota + examen5.Nota) / 5;

Console.WriteLine($"El promedio general es: {Promedio}");

class Examen
{
    public string Nombre;
    public string Apellido;
    public int Nota;

    public void MostrarInformacion()
    {
        Console.WriteLine($"Alumno: {Nombre} {Apellido} Nota: {Nota}");
    }

    public void Cargar()
    {
        Console.Write("Nombre alumno: ");
        Nombre = Console.ReadLine();
        Console.Write("Apellido alumno: ");
        Apellido = Console.ReadLine();
        Console.Write("Nota alumno: ");
        Nota = int.Parse(Console.ReadLine());

        Console.WriteLine("-----------------");
    }
}
