using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDeDependencia
{
    public class EnviarEmail : IEnviarEmail
    {
        public bool Enviar(string email, string conteudo)
        {
            //codigode envio de email

            //se der sucesso retorna true

            return true;
        }
    }
}
