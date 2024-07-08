
namespace Practica_1
{
    public class Libro
    {
        public string Titulo;
        public Autor Autor;

        public void MostrarInformacion()
        {
            // opcion 1 (la mejor)
            Console.WriteLine($"Titulo: {Titulo} Autor: {Autor.ObtenerNombreCompleto()}");

            // opcion 2 (la peorcita)
            string nombreCompletoAutor = Autor.ObtenerNombreCompleto();
            Console.WriteLine($"Titulo: {Titulo} Autor: {nombreCompletoAutor}");
        }
    }
}
