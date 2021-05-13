using _10kloud_AppCore.Entities;
using _10kloud_AppCore.Interfaces.Repository;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10kloud_infrastructure.Repository
{
    public class AlarmsRepository : IRepositoryAlamrs
    {
        private readonly string _connectionString;
        private readonly IConfiguration _configuration;

        public AlarmsRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("10kloud");
            _configuration = configuration;
        }
        public bool Delete(int id)
        {
            using var connection = new NpgsqlConnection(_connectionString);

            if (connection.Delete<Alarm>(new Alarm { Id = id }))
            {
                return true;
            }
            else
                return false;
        }

        public Alarm Get(int id)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            return connection.Get<Alarm>(id);
        }

        public IEnumerable<Alarm> GetAll()
        {
            using var connection = new NpgsqlConnection(_connectionString);
            return connection.GetAll<Alarm>();
        }

        public void Insert(Alarm entity)
        {
            using var connection = new NpgsqlConnection(_connectionString);
             connection.Get<Alarm>(entity);
            
        }

        public void Update(Alarm entity)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Get<Alarm>(entity);
        }
    }
}
