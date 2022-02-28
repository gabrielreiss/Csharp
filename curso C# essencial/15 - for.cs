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

            //ordem crescente
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(nomes[i]);
            }

            //for invertido
            for (contador = nomes.Length -1; contador > 0; contador--){
                Console.WriteLine(i);
                Console.WriteLine(nomes[i]);
            }


            Console.ReadLine();
        }
    }
}