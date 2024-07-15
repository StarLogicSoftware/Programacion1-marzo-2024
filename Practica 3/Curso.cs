using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    public class Curso
    {
        public string Nombre;
        public string Instructor;
        public int DuracionHoras;

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
