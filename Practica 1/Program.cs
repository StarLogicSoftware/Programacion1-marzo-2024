using Practica_1;
Autor autor = new Autor();
autor.Nombre = "Nicolas";
autor.Apellido = "Fumo";

Libro librito = new Libro();
librito.Titulo = "El principito";
librito.Autor = autor;
/*
librito.Autor = new Autor();
librito.Autor.Nombre = "Nicolas";
librito.Autor.Apellido = "Fumo";
*/
librito.MostrarInformacion();
/*
    1- Crear otra instancia de Autor y Libro.
    2- Llamar a los métodos ObtenerNombreCompleto y MostrarInformacion con los nuevos objetos.
    3- Modificar los títulos y nombres de los autores y mostrar los cambios.
*/
Autor autorRenombrado = new Autor();
autorRenombrado.Nombre = "Victor";
autorRenombrado.Apellido = "Hugo";

Libro libroImportante = new Libro();
libroImportante.Titulo = "Los miserables";
libroImportante.Autor = autorRenombrado;

libroImportante.MostrarInformacion();
Console.WriteLine(autorRenombrado.ObtenerNombreCompleto());

libroImportante.Titulo = "100 años de soledad";
autorRenombrado.Nombre = "Garcia";
autorRenombrado.Apellido = "Marquez";

libroImportante.MostrarInformacion();
Console.WriteLine(autorRenombrado.ObtenerNombreCompleto());