using Practica_2;

Curso curso = new Curso();
curso.NombreCurso = "Programacion 1";

var estudiante1 = new Estudiante();
estudiante1.Nombre = "Pepe";
estudiante1.Apellido = "Zamora";
estudiante1.Edad = 23;

var estudiante2 = new Estudiante()
{
    Nombre = "Marcos",
    Apellido = "Rivoira",
    Edad = 16
};

var estudiante3 = new Estudiante()
{
    Nombre = "Maria",
    Apellido = "Gutierrez",
    Edad = 26
};

curso.AgregarEstudiante(estudiante1);
curso.AgregarEstudiante(estudiante2);
curso.AgregarEstudiante(estudiante3);

curso.MostrarInformacionEstudiantes();

Console.WriteLine("------------ Promedio edad estudiantes --------------------");

float promedioEdadEstudiantes = curso.ObtenerPromedioEdad();
Console.WriteLine($"Promedio de edad de los estudiantes: {promedioEdadEstudiantes.ToString("0.0")}");

Console.WriteLine("------------ Estudiantes mayores de 18 años --------------------");

List<Estudiante> estudiantesMayoresDe18Años = curso.ObtenerMayoresDeEdad();

foreach (var estudiante in estudiantesMayoresDe18Años)
{
    Console.WriteLine($"-> {estudiante.Nombre}, {estudiante.Apellido}");
    //Console.WriteLine($"-> {estudiante.ObtenerNombreCompleto()}");
}