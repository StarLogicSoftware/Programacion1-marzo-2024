# Consigna

Suponer un sistema de reserva de asientos para un cine. 

Este cuenta con 3 filas de 10 asientos cada una. Se necesita desarrollar un sistema (sin uso de bases de datos ni interfaz grafica) que permita llevar a cabo lo siguiente:

1. Cargar el “mapa” de filas y asientos. Indicando con una “X” los asientos ocupados y una “L” los asientos libres.
2. Al iniciar el programa, todos los asientos deben estar libres (”L”)
3. Manejar la reserva de asientos contemplando que un asiento SOLO PUEDE SER RESERVADO si se encuentra en estado “L”, en caso que esté en estado “X”, se deberá permitir al comprador elegir otro asiento. Si se encuentra en estado “L”, deberá pasar automáticamente a estado “X”
4. Para finalizar el programa se deberá ingresar un valor en particular. Contemplar que no existe una cantidad exacta de veces que el programa se pueda ejecutar.
5. Contemplar que SOLO EXISTEN 3 FILAS DE 10 ASIENTOS. NO se pueden vender asientos fuera de esas numeraciones, no se permite la “sobreventa”.

## Consideraciones
- No se necesita ni de GUI ni de BD. Se evaluará 100% el manejo lógico del desarrollo de la aplicación.
- Extra: En caso de que un cliente solicite visualizar cuales son los asientos libres, el sistema debe permitir mostrar de forma gráfica por consola el mapa de asientos. NO UTILIZAR GUI para este caso. Utilizar UNICAMENTE logica y salida por consola.
