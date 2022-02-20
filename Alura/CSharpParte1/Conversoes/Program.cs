using System;

namespace Conversoes
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            salario = 1200.50;

            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            // O long é uma variável de 64 bits
            long idade;
            idade = 260000000000000000;
            Console.WriteLine(idade);

            // O short é um tipo de variavel de 16 bits
            short quantidadeProdutos;
            quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.66f;
            Console.WriteLine(altura);
            
            Console.ReadLine();
        }
    }
}
