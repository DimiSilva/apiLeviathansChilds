using System;
using System.Collections.Generic;
using apiLeviathansChilds.domain.entities;
using apiLeviathansChilds.domain.interfaces.repositories;
using Npgsql;

namespace apiLeviathansChilds.infra.persistence.repositories
{
    public class RepositoryAmulet : IRepositoryAmulet
    {
        private readonly string _connectionString;

        public RepositoryAmulet(string connectionString) { this._connectionString = connectionString; }

        public List<Amulet> GetAll()
        {
            List<Amulet> amulets = new List<Amulet>();
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand($"SELECT * FROM \"amulets\"", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        amulets.Add(new Amulet(reader.GetGuid(0), reader.GetString(1), reader.GetString(2), reader.GetFloat(3), reader.GetFloat(4), reader.GetFloat(5), reader.GetFloat(6), reader.GetInt32(7), reader.GetFloat(8)));
                    }
            }
            return amulets;
        }

        public Amulet GetById(Guid id)
        {
            Amulet amulet = null;
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand($"SELECT * FROM \"amulets\" WHERE id='{id.ToString()}'", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        amulet = new Amulet(reader.GetGuid(0), reader.GetString(1), reader.GetString(2), reader.GetFloat(3), reader.GetFloat(4), reader.GetFloat(5), reader.GetFloat(6), reader.GetInt32(7), reader.GetFloat(8));
                    }
            }
            return amulet;
        }
    }
}