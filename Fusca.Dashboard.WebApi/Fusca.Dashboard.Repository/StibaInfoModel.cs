using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fusca.Dashboard.Repository
{
    public class StibaInfoModel
    {
        public string? OrigemResposta { get; set; }
        public float? RespostasElegiveis { get; set; }
        public float? Respondentes { get; set; }
        public float? PorcentagemRespostas { get; set; }
        public string? NotaStiba { get; set; }
        public List<StibaPerguntasModel>? RespostasPerguntas { get; set; }
        public int? Ano { get; set; }
    }
}