### Descripción del Proyecto

Crear una aplicación de consola en C# que simule la gestión de un libro y su autor. Se utilizarán dos clases: `Autor` y `Libro`. La clase `Libro` contendrá una instancia de la clase `Autor`, representando una relación de composición.

### Requisitos

1. **Crear la clase `Autor`:**
   - Propiedades:
     - `Nombre` (string)
     - `Apellido` (string)
   - Método:
     - `ObtenerNombreCompleto()` que retorne el nombre completo del autor (nombre + apellido).

2. **Crear la clase `Libro`:**
   - Propiedades:
     - `Titulo` (string)
     - `Autor` (Autor)
   - Métodos:
     - `MostrarInformacion()` que imprima en consola el título del libro y el nombre completo del autor.

3. **Implementar la funcionalidad en el método `Main`:**
   - Crear una instancia de `Autor`.
   - Crear una instancia de `Libro` usando la instancia de `Autor`.
   - Llamar al método `MostrarInformacion()` de la clase `Libro` para mostrar la información del libro y su autor.

### Tareas Adicionales

- **Modificar el `Main` para practicar:**
  1. Crear otra instancia de `Autor` y `Libro`.
  2. Llamar a los métodos `ObtenerNombreCompleto` y `MostrarInformacion` con los nuevos objetos.
  3. Modificar los títulos y nombres de los autores y mostrar los cambios.
