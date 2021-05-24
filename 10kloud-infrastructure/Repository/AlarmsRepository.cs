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
    /// this class ereditate all methods from it interface IRepositoryAlamrs
    /// </summary>
    public class AlarmsRepository : IRepositoryAlamrs
    {

        private readonly string _connectionString; // connection string

        private readonly IConfiguration _configuration;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="configuration"></param>
        public AlarmsRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("10kloud");
            _configuration = configuration;
        }

        /// <summary>
        /// call the database to delete an Alarm throgh dapper contrib
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            using var connection = new NpgsqlConnection(_connectionString);

            connection.Delete<Alarm>(new Alarm { Id = id });

        }
        /// <summary>
        /// call the database to get an Alarm throgh dapper contrib
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Alarm Get(int id)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            return connection.Get<Alarm>(id);
        }
        /// <summary>
        /// call the database to get all Alarms throgh dapper contrib
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Alarm> GetAll()
        {
            using var connection = new NpgsqlConnection(_connectionString);
            return connection.GetAll<Alarm>();
        }
        /// <summary>
        /// call the database to insert a new Alarm throgh dapper contrib
        /// </summary>
        /// <param name="entity"></param>
        public void Insert(Alarm entity)
        {
            const string query = @"
INSERT INTO alarm(name, description, silos_id, severity_alarm, threshold, alarming_parameter, user_id)
VALUES (@Name, @Description, @Silos_id, @Severity_alarm, @Threshold, @Alarming_parameter, @User_id)"; // gli passo i parametri di query con gli stessi nomi della classe category perchè dupper me li trasforma in parametri di query


            using var connection = new NpgsqlConnection(_connectionString);
            connection.Execute(query, entity);

        }
        /// <summary>
        /// call the database to update an Alarm throgh dapper contrib
        /// </summary>
        /// <param name="entity"></param>
        public void Update(Alarm entity)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Get<Alarm>(entity);
        }
    }
}
