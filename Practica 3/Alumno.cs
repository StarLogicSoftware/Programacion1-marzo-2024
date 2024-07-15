using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    public class Alumno
    {
        public string Nombre;
        public int Edad;
        public int Calificacion;

        public void Cargar()
        {
            Console.Write("Nombre alumno: ");
            Nombre = Console.ReadLine();
            Console.Write("Edad: ");
            Edad = int.Parse(Console.ReadLine());
        }

        public bool Calificar(int nota)
        {
            if(nota >= 0 && nota <= 10)
            {
                Calificacion = nota;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"{Nombre} {Edad} años, calificacion: {Calificacion}");
        }
    }
}
