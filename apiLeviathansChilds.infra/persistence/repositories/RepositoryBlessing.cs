using System;
using System.Collections.Generic;
using apiLeviathansChilds.domain.entities;
using apiLeviathansChilds.domain.interfaces.repositories;
using Npgsql;

namespace apiLeviathansChilds.infra.persistence.repositories
{
    public class RepositoryBlessing : IRepositoryBlessing
    {
        private readonly string _connectionString;

        public RepositoryBlessing(string connectionString) { this._connectionString = connectionString; }

        public List<Blessing> GetAll()
        {
            List<Blessing> blessings = new List<Blessing>();
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand($"SELECT * FROM \"blessings\"", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        blessings.Add(new Blessing(reader.GetGuid(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6)));
                    }
            }
            return blessings;
        }

        public Blessing GetById(Guid id)
        {
            Blessing blessing = null;
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand($"SELECT * FROM \"blessings\" WHERE id='{id.ToString()}'", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        blessing = new Blessing(reader.GetGuid(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6));
                    }
            }
            return blessing;
        }
    }
}