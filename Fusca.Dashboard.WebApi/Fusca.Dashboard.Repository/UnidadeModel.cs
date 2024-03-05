using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fusca.Dashboard.Repository
{
    public class ResultadoUnidadeModel
    {
        public int IdUnidade { get; set; }
        public string? NomeUnidade { get; set; }
        public StibaInfoModel? StibaInfo { get; set; }
        public GptwInfoModel? GptwInfo { get; set; }
        public CidInfoModel? CidInfo { get; set; }
        public DateTime? Ano { get; set; }

    }
}
