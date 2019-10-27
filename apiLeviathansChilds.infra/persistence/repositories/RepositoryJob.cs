using System;
using System.Collections.Generic;
using apiLeviathansChilds.domain.entities;
using apiLeviathansChilds.domain.interfaces.repositories;
using Npgsql;

namespace apiLeviathansChilds.infra.persistence.repositories
{
    public class RepositoryJob : IRepositoryJob
    {
        private readonly string _connectionString;

        public RepositoryJob(string connectionString) { this._connectionString = connectionString; }

        public List<Job> GetAll()
        {
            List<Job> jobs = new List<Job>();
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand($"SELECT * FROM \"jobs\"", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        jobs.Add(new Job(reader.GetGuid(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetInt32(7), reader.GetFloat(8), reader.GetFloat(9), reader.GetFloat(10), reader.GetFloat(11), reader.GetFloat(12), reader.GetInt32(13)));
                    }
            }
            return jobs;
        }

        public Job GetById(Guid id)
        {
            Job job = null;
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand($"SELECT * FROM \"jobs\" WHERE id='{id.ToString()}'", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        job = new Job(reader.GetGuid(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetInt32(7), reader.GetFloat(8), reader.GetFloat(9), reader.GetFloat(10), reader.GetFloat(11), reader.GetFloat(12), reader.GetInt32(13));
                    }
            }
            return job;
        }
    }
}