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
            //enquanto for verdade, faça
            while (contador < 10){
                Console.WriteLine("Rodando o while! n = "+ contador);
                contador++;
                //contador += 1
                //contador = contador + 1
            }


            Console.ReadLine();
        }
    }
}