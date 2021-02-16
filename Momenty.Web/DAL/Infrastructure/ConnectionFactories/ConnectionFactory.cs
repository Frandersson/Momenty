using System.Configuration;
using System.Data;
using System.Data.Common;

namespace Momenty.Web.DAL.Infrastructure.ConnectionFactories
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["MomentyMain"].ConnectionString;

        public IDbConnection GetConnection()
        {
            var factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
            var conn = factory.CreateConnection();
            conn.ConnectionString = _connectionString;

            return conn;
        }
    }
}