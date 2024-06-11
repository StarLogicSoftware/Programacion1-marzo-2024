using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadoTareas2
{
    public class Tarea
    {
        public int Titulo;
        public string Descripcion;
        public bool terminado;

        public void Cargar()
        {
            Console.WriteLine("----------- Nueva Tarea -----------");
            Console.Write("Titulo: ");
            Titulo = Console.ReadLine();
            Console.Write("Descripcion: ");
            Descripcion = Console.ReadLine();

            // Si recien se carga, quiere decir que no esta terminada
            terminado = false;
        }
        public void Ver()
        {
            Console.WriteLine("----------- Tarea -----------");
            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"Descripcion: {Descripcion}");
        }
        public void ActualizarDescripcion()
        {
            Console.WriteLine("Descripcion antigua:");
            Console.WriteLine(Descripcion);
            Console.WriteLine();
            Console.WriteLine("Ingresa la nueva descripcion y presiona enter:");
            Descripcion = Console.ReadLine();
        }
    }
}
