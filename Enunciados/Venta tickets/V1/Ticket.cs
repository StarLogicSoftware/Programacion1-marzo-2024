using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaTickets
{
    public class Ticket
    {
        private int CostoPorDefecto = 3500;

        public string NombreCompleto;
        public int NumeroAsiento;
        public string NombrePelicula;
        public int Precio;

        public void CalculoCostoPorEdad(int Edad)
        {
            if( Edad >= 18)
            {
                Precio = CostoPorDefecto;
            }
            else
            {
                Precio = CostoPorDefecto / 2;
            }
        }
    }
}
