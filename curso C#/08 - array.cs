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
            //não pode mudar o tamanho do array
            string[] produtos = new string[5]{
                "Sea of thieves", // 0
                "Lost ark", // 1
                "Path of Exile", // 2
                "Half-life", // 3
                "Portal" // 4
            };

            int[] valores = {40, 50, 60, 70, 20};

            Console.WriteLine(produtos[0]);

            Console.ReadLine();
        }
    }
}