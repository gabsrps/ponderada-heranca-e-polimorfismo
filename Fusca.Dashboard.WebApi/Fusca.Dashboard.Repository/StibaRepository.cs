using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Npgsql;

namespace Fusca.Dashboard.Repository
{
    public class StibaRepository : IStibaRepository
    {
        private readonly string _dbConfig;

        public StibaRepository(string dbConfig)
        {
            _dbConfig = dbConfig;
        }


        public async Task<StibaInfoModel> RequisitarParticipacao()

        {

            using (var conn = new NpgsqlConnection(_dbConfig))
            {
                await conn.OpenAsync();
                var result = await conn.QueryFirstOrDefaultAsync<StibaInfoModel>(@"
                    SELECT 
                        AVG(""% particip"") as PorcentagemRespostas
                    FROM 
                        stiba_2023
                ");
                return result;
            }

        }

        public async Task<StibaInfoModel> RequisitarPesquisaStiba()

        {

            using (var conn = new NpgsqlConnection(_dbConfig))
            {
                await conn.OpenAsync();
                var result = await conn.QueryFirstOrDefaultAsync<StibaInfoModel>(@"
                    SELECT 
                        AVG(""% particip"") as PorcentagemRespostas
                    FROM 
                        stiba_2023
                ");
                return result;
            }

        }


        public async Task<List<StibaInfoModel>> RequisitarPesquisaStibaArea()
        {
            using (var conn = new NpgsqlConnection(_dbConfig))
            {
                await conn.OpenAsync();
                var results = await conn.QueryAsync<StibaInfoModel>(@"
            SELECT 
                ""% particip"" as PorcentagemRespostas,
                ""Descrição UO"" as OrigemResposta,
                ""Elegíveis"" as RespostasElegiveis,
                ""Respondentes"" as Respondentes,
                ""Nota Stiba"" as NotaStiba
            FROM 
                stiba_2023;
        ");
                return results.ToList();
            }
        }


    }


}
