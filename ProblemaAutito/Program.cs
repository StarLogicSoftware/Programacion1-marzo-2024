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
Coche autito = new Coche();

autito.Marca = "Fiat";
autito.Modelo = "Palio";
autito.Año = 2014;
autito.Kilometraje = 103250;

autito.MostrarInformacion();

int KmRecorridos;
Console.Write("Ingrese los km que ha recorrido: ");
KmRecorridos = int.Parse(Console.ReadLine());

autito.Conducir(KmRecorridos);

autito.MostrarInformacion();


class Coche
{
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