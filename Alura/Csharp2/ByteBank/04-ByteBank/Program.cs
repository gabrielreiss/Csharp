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

            conta.Depositar(500);
            Console.WriteLine(conta.saldo);

            ContaCorrente conta1 = new ContaCorrente();
            conta1.titular = "titular";

            bool resultadoTrans = conta.Transferir(200, conta1 );

            Console.WriteLine("saldo conta : " + conta.saldo);
            Console.WriteLine("saldo conta 1: "+ conta1.saldo);
            Console.WriteLine(resultadoTrans);

            Console.ReadLine();
        }
    }
}