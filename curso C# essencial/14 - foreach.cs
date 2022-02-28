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
            string[] nomes = {
                "Victor",
                "Lima",
                "Guia do prog",
                "Formação",
                "C#"
            };

            foreach (string palavra in nomes) // para cada palavra no array palavras, repita o bloco de código
            {
                Console.WriteLine(palavra);
            }

            Console.ReadLine();
        }
    }
}