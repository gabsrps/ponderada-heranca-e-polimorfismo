using Fusca.Dashboard.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fusca.Dashboard.Services.Stiba
{
    public interface IStibaService
    {
        public Task<StibaInfoModel> ObterParticipacao();
        public Task<List<StibaInfoModel>> RequisitarPesquisaStibaArea();
    }
}
