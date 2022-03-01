using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// See https://aka.ms/new-console-template for more information

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Gabriel";


            Console.WriteLine(conta.titular);
            Console.WriteLine(conta.saldo);

            bool resultadoSaque = conta.Sacar(50);
            Console.WriteLine(conta.saldo);

            Console.ReadLine();
        }
    }
}

//parei no metodo sem retorno.