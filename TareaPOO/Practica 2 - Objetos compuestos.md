### Descripción del Proyecto

Crear una aplicación de consola en C# que simule la gestión de un curso y sus estudiantes. Se utilizarán dos clases: `Estudiante` y `Curso`. La clase `Curso` contendrá una lista de instancias de la clase `Estudiante`, representando una relación de composición.

### Requisitos

1. **Crear la clase `Estudiante`:**
   - Propiedades:
     - `Nombre` (string)
     - `Apellido` (string)
     - `Edad` (int)
   - Métodos:
     - `ObtenerNombreCompleto()` que retorne el nombre completo del estudiante (nombre + apellido).
     - `EsMayorDeEdad()` que retorne un booleano indicando si el estudiante es mayor de edad (18 años o más).

2. **Crear la clase `Curso`:**
   - Propiedades:
     - `NombreCurso` (string)
     - `ListaEstudiantes` (List<Estudiante>)
   - Métodos:
     - `AgregarEstudiante(Estudiante estudiante)` para agregar un estudiante a la lista.
     - `RemoverEstudiante(string nombreCompleto)` para remover un estudiante de la lista según su nombre completo.
     - `MostrarInformacionEstudiantes()` que imprima en consola la información de todos los estudiantes en el curso.
     - `ObtenerPromedioEdad()` que retorne el promedio de edad de los estudiantes en el curso.
     - `ObtenerMayoresDeEdad()` que retorne una lista de estudiantes que son mayores de edad.

3. **Implementar la funcionalidad en el método `Main`:**
   - Crear varias instancias de `Estudiante`.
   - Crear una instancia de `Curso` y agregar los estudiantes usando el método `AgregarEstudiante`.
   - Mostrar la información de los estudiantes en el curso usando el método `MostrarInformacionEstudiantes`.
   - Mostrar el promedio de edad de los estudiantes usando el método `ObtenerPromedioEdad`.
   - Mostrar la lista de estudiantes mayores de edad usando el método `ObtenerMayoresDeEdad`.
   - Remover un estudiante del curso y mostrar nuevamente la información de los estudiantes.

### Tareas Adicionales

- **Modificar el `Main` para practicar:**
  1. Agregar más estudiantes y manipular la lista usando los métodos de la clase `Curso`.
  2. Practicar con los métodos `RemoverEstudiante`, `ObtenerPromedioEdad` y `ObtenerMayoresDeEdad` para comprender cómo interactúan con los objetos.
