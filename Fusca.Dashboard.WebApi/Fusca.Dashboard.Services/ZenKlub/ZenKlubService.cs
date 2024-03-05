using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fusca.Dashboard.Repository;

namespace Fusca.Dashboard.Services.ZenKlub
{
    public class ZenKlubService: IZenKlubService
    {
        private readonly IZenKlubRepository _zenKlubRepository;

        public ZenKlubService(IZenKlubRepository zenKlubRepository)
        {
            _zenKlubRepository = zenKlubRepository;
        }

        public async Task<List<ZenKlubModel>> GetSessionsFactoryZenKlub()
        {
            return await _zenKlubRepository.GetSessionsFactory();
        }

        public async Task<ZenKlubModel> GetSessionsTotal()
        {
            return await _zenKlubRepository.GetSessions();
        }


    }
}
