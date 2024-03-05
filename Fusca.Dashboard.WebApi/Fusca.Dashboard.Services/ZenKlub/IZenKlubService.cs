using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fusca.Dashboard.Repository;

namespace Fusca.Dashboard.Services.ZenKlub
{
    public interface IZenKlubService
    {
        Task<List<ZenKlubModel>> GetSessionsFactoryZenKlub();

        Task<ZenKlubModel> GetSessionsTotal();
    }
}
