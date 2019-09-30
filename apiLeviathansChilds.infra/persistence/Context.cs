using System;
using Npgsql;

namespace apiLeviathansChilds.infra.persistence
{
    public class Context
    {
        private readonly string _connectionString;
        public Context(string connectionString) { this._connectionString = connectionString; }
        public Context() { }

        public void retrive()
        {
            var connString = "Server=ec2-107-21-120-104.compute-1.amazonaws.com;Port=5432;Database=d1qpflu2ge096f;User Id=hlijyndmgrwthy; Password=6b908ab41772f28cd4b524e49393930babfa93cd7965572dec93d8accb87e835;SSL Mode=Require;Trust Server Certificate=true;";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT * FROM user", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                        Console.WriteLine(reader.GetString(0));
            }
        }
    }
}