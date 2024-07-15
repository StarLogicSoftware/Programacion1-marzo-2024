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
    }
}
