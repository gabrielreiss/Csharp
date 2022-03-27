using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDeDependencia
{
    public class Pedido : IPedido
    {
        private IEnviarEmail _enviarEmail;

        public Pedido(IEnviarEmail enviarEmail) 
        {
            _enviarEmail = enviarEmail;
        }

        public PedidoModel CriarPedido(PedidoModel pedidoModel) {

            pedidoModel.Numero = 5;

            _enviarEmail.Enviar(pedidoModel.ClientEmail, $"Seu pedido {pedidoModel.Numero} foi gerado com sucesso");

            return pedidoModel;
        }
    }
}
