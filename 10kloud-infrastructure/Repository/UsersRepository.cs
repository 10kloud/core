using _10kloud_AppCore.Entities;
using _10kloud_AppCore.Interfaces.Repository;
using Dapper;
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
    /// <summary>
    /// this repository contains al CRUD methods developed with dapper contrib, it takes the connection string 
    /// from the secret file and through dapper contrib call the database
    /// this class ereditate all methods from it interface IRepositoryUsers
    /// </summary>
    public class UsersRepository : IRepositoryUsers
    {
        private readonly string _connectionString; // connection string
        private readonly IConfiguration _configuration;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="configuration"></param>
        public UsersRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("10kloud");
            _configuration = configuration;
        }
        /// <summary>
        /// call the database to delete a User throgh dapper contrib
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            using var connection = new NpgsqlConnection(_connectionString);

            connection.Delete<User>(new User { Id = id });
        }

        /// <summary>
        /// call the database to get a User throgh dapper contrib
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User Get(int id)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            return connection.Get<User>(id);

        }

        /// <summary>
        /// call the database to get all User throgh dapper contrib
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> GetAll()
        {
            char apici = '"';
            string table = apici + "AspNetUsers" + apici;
            string UN = apici + "UserName" + apici;
            string PN = apici + "PhoneNumber" + apici;

            string query = "SELECT" + UN + ", " + PN + " FROM " + table;

            using var connection = new NpgsqlConnection(_connectionString);
            return connection.Query<User>(query);


            connection.Close();

        }

        /// <summary>
        /// call the database to insert a new User throgh dapper contrib
        /// </summary>
        /// <param name="entity"></param>
        public void Insert(User entity)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Insert<User>(entity);
        }

        /// <summary>
        /// call the database to update a Userthrogh dapper contrib
        /// </summary>
        /// <param name="entity"></param>
        public void Update(User entity)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Update<User>(entity);
        }
    }
}
