using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fusca.Dashboard.Repository
{
    public interface IStibaRepository
    {
        Task<StibaInfoModel> RequisitarParticipacao();
        Task<List<StibaInfoModel>> RequisitarPesquisaStibaArea();
    }
}
