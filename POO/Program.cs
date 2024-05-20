
/* POO - Programacion Orientada a Objetos

 Paradigma -> metodologia de como se hacen las cosas

 Clasificacion de elementos (agrupar segun cosas similares)
 
 Abstraccion (solo tomar lo que nos sirve e ignorar el resto)

*/

//Persona secretario1 = new Persona(); // en una sola linea
//int edad;
//dato = 25;

//int dato1 = 25;


Persona secretario; // variable para crear objetos con la clase Persona
secretario = new Persona(); // Instanciar (crear) un objeto en base a una clase (molde)

Persona docente = new Persona();

docente.Nombre = "Nicolas";
docente.Edad = 32;
docente.Apellido = "Fumo";

secretario.Nombre = "Alex";
secretario.Apellido = "Whillhelm";
secretario.Edad = 22;

secretario.Ver();
secretario.Registrar();

docente.Registrar();
docente.Ver();

class Persona // clase es para clasificar objetos
{
    // variables -> Propiedades
    public string Nombre;
    public string Apellido;
    public int Edad;

    // funciones -> Metodos
    public void Registrar()
    {

    }
    public void Ver()
    {
        Console.WriteLine($"Hola, soy {Nombre} {Apellido} y tengo {Edad} años.");
    }
}



//class Automovil
//{
//    string Modelo;
//    string Marca;
//    int AñoFabricacion;
//    string Color;
//    string Transmision;

//    void Registrar()
//    {

//    }
//    void Ingresar() { }
//    void Entregar() { }
//}