using Momenty.Web.DAL.Entities;
using Momenty.Web.DAL.Repositories.Generic;
using System.Collections.Generic;

namespace Momenty.Web.DAL.Repositories
{
    public class FundRepository : GenericRepository<FundReturnRate>, IFundRepository
    {
        public FundRepository()
            : base("Funds")
        { }

        public List<FundReturnRate> GetReturnRatesForLastThirtyDays()
        {
            using(var connection = CreateConnection())
            {
                return new List<FundReturnRate>();
            }
        }
    }
}