Persona person1 = new Persona();
Persona person2 = new Persona();

person1.Cargar();
person2.Cargar();

Console.Clear();

Comparar(person1, person2);


void Comparar(Persona p1, Persona p2)
{
    if (p1.Edad > p2.Edad)
    {
        Console.WriteLine(p1.Nombre + " es la persona de mayor edad");
    }
    else
    {
        Console.WriteLine(p2.Nombre + " es la persona de mayor edad");
    }
}


class Persona
{
    public string Nombre;
    public int Edad;

    public void Cargar()
    {
        Console.WriteLine("Ingrese el nombre completo de la persona: ");
        Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese su edad: ");
        Edad = int.Parse(Console.ReadLine());
        Console.WriteLine();
    }

}