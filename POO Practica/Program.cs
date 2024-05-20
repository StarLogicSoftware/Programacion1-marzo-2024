/*  PRACTICA POO - Ejercicio 1
 Hacer un programa para calcular el promedio de notas de un curso de 5 personas.
 Cada examen se necesita saber la nota y el nombre del alumno.
 Tareas:
    1- Obtener el promedio del curso
    2- La nota mayor y la nota menor
    3- Mostrar nombre del alumno de la nota mayor
 */

/* Machetito suave
-> 5 objetos
-> 1 clase -> Examen (justifique su respuesta)
-> propiedades: nombre, apellido, calificacion
-> metodos: MostrarInformacion, Cargar
*/
/*
Examen examen1 = new Examen();
Examen examen2 = new Examen();
Examen examen3 = new Examen();
Examen examen4 = new Examen();
Examen examen5 = new Examen();

examen1.Cargar();
examen2.Cargar();
examen3.Cargar();
examen4.Cargar();
examen5.Cargar();

int Promedio;

Promedio = (examen1.Nota + examen2.Nota
    + examen3.Nota + examen4.Nota + examen5.Nota) / 5;

Console.WriteLine($"El promedio general es: {Promedio}");

class Examen
{
    public string Nombre;
    public string Apellido;
    public int Nota;

    public void MostrarInformacion()
    {
        Console.WriteLine($"Alumno: {Nombre} {Apellido} Nota: {Nota}");
    }

    public void Cargar()
    {
        Console.Write("Nombre alumno: ");
        Nombre = Console.ReadLine();
        Console.Write("Apellido alumno: ");
        Apellido = Console.ReadLine();
        Console.Write("Nota alumno: ");
        Nota = int.Parse(Console.ReadLine());

        Console.WriteLine("-----------------");
    }
}
*/




/* --- Problema nº 2 ---
Un banco quiere realizar un sistema para manejar el dinero de cuentas de sus clientes
El sistema guarda el numero de cuenta, el nombre y el saldo del cliente
En cada cuenta podemos retirar dinero y depositar dinero, ademas de poder ver
el estado de cuenta de cada cliente
    1- Determinar clases, metodos y propiedades necesarias
    2- Verificar que no se puede retirar mas del dinero disponible
 */

/*
 1- clase Cuenta
    1.1-> propiedades (variables) nro cuenta, titular, saldo
    2.2-> metodos (funciones) depositar, extraer
 */


Cuenta cuenta1 = new Cuenta();

cuenta1.Nrocuenta = "1234-56";
cuenta1.Titular = "Nicolas";
cuenta1.Saldo = 22000;

cuenta1.VerEstadoCuenta();

cuenta1.Depositar();

cuenta1.VerEstadoCuenta();

cuenta1.Extraer();

cuenta1.VerEstadoCuenta();

class Cuenta
{
    public string Nrocuenta;
    public string Titular;
    public float Saldo;

    public void Depositar()
    {
        float monto;

        Console.Write("Monto a depositar: ");
        monto = float.Parse(Console.ReadLine());

        if(monto > 0)
        {
            Saldo += monto;
        }
        else
        {
            Console.WriteLine("No se puede depositar un valor menor o igual a cero");
        }
    }
    public void Extraer()
    {
        float monto;

        Console.Write("Monto a retirar: ");
        monto = float.Parse(Console.ReadLine());

        if(monto > Saldo)
        {
            Console.WriteLine("No podes retirar mas del dinero disponible");
        }
        else
        {
            Saldo -= monto;
        }
    }

    public void VerEstadoCuenta()
    {
        Console.WriteLine();
        Console.WriteLine($"{Nrocuenta} - {Titular} - ${Saldo}");
        //Console.WriteLine(Nrocuenta + " - " + Titular + " - $" + Saldo);
        Console.WriteLine();
    }
}