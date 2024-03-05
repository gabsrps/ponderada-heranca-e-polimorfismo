using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fusca.Dashboard.Repository
{
    public interface IZenKlubRepository
    {
        Task<List<ZenKlubModel>> GetSessionsFactory();

        Task<ZenKlubModel> GetSessions();
    }
}
