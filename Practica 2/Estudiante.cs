using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    public class Estudiante
    {
        public string Nombre;
        public string Apellido;
        public int Edad;

        public string ObtenerNombreCompleto()
        {
            return $"{Nombre} {Apellido}";
        }

        public bool EsMayorDeEdad()
        {
            return Edad >= 18;

            if(Edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
