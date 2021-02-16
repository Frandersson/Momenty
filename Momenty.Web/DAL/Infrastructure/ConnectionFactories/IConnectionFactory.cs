using System.Data;

namespace Momenty.Web.DAL.Infrastructure.ConnectionFactories
{
    public interface IConnectionFactory
    {
        IDbConnection GetConnection();
    }
}