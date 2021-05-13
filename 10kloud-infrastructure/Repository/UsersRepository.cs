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
    public class UsersRepository : IRepositoryUsers
    {
        private readonly string _connectionString;
        private readonly IConfiguration _configuration;

        public UsersRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("10kloud");
            _configuration = configuration;
        }
        public bool Delete(int id)
        {
            using var connection = new NpgsqlConnection(_connectionString);

            if (connection.Delete<User>(new User { Id = id }))
            {
                return true;
            }
            else
                return false;
        }


        public User Get(int id)
        {
            using var connection = new NpgsqlConnection(_connectionString);
           return connection.Get<User>(id);

        }

        public IEnumerable<User> GetAll()
        {
            using var connection = new NpgsqlConnection(_connectionString);
            return connection.GetAll<User>();
        }

        public void Insert(User entity)
        {
            using var connection = new NpgsqlConnection(_connectionString);
             connection.Insert<User>(entity);
        }

        public void Update(User entity)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Update<User>(entity);
        }
    }
}
