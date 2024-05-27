
// CONSTRUCTORES DE CLASE -> Generalmente para inicializar un objeto con parametros
/*Propiedades de un constructor:
    - Es una funcion
    - No tiene valor de retorno
    - Puede recibir parametros
    - Es publica
    - Se llama igual que la clase
    - Se ejecuta UNA SOLA VEZ al crear (instanciar) el objeto */

cuantaBancaria cuentita = new cuantaBancaria("pepe");

cuentita.Depositar(100);
cuentita.Extraer(1000);

class cuantaBancaria
{
    public cuantaBancaria(string titular)
    {
        Titular = titular;
    }

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