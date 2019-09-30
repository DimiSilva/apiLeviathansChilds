using System;
using System.Collections.Generic;
using System.Linq;
using apiLeviathansChilds.domain.arguments;
using apiLeviathansChilds.domain.entities;
using apiLeviathansChilds.domain.interfaces.repositories;
using Npgsql;

namespace apiLeviathansChilds.infra.persistence.repositories
{
    public class RepositoryUser : IRepositoryUser
    {
        private readonly string _connectionString;

        public RepositoryUser(string connectionString) { this._connectionString = connectionString; }

        public List<User> GetAll()
        {
            List<User> users = new List<User>();
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand($"SELECT * FROM \"users\"", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        users.Add(new User(reader.GetGuid(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5)));
                    }
            }
            return users;
        }

        public User GetById(Guid id)
        {
            User user = null;
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand($"SELECT * FROM \"users\" WHERE id='{id.ToString()}'", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        user = new User(reader.GetGuid(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                    }
            }
            return user;
        }

        public User GetByNick(string nick)
        {
            User user = null;
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand($"SELECT * FROM \"users\" WHERE nick='{nick}'", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        user = new User(reader.GetGuid(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                    }
            }
            return user;
        }

        public Guid Insert(User user)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand($"INSERT INTO \"users\" VALUES('{user.id.ToString()}', '{user.name.firstName}', '{user.name.lastName}', '{user.nick}', '{user.email.adress}', '{user.password}')", conn))
                    cmd.ExecuteNonQuery();
            }
            return user.id;
        }

        public BaseRes Remove(Guid id)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand($"DELETE FROM \"users\" WHERE id='{id.ToString()}'", conn))
                    cmd.ExecuteNonQuery();
            }
            return new BaseRes("User removed");
        }

        public BaseRes Update(User user)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand($"UPDATE \"users\" SET firstname='{user.name.firstName}', lastname='{user.name.lastName}', nick='{user.nick}', emailadress='{user.email.adress}', password='{user.password}' WHERE id='{user.id.ToString()}'", conn))
                    cmd.ExecuteNonQuery();
            }
            return new BaseRes("User updated");
        }
    }
}