using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using SalaryCalculator.Infrustructure.IRepositories;
using SalaryCalculator.Infrustructure.Models;
using System.Data;

namespace SalaryCalculator.Infrustructure.Repositories
{
    public class ReadRepository : IReadRepository
    {
        private readonly IDbConnection dbContext;

        public ReadRepository(IConfiguration configuration)
        {
            this.dbContext = new SqlConnection(configuration.GetConnectionString("ConnectionString"));
        }
        public IEnumerable<SalaryDetails> GetAll()
        {
            var sql = $@"SELECT * FROM [dbo].[SalaryDetails] ";
            return dbContext.Query<SalaryDetails>(sql).ToList();
        }

        public IEnumerable<SalaryDetails> GetByDate(DateTime? fromDate, DateTime? toDate)
        {
            var sql = $@"SELECT * FROM [dbo].[SalaryDetails] 
                        Where (@FromDate is null or Date >=@FromDate)
                            and (@ToDate is null or Date <=@ToDate)";
            return dbContext.Query<SalaryDetails>(sql, new { @FromDate = fromDate, @ToDate = toDate }).ToList();
        }

    }
}
