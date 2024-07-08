
namespace Practica_1
{
    public class Autor
    {
        public string Nombre;
        public string Apellido;

        public string ObtenerNombreCompleto()
        {
            return $"{Nombre}, {Apellido}";
            //return Nombre + " " + Apellido; // + -> concatenar strings
        }
    }
}
