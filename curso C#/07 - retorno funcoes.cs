using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            int soma1 = Somar(1, 2, 3);
            int soma2 = Somar(10, 20, 30);

            Console.WriteLine(soma1);
            Console.WriteLine(soma2);

            Console.ReadLine();
        }

        static void ExibirMsg()
        {
            Console.WriteLine("Bem vindo!");
            Console.WriteLine("Utilizando funções");

        }

        static void GerarPreco(int preco)
        {
            int precoAbs = Math.Abs(preco);
            int valorFinal = precoAbs + (2 * precoAbs);
            Console.WriteLine("Valor final: " + valorFinal);
        }

        static int Somar(int a , int b, int c)
        {
            int resultadoFinal = a + b + c;
            return resultadoFinal;
        }
    }
}