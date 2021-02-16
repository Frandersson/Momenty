using Dapper;
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
                return connection.QuerySingleOrDefault<TEntity>($"SELECT * FROM {typeof(TEntity).Name}s WHERE Id={Id}");
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            using (var connection = CreateConnection())
            {
                connection.Open();
                return connection.Query<TEntity>($"SELECT * FROM {typeof(TEntity).Name}s");
            }
        }

        public void Add(TEntity entity)
        {
            var columns = GetColumns();
            var stringOfColumns = string.Join(", ", columns);
            var stringOfParameters = string.Join(", ", columns.Select(e => "@" + e));
            var query = $"INSERT INTO {typeof(TEntity).Name}s ({stringOfColumns}) VALUES ({stringOfParameters})";

            using (var connection = CreateConnection())
            {
                connection.Open();
                connection.Execute(query, entity);
            }
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<string> GetColumns()
        {
            return typeof(TEntity)
                    .GetProperties()
                    .Where(e => e.Name != "Id" && !e.PropertyType.GetTypeInfo().IsGenericType)
                    .Select(e => e.Name);
        }
    }
}