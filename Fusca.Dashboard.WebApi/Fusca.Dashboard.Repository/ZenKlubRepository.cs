using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fusca.Dashboard.Repository
{
    public class ZenKlubRepository : IZenKlubRepository
    {
        private readonly string _dbConfig;

        public ZenKlubRepository(string dbConfig)
        {
            _dbConfig = dbConfig;
        }


        public async Task<List<ZenKlubModel>> GetSessionsFactory()
        {
            using (var conn = new NpgsqlConnection(_dbConfig))
            {
                await conn.OpenAsync();
                var results = await conn.QueryAsync<ZenKlubModel>(@"
                SELECT departamento, SUM(total_sessoes) AS TotalSessoes
                FROM zenKlub
                WHERE departamento IS NOT NULL
                GROUP BY departamento;
                ");
                return results.ToList();
            }
        }

        public async Task<ZenKlubModel> GetSessions()
        {
            using (var conn = new NpgsqlConnection(_dbConfig))
            {
                await conn.OpenAsync();
                var result = await conn.QueryFirstOrDefaultAsync<ZenKlubModel>(@"
                SELECT SUM(total_sessoes) AS TotalSessoes
                FROM zenKlub
                WHERE departamento IS NOT NULL;
                ");
                return result;
            }
        }

    }
}
