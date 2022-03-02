//using _05_ByteBank;

namespace _05_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia = 123;
        public int numero = 123;
        public double saldo = 100;

        //função
        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                Console.WriteLine("Não foi possivel sacar!");
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }

        //método
        public void Depositar(double valor)
        {
            this.saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}