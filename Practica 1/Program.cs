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