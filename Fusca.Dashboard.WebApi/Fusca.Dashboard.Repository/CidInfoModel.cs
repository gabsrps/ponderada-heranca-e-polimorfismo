using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fusca.Dashboard.Repository
{
    public class CidInfoModel
    {
        public DateTime? MesOcorrencia { get; set; }
        public int? NumeroFuncionario { get; set; }
        public int? NumeroDeAtestados { get; set; }
        public int? DiasAtestados { get; set; }
        public string? Diretoria { get; set; }
        public string? Unidade { get; set; }
        public string? InfoExtra { get; set; }
        public DateTime? Ano { get; set; }
    }
}
