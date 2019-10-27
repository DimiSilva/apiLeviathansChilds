using System;
using System.Collections.Generic;
using apiLeviathansChilds.domain.entities;
using apiLeviathansChilds.domain.interfaces.repositories;
using Npgsql;

namespace apiLeviathansChilds.infra.persistence.repositories
{
    public class RepositoryElement : IRepositoryElement
    {
        private readonly string _connectionString;

        public RepositoryElement(string connectionString) { this._connectionString = connectionString; }

        public List<Element> GetAll()
        {
            List<Element> elements = new List<Element>();
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand($"SELECT * FROM \"elements\"", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        elements.Add(new Element(reader.GetGuid(0), reader.GetString(1), reader.GetString(2), reader.GetFloat(3), reader.GetFloat(4), reader.GetFloat(5), reader.GetFloat(6)));
                    }
            }
            return elements;
        }

        public Element GetById(Guid id)
        {
            Element element = null;
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand($"SELECT * FROM \"elements\" WHERE id='{id.ToString()}'", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        element = new Element(reader.GetGuid(0), reader.GetString(1), reader.GetString(2), reader.GetFloat(3), reader.GetFloat(4), reader.GetFloat(5), reader.GetFloat(6));
                    }
            }
            return element;
        }
    }
}