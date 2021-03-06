using _01_ByteBank;

namespace _06_ByteBank
{ 
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        private double saldo;

        public void DefinirSaldo(double saldo)
        {
            if (saldo < 0)
            {
                return;
            }
            else
            {
                this.saldo = saldo;
            }
        }

        public double ObterSaldo() 
        {
            return saldo;
        }

        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }

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