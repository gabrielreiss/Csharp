using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDeDependencia.Bom
{
    public class Pedido
    {
        private EnviarEmail _email;

        public Pedido(EnviarEmail email)
        {
            _email = email;
        }
        public void CriarPedido(PedidoModel pedidoModel)
        {
            _email.Enviar(pedidoModel.ClientEmail, $"Seu pedido {pedidoModel.Numero} foi gerado com sucesso");
        }
    }
}
