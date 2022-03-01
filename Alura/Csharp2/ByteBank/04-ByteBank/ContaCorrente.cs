public class ContaCorrente
{
    public string titular;
    public int agencia = 123;
    public int numero = 123;
    public double saldo = 100;

    public bool Sacar(double valor) {
        if (this.saldo < valor) {
            Console.WriteLine("Não foi possivel sacar!");
            return false;
        }
        else {
            this.saldo -= valor;
            return true;
        }
    }



}