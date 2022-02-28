using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {

        enum Cor {Azul = 33, Verde, Amarelo, Vermelho}
        //determina o numero indice do enum
        enum Opcoes {Criar = 1, Deletar, Editar, Listar, Atualizar}

        static void Main(string[] args)
        {
            Console.WriteLine("Selecione uma das opções abaixo: ");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");

            int index = int.Parse(Console.ReadLine());
            Opcoes opcaoSelecionada = (Opcao)index;

            switch (opcaoSelecionada){
                case Opcoes.Criar:
                    Console.WriteLine("Você quer criar algo");
                    break;
                case Opcoes.Deletar:
                    Console.WriteLine("Você quer deletar algo");
                    break;
                case Opcoes.Editar:
                    Console.WriteLine("Você quer editar algo");
                    break;
                case Opcoes.Listar:
                    Console.WriteLine("Você quer listar algo");
                    break;
                case Opcoes.Atualizar:
                    Console.WriteLine("Você quer atualizar algo");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            Console.ReadLine();
        }
    }
}