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

            ExibirMsg();
            GerarPreco(60);
            GerarPreco(-30);
            GerarPreco(-20);

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
    }
}