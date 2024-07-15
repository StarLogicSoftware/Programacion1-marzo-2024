### Descripción del Proyecto

Crear una aplicación de consola en C# que simule la gestión de reservas de salas para una agencia que dicta diferentes cursos. Se utilizarán dos clases: `Curso` y `Sala`. La clase `Sala` contendrá una lista de instancias de la clase `Curso`, representando una relación de composición.

### Requisitos

1. **Crear la clase `Curso`:**
   - Propiedades:
     - `Nombre` (string)
     - `Instructor` (string)
     - `DuracionHoras` (int)
   - Métodos:
     - `ObtenerDescripcion()` que retorne una cadena con el nombre del curso, el instructor y la duración en horas.

2. **Crear la clase `Sala`:**
   - Propiedades:
     - `NombreSala` (string)
     - `Capacidad` (int)
     - `Reservas` (List<Curso>)
   - Métodos:
     - `AgregarReserva(Curso curso)` para agregar una reserva de curso a la lista.
     - `RemoverReserva(string nombreCurso)` para remover una reserva de curso de la lista según el nombre del curso.
     - `MostrarReservas()` que imprima en consola la información de todas las reservas de cursos en la sala.
     - `ObtenerTotalHorasReservadas()` que retorne el total de horas reservadas en la sala.
     - `ObtenerCursosPorInstructor(string nombreInstructor)` que retorne una lista de cursos dictados por un instructor específico.

3. **Implementar la funcionalidad en el método `Main`:**
   - Crear varias instancias de `Curso`.
   - Crear una instancia de `Sala` y agregar las reservas de cursos usando el método `AgregarReserva`.
   - Mostrar la información de las reservas de cursos en la sala usando el método `MostrarReservas`.
   - Mostrar el total de horas reservadas en la sala usando el método `ObtenerTotalHorasReservadas`.
   - Mostrar la lista de cursos dictados por un instructor específico usando el método `ObtenerCursosPorInstructor`.
   - Remover una reserva de curso y mostrar nuevamente la información de las reservas.

### Tareas Adicionales

- **Modificar el `Main` para practicar:**
  1. Agregar más reservas de cursos y manipular la lista usando los métodos de la clase `Sala`.
  2. Practicar con los métodos `RemoverReserva`, `ObtenerTotalHorasReservadas` y `ObtenerCursosPorInstructor` para comprender cómo interactúan con los objetos.
