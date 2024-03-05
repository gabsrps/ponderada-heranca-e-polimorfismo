using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fusca.Dashboard.Repository
{
    public class GptwInfoModel
    {
        public string? OrigemResposta { get; set; }
        public List<GptwPerguntasModel>? ResultadoPerguntas { get; set; }
        public DateTime? Ano { get; set; }
    }
}
