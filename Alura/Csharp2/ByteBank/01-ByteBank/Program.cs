using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// See https://aka.ms/new-console-template for more information

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoGabriel = new ContaCorrente();

            contaDoGabriel.titular = "Gabriel";
            contaDoGabriel.agencia = 836;
            contaDoGabriel.numero = 123;
            contaDoGabriel.saldo = 100;

            Console.WriteLine(contaDoGabriel.titular);
            Console.WriteLine(contaDoGabriel.agencia);
            Console.WriteLine(contaDoGabriel.numero);
            Console.WriteLine(contaDoGabriel.saldo);

            Console.ReadLine();
        }
    }
}