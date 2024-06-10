using ObjetosCompuestos;
// OBJETOS COMPUESTOS


Cerradura cerradura1 = new Cerradura();
cerradura1.Material = "aluminio";

Cerradura cerradura2 = new Cerradura();
cerradura2.Material = "Hierro";

Puerta P1 = new Puerta();
P1.Color = "Marron";

P1.cerraduraPuerta = cerradura2;