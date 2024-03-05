using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fusca.Dashboard.Repository
{
    public class StibaPerguntasModel
    {
        public int NumeroPergunta { get; set; }
        public string? Pergunta { get; set; }
        public int? Nota { get; set; }
        public string? OrigemResposta { get; set; }
    }
}
