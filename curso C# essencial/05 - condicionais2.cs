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
            // O usuario digita a sua idade e o programa classifica ele como criança, adulto ou idoso
            Console.WriteLine("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if(idade >=0 && idade <=11)
            {
                Console.WriteLine("Você é uma criança!");
            }
            else if (idade >= 12 && idade <= 18)
            {
                Console.WriteLine("Você é um adolescente!");
            }
            else if (idade >= 19 && idade <= 60)
            {
                Console.WriteLine("Você é um adulto!");
            }
            else
            {
                Console.WriteLine("Você é um idoso!");
            }


            Console.ReadLine();
        }
    }
}