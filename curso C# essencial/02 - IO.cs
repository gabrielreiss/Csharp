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
            Console.Write("Escreva seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Seu nome é: ");
            Console.WriteLine(nome);

            Console.ReadLine();
        }
    }
}