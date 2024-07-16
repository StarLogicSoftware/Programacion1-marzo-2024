using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    public class Curso
    {
        public Curso()
        {
            Alumnos = new List<Alumno>();
        }

        public void AgregarAlumno()
        {
            Alumno a = new Alumno();

            a.Cargar();

            Alumnos.Add(a);
        }

        public void RemoverAlumnoPorNombre()
        {
            Console.Write("Nombre del alumno a eliminar: ");
            string nombreAlumno = Console.ReadLine();

            Alumno alumnoBorrar = Alumnos.Find(a => a.Nombre == nombreAlumno);

            Alumnos.Remove(alumnoBorrar);
        }

        public void CalificarAlumno()
        {
            Console.Write("Nombre del alumno a calificar: ");
            string nombreAlumno = Console.ReadLine();

            Alumno alumnoCalificar = Alumnos.Find(a => a.Nombre == nombreAlumno);

            if(alumnoCalificar != null)
            {
                Console.Write("Nota del alumno: ");

                int notaAlumno = int.Parse(Console.ReadLine());

                bool pudoCalificar = alumnoCalificar.Calificar(notaAlumno);

                if (pudoCalificar)
                {
                    Console.WriteLine($"Nota actualizada del alumno {alumnoCalificar.Nombre}");
                }
                else
                {
                    Console.WriteLine("La nota no es valida");
                }
            }
            else
            {
                Console.WriteLine("No existe este alumno");
            }
           
        }

        public void MostrarTodosLosAlumnos()
        {
            if(Alumnos.Count > 0)
            {
                foreach (var alumno in Alumnos)
                {
                    alumno.MostrarInformacion();
                }
            }
            else
            {
                Console.WriteLine("No hay alumnos inscriptos a este curso");
            }
        }

        public string Nombre;
        public string Instructor;
        public int DuracionHoras;

        public List<Alumno> Alumnos;

        public string ObtenerDescripcion()
        {
            return Nombre + " - " + Instructor + " duracion: " + DuracionHoras;
            return $"{Nombre} - {Instructor} duracion: {DuracionHoras}";
        }
        public void Cargar()
        {
            Console.WriteLine();
            Console.Write("Nombre del curso: ");
            Nombre = Console.ReadLine();

            Console.Write("Nombre del instructor: ");
            Instructor = Console.ReadLine();

            Console.Write("Horas de cursado: ");
            DuracionHoras = int.Parse(Console.ReadLine());
        }
    }
}
