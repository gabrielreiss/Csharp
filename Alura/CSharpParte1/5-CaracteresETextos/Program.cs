using System;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - caracteres e texto");

            // character
            char letra = 'a';
            Console.WriteLine(letra);

            letra = (char)65;
            Console.WriteLine(letra);

            letra = (char)(letra + 1);
            Console.WriteLine(letra);

            string texto = "Alura Cursos";
            Console.WriteLine(texto);

            texto = texto + 2020;
            Console.WriteLine(texto);

            Console.ReadLine();
        }
    }
}
