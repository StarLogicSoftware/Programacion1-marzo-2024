using Practica_3;

Sala salita = new Sala(20, "Laboratorio");

Curso curso_programacion = new Curso();
curso_programacion.Cargar();

Curso curso_desarrollo_web = new Curso();
curso_desarrollo_web.Cargar();

salita.AgregarReserva(curso_programacion);
salita.AgregarReserva(curso_desarrollo_web);

Console.WriteLine("----------- Mostrar reservas ---------------------");

salita.MostrarReservas();

Console.WriteLine("----------- Mostrar reserva horas ----------------");

int horas = salita.ObtenerTotalHorasReservadas();

Console.WriteLine();
Console.WriteLine($"Total de horas de uso de la sala: {horas}");

Console.WriteLine("----------- Quitar una reserva -------------------");

Console.Write("Nombre o parte del nombre del curso a eliminar: ");
string cursoQuitar = Console.ReadLine();

salita.RemoverReserva(cursoQuitar);

Console.WriteLine(" ---- ");
salita.MostrarReservas();

Console.WriteLine("----------- Mostrar cursos por instructor --------");
Console.WriteLine();

Console.Write("Nombre del profesor: ");
string nombreProfe = Console.ReadLine();

List<Curso> cursosSegunProfe = salita.ObtenerCursosPorInstructor(nombreProfe);

if(cursosSegunProfe.Count > 0)
{
	foreach (var curso in cursosSegunProfe)
	{
		Console.WriteLine( curso.ObtenerDescripcion() );
	}
}
else
{
    Console.WriteLine("Este profe no tiene cursos cargados aun.");
}