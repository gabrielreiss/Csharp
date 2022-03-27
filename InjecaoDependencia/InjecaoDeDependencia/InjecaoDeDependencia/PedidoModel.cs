using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDeDependencia
{
    public class PedidoModel
    {
        public int Numero { get; set; }
        public string ClientEmail { get; set; }
        public List<string> Itens { get; set; }
        public int Valor { get; set; }
    }
}
