/* Vas a crear una clase llamada Coche que tenga las siguientes características:
    Atributos:
        Marca: Propiedad de tipo string que indica la marca del coche.
        Modelo: Propiedad de tipo string que indica el modelo del coche.
        Año: Propiedad de tipo int que indica el año del coche.
        Kilometraje: Propiedad de tipo int que indica el kilometraje del coche.
    Métodos:
        MostrarInformacion(): Método que imprime la información del coche.
        Conducir(int km): Método que incrementa el kilometraje del coche en km kilómetros.*/

// instanciar (crear) un objeto del tipo Coche
Coche autito = new Coche("Fiat", "Palio", 2014, 103000);
Coche autito2 = new Coche("Renault", "Clio", 2018, 57000);

autito.MostrarInformacion();
int KmRecorridos;
Console.Write("Ingrese los km que ha recorrido: ");
KmRecorridos = int.Parse(Console.ReadLine());

autito.Conducir(KmRecorridos);

autito.MostrarInformacion();

void Sumar()
{

}

class Coche
{
    public Coche(string marca, string modelo, int año, int kilometraje)
    {
        Marca = marca;
        Modelo = modelo;
        Año = año;
        Kilometraje = kilometraje;
    }

    public string Marca;
    public string Modelo;
    public int Año;
    public int Kilometraje;

    public void MostrarInformacion()
    {
        Console.WriteLine("----------------------------");
        Console.WriteLine($"Marca:{Marca}");
        Console.WriteLine($"Modelo:{Modelo}");
        Console.WriteLine($"Año:{Año}");
        Console.WriteLine($"Kilometraje:{Kilometraje}");
        Console.WriteLine("----------------------------");
    }
    public void Conducir(int km)
    {
        Kilometraje += km;
    }
}