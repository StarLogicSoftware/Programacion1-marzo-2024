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

        public bool Cargar(int cantidadLimite)
        {
            Console.Write("Nombre cliente: ");
            Nombre = Console.ReadLine();
            Console.Write("Apellido cliente: ");
            Apellido = Console.ReadLine();

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
