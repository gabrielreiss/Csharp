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
            string cor = "Azul";

            //criqção para menus, somente compara igualdades
            switch(cor){
                case "Vermelho":
                    Console.WriteLine("Sua cor favorita é vermelho!");
                    break;
                case "Amarelo":
                    Console.WriteLine("Sua cor favorita é amarelo!");
                    break;
                case "Azul":
                    Console.WriteLine("Sua cor favorita é azul!");
                    break;
                case "Rosa":
                    Console.WriteLine("Sua cor favorita é rosa!");
                    break;
                default:
                    Console.WriteLine("Sua cor favorita é diferenciada");
                    break;
            }
            Console.ReadLine();
        }
    }
}