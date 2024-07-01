using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica1
{
    public class Ticket
    {
        public string Nombre;
        public string Apellido;
        public int NroAsiento;
        public int Valor;
        public string Pelicula;

        public void Cargar()
        {
            // -......
        }

        public bool Cargar(int cantidadLimite)
        {
            // ----- opcion 1
            string nombreCargado;

            Console.Write("Nombre cliente: ");
            nombreCargado = Console.ReadLine();
            //if (nombreCargado == "")
            if (!string.IsNullOrWhiteSpace(nombreCargado))
            {
                Nombre = nombreCargado;
            }
            else
            {
                Console.WriteLine("El nombre está vacio");
                return false;
            }

            // ----------------

            //Console.Write("Nombre cliente: ");
            //Nombre = Console.ReadLine();

            //if(Nombre == "")
            //{
            //    Console.WriteLine("El nombre no debe estar vacio");
            //    return false;
            //}
            //-----------------
            Console.Write("Apellido cliente: ");
            Apellido = Console.ReadLine();

            if (Apellido == "")
            {
                Console.WriteLine("El apellido no debe estar vacio");
                return false;
            }

            Console.Write("Nro Asiento: ");
            int asientoPedido = int.Parse(Console.ReadLine());

            if (asientoPedido <= cantidadLimite)
            {
                NroAsiento = asientoPedido;
            }
            else
            {
                Console.WriteLine($"No se puede vender un asiento mayor a {cantidadLimite}");
                return false;
            }

            Console.Write("Valor: ");
            Valor = int.Parse(Console.ReadLine());
            Console.Write("Pelicula: ");
            Pelicula = Console.ReadLine();

            return true;
        }
    }

}
