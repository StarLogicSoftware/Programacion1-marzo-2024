using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    public class Curso
    {
        public string NombreCurso;
        private List<Estudiante> ListaEstudiantes = new List<Estudiante>();

        public void AgregarEstudiante(Estudiante estudiante)
        {
            if (string.IsNullOrEmpty(estudiante.Nombre))
            {
                Console.WriteLine("No se puede agregar un estudiante sin nombre");
            }
            else
            {
                ListaEstudiantes.Add(estudiante);
            }
        }

        public void RemoverEstudiante(string nombreCompleto)
        {
            // buscar el estudiante y eliminarlo
        }

        public void MostrarInformacionEstudiantes()
        {
            if (ListaEstudiantes.Count == 0)
            {
                Console.WriteLine("No hay estudiantes en este curso");
            }
            else
            {
                foreach (var estudiante in ListaEstudiantes)
                {
                    Console.WriteLine($"Estudiante: {estudiante.ObtenerNombreCompleto()} " +
                        $" - {estudiante.Edad} años");
                }
            }
        }

        public float ObtenerPromedioEdad()
        {
            float promedio = 0;

            foreach (var estudiante in ListaEstudiantes)
            {
                promedio += estudiante.Edad;
            }

            promedio = promedio / ListaEstudiantes.Count;

            return promedio;
        }

        public List<Estudiante> ObtenerMayoresDeEdad()
        {
            var estudiantesMayoresDeEdad = ListaEstudiantes.FindAll(e => e.Edad >= 18);

            return estudiantesMayoresDeEdad;
        }
    }
}
