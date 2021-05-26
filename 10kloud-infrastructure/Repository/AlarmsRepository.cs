﻿using _10kloud_AppCore.Entities;
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


        public IEnumerable<Alarm> GetByAlarmingParameter(string alarming_parameter)
        {

            const string query = @"SELECT name, description, silos_id, severityalarm, threshold,  user_email
FROM alarm
WHERE alarming_parameter=@Alarming_Parameter";
            using var connection = new NpgsqlConnection(_connectionString);
            return connection.Query<Alarm>(query, new
            {
                Alarming_Parameter = alarming_parameter
            });

            connection.Close();

        }

        public IEnumerable<Alarm> GetById(int Id)
        {

            const string query = @"SELECT name, description, silos_id, severityalarm, threshold, alarming_parameter, user_id
FROM alarm
WHERE id=@Id";
            using var connection = new NpgsqlConnection(_connectionString);
            return connection.Query<Alarm>(query);

            connection.Close();

        }


        /// <summary>
        /// call the database to insert a new Alarm throgh dapper contrib
        /// </summary>
        /// <param name="entity"></param>
        public void Insert(Alarm entity, string alarming_parameter, string user_email)
        {
            const string query = @"
INSERT INTO alarm( NAME, description, silos_id, severityalarm, threshold, alarming_parameter, user_email)
VALUES (@Name, @Description, @Silos_id, @Severity_Alarm, @Threshold, @alarming_parameter, @user_email)"; // gli passo i parametri di query con gli stessi nomi della classe category perchè dupper me li trasforma in parametri di query

            /*
             * INSERT INTO alarm( NAME, description, silos_id, severityalarm, threshold, alarming_parameter, user_email)
VALUES ( 'gino','descrizione', 1, 2, 7, 'pressione', 'b@b.it')
             *
             */
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Execute(query, entity);
            connection.Close();

        }

        public void Insert(Alarm entity)
        {
            throw new NotImplementedException();
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
