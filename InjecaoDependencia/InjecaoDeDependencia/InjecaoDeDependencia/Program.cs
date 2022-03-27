using InjecaoDeDependencia.Bom;
using System;
using System.Collections.Generic;

namespace InjecaoDeDependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var pedido = new PedidoModel()
            {
                Numero = 1,
                ClientEmail = "email@gmail.com",
                Itens = new List<string>() { "Item01", "Item02" },
                Valor = 1000
            };



            //com injeção
            var email = new EnviarEmail();
            new Pedido(email).CriarPedido(pedido);

            Console.ReadLine();
        }
    }
}