using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fusca.Dashboard.Repository;

namespace Fusca.Dashboard.Services.Stiba
{
    public class StibaService : IStibaService
    {
        private readonly IStibaRepository _stibaRepository;

        public StibaService(IStibaRepository stibaRepository)
        {
            _stibaRepository = stibaRepository;
        }

        public async Task<StibaInfoModel> ObterParticipacao() => await _stibaRepository.RequisitarParticipacao();

        public async Task<List<StibaInfoModel>> RequisitarPesquisaStibaArea() => await _stibaRepository.RequisitarPesquisaStibaArea();
    }


}
