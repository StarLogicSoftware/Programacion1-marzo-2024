
// instanciar un objeto (crear)
Persona secretario = new Persona();
Persona docente = new Persona();

secretario.nombre = "Alex";
secretario.edad = 21;

docente.nombre = "Nicolas";
docente.edad = 25;

secretario.Saludar();
docente.Saludar();

Auto autito = new Auto();

autito.Color = "rojo";

Console.Write(autito.Color);

Matematica calculos = new Matematica();

calculos.sumar(25, 40);

class Persona
{
    public int edad; // varaibles -> propiedades
    public string nombre;
    public string direccion;
    public string telefono;

    public void Saludar()
    {
        //...
    }
}

class Auto
{
    public string Color;
    public string Marca;
    public string Modelo;
}

class Matematica
{
    public int sumar(int a, int b)
    {
        return a + b;
    }

    public int restar(int a, int b)
    {
        return a - b;
    }
}