using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente PrimeiraConta= new ContaCorrente();

            PrimeiraConta.saldo = 200;
            Console.WriteLine(PrimeiraConta.saldo);

            PrimeiraConta.saldo += 100;
            Console.WriteLine(PrimeiraConta.saldo);

            ContaCorrente SegundaConta = new ContaCorrente();

            SegundaConta.saldo = 50;

            Console.WriteLine("primeira conta tem " + PrimeiraConta.saldo);
            Console.WriteLine("segunda conta tem " + SegundaConta.saldo);

            SegundaConta.Depositar(500);
            Console.WriteLine("segunda conta tem " + SegundaConta.saldo);

            PrimeiraConta.titular = new Cliente();
            PrimeiraConta.titular.nome = "Camila";
            Console.WriteLine(PrimeiraConta.titular.nome);

            Console.ReadLine();
        }
    }
}
