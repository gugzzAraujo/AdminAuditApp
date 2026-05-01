using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminAuditApp.Models
{
    public class ResultadoOperacao
    {
        // Propriedade que diz se a operação foi um sucesso (true) ou falha (false)
        public bool Sucesso { get; set; }

        // Propriedade que guarda a mensagem de erro (caso Sucesso seja false)
        public string MensagemErro { get; set; }
    }
}
