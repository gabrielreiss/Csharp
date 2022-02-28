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
            int contador = 0;
            //pelo menos uma vez ele vai ser educado, mesmo se for falsa
            do{
                Console.WriteLine("Rodando o while! n = "+ contador);
                contador++;
                //contador += 1
                //contador = contador + 1
            }while (contador < 10);


            Console.ReadLine();
        }
    }
}