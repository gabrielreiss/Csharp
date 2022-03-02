using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// See https://aka.ms/new-console-template for more information

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriel = new Cliente();
            gabriel.nome = "Gabriel";
            gabriel.profissao = "Desenvolvedor C#";
            gabriel.cpf = "123.123.123.12";

            ContaCorrente conta = new ContaCorrente();
            conta.titular = gabriel;
            conta.saldo = 500;
            conta.agencia = 123;
            conta.numero = 123456;

            conta.titular.nome = "Gabriel Reiss";

            Console.WriteLine(gabriel.nome);
            Console.WriteLine(conta.titular.nome);

            Console.ReadLine();
        }
    }
}