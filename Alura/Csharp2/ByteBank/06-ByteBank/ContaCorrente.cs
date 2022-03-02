//using _05_ByteBank;

namespace _06_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }

        private double _saldo = 100;

        //função
        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                Console.WriteLine("Não foi possivel sacar!");
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
            }
        }

        //método
        public void Depositar(double valor)
        {
            this._saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }

        }

        /*
        public double GetSaldo() 
        { 
            return saldo;
        }
        public void SetSaldo(double saldo) 
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
        */

        public double Saldo
        {
            get 
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    _saldo = value;
                }
            }
        }
    }
}