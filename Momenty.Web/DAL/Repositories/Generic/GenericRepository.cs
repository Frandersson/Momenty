using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;

namespace Momenty.Web.DAL.Repositories.Generic
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["MomentyMain"].ConnectionString;
        private readonly string _tableName;

        public GenericRepository(string tableName)
        {
            _tableName = tableName;
        }

        private IDbConnection CreateConnection()
        {
            var factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
            var conn = factory.CreateConnection();
            conn.ConnectionString = _connectionString;

            return conn;
        }

        public TEntity Get(int Id)
        {
            using (var connection = CreateConnection())
            {
                connection.Open();
                return connection.QuerySingleOrDefault<TEntity>($"SELECT * FROM {_tableName} WHERE Id={Id}");
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            using (var connection = CreateConnection())
            {
                connection.Open();
                return connection.Query<TEntity>($"SELECT * FROM {_tableName}");
            }
        }

        public void Insert(TEntity entity)
        {
            using (var connection = CreateConnection())
            {
                connection.Open();
                connection.Insert(entity);
            }

        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}