# Prueba Técnica: Sistema de Venta de Tickets para Cine

**Objetivo:**
Se desea desarrollar una aplicación que permita gestionar la venta de tickets para una película en un cine local.
La aplicación debe permitir vender tickets al publico para una funcion en particular, listar los tickets ya vendidos y calcular el total de dinero recaudado con la venta de tickets, todo esto mediante un menu que, ademas, ofrezca la posibilidad de salir de la aplicacion una vez terminado.

## Requisitos
El programa debe estar codificado en C#, usando Programación Orientada a Objetos (POO). No es necesaria implementación de Bases de datos ni de GUI, se evaluará 100% el manejo lógico del desarrollo de la aplicación.

## Fases del proyecto

### 1. Primera iteración
Implementar la funcionalidad necesaria para la venta de tickets, el listado de tickets vendidos, el total recaudado y la posibilidad de salir del programa.
Se nos informó que del ticket necesitamos Nombre y Apellido de la persona, el costo del ticket, el numero de asiento que le corresponde y el nombre de la pelicula.
El sistema esta pensado para ser utilizado para una unica funcion/pelicula.

### 2. Segunda iteración - Evitar sobreventa y validar la información
Para esta segunda iteración, necesitamos evitar se produzca la sobreventa de tickets al publico. La sala cuenta con 20 asientos para la funcion por lo que, tanto el numero de tickets vendidos, como el numero de asiento de cada ticket no puede superar las 20 unidades.
Ademas, se pide que no se pueda cargar un ticket que no posea nombre y apellido, y que la edad sea mayor a 10 años para poder expender un ticket.
Para toda esta funcionalidad se debe evitar la venta ya visar al usuario del problema.

### 3. Tercera iteración - Asistencia al evento
Para esta ultima iteración, se necesita que exista una opcion para que, una vez está por arrancar la función, permita seleccionar el ticket del participante y marcarlo como "presente" para saber quien asistió y quien nó a la funcion. Esto se hará mediante otra opcion donde se mostrarán los tickes de color verde para los asistentes y de color rojo para los no-presentes.

## Consideraciones Finales
- No se necesitan bases de datos ni interfaz de usuario (GUI), solo manejo en memoria y salida/ingreso de datos por consola.
- Se evaluará integramente el manejo de lógica y resolucion del problema.
- Asegúrate de que el menú por consola sea claro y fácil de usar.
- Realiza validaciones necesarias para garantizar la integridad de los datos ingresados.
