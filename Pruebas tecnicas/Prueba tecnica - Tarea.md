# Prueba Técnica: Sistema de Gestión de Tareas

**Objetivo:**
Desarrollar una aplicación de consola en C# que permita a los usuarios gestionar sus tareas pendientes. La aplicación debe ofrecer funcionalidades para agregar tareas, cambiar su estado y mostrarlas en colores diferentes según su estado. Esta prueba está diseñada para evaluar tu capacidad para diseñar clases, manejar listas y construir una interfaz de usuario basada en consola.

## Requisitos

### Paso 1: Funcionalidad Básica de Crear y Listar Tareas

1. **Diseño de Clases:**
    - Diseña una clase `Tarea` con las propiedades que vos creas necesarias.
    - Crea una lista para almacenar todas las tareas.

2. **Menú Básico:**
    - Implementa un menú en consola con las siguientes opciones:
        1. Agregar una nueva tarea.
        2. Listar todas las tareas.
        3. Salir del programa.

3. **Agregar una nueva tarea:**
    - Permite al usuario ingresar los detalles de la tarea (titulo y descripcion) y agregarla a la lista de tareas con el estado "Pendiente".

4. **Listar todas las tareas:**
    - Muestra una lista de todas las tareas con sus detalles y estado actual.

### Paso 2: Actualización de Estado de las Tareas

1. **Menú Mejorado:**
    - Añade opciones al menú para:
        1. Marcar tarea como en progreso.
        2. Marcar tarea como completada.

2. **Marcar tarea como en progreso:**
    - Permite al usuario seleccionar una tarea y cambiar su estado a "En Progreso".

3. **Marcar tarea como completada:**
    - Permite al usuario seleccionar una tarea y cambiar su estado a "Completada".

### Paso 3: Mostrar Tareas con Colores Diferentes Según su Estado

1. **Colores en Consola:**
    - Modifica la funcionalidad de listar todas las tareas para que las tareas se muestren en colores diferentes según su estado:
        - Pendientes: Rojo
        - En Progreso: Naranja
        - Completadas: Verde

    - Utiliza la clase `Console` para cambiar el color de la salida en la consola:
        ```csharp
        Console.ForegroundColor = ConsoleColor.Red; // Para tareas pendientes
        Console.ForegroundColor = ConsoleColor.Yellow; // Para tareas en progreso
        Console.ForegroundColor = ConsoleColor.Green; // Para tareas completadas
        ```

### Consideraciones Adicionales

- Asegúrate de que la descripción y titulo de la tarea no esté vacía.
- Diseña la clase `Tarea` con las propiedades necesarias para almacenar el titulo, la descripción y el estado.
- Usa métodos para gestionar la creación y actualización del estado de las tareas.
- Asegúrate de que el menú por consola sea claro y fácil de usar.
- Realiza validaciones necesarias para garantizar la integridad de los datos ingresados.
