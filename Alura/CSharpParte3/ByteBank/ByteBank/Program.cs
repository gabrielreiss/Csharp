using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Funcionario carlos = new Funcionario();

            //carlos.Nome = "Carlos";
            // carlos.CPF = "546.879.157-20";
            //carlos.Salario = 2000;

            Funcionario roberta = new Diretor("123");

            roberta.Nome = "Roberta";
            //roberta.CPF = "123.456.789-20";
            //roberta.Salario = 5000;

            //Console.WriteLine(carlos.Nome);
            //Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.ReadLine();
        }
    }
}
