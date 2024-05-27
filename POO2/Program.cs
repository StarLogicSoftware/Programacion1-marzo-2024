cuantaBancaria cuentita = new cuantaBancaria();

cuentita.Depositar(100);
cuentita.Extraer(1000);

class cuantaBancaria
{
    public string Titular;
    private int saldo;

    public void Depositar(int cantidad)
    {
       if(cantidad < 0)
        {
            Console.WriteLine("El valor no puede ser negativo");
        }
        else
        {
            saldo += cantidad;
        }
    }

    public void Extraer(int cantidad)
    {
        if(cantidad > saldo)
        {
            Console.WriteLine("No te alcanza la guita");
        }
        else
        {
            // dar plata
        }
    }
}