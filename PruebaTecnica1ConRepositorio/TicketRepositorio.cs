using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaConRepositorio
{
    public class TicketRepositorio
    {
        private List<Ticket> tickets = new List<Ticket>();

        public void GuardarTicket(Ticket ticketGuardar)
        {
            tickets.Add(ticketGuardar);
        }

        public int ObtenerCantidadTickets()
        {
            return tickets.Count;
        }

        public List<Ticket> ObtenerTodos()
        {
            return tickets;
        }
    }
}
