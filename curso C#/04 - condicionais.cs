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
            int a = 10;
            int b = 20;
            int c = 2;

            // (E ou AND) && e || (Ou/or)

            if(a < b || a > c) // Se
            {
                Console.WriteLine("É verdade");
            }
            else if(a > c)
            {
                Console.WriteLine("Executou elseif");
            }
            else // Se não
            {
                Console.WriteLine("É mentira");
            }

            Console.ReadLine();
        }
    }
}