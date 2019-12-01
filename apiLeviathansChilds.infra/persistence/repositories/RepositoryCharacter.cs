using System;
using System.Collections.Generic;
using apiLeviathansChilds.domain.arguments;
using apiLeviathansChilds.domain.entities;
using apiLeviathansChilds.domain.interfaces.repositories;
using System.Globalization;
using Npgsql;

namespace apiLeviathansChilds.infra.persistence.repositories
{
    public class RepositoryCharacter : IRepositoryCharacter
    {
        private readonly string _connectionString;

        public RepositoryCharacter(string connectionString) { this._connectionString = connectionString; }

        public List<Character> GetAll()
        {
            List<Character> characters = new List<Character>();
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(
                  $"SELECT * FROM \"characters\" "
                + $"INNER JOIN \"jobs\" ON jobs.id=characters.jobid "
                + $"INNER JOIN \"users\" ON users.id=characters.userid "
                + $"INNER JOIN \"elements\" ON elements.id=characters.elementid "
                + $"INNER JOIN \"amulets\" ON amulets.id=characters.amuletid "
                , conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        Job job = new Job(reader.GetGuid(19), reader.GetString(20), reader.GetString(21), reader.GetInt32(22), reader.GetInt32(23), reader.GetInt32(24), reader.GetInt32(25), reader.GetInt32(26), reader.GetFloat(27), reader.GetFloat(28), reader.GetFloat(29), reader.GetFloat(30), reader.GetFloat(31), reader.GetInt32(32));
                        User user = new User(reader.GetGuid(33), reader.GetString(34), reader.GetString(35), reader.GetString(36), reader.GetString(37), reader.GetString(38));
                        Element element = new Element(reader.GetGuid(39), reader.GetString(40), reader.GetString(41), reader.GetFloat(42), reader.GetFloat(43), reader.GetFloat(44), reader.GetFloat(45));
                        Amulet amulet = new Amulet(reader.GetGuid(46), reader.GetString(47), reader.GetString(48), reader.GetFloat(49), reader.GetFloat(50), reader.GetFloat(51), reader.GetFloat(52), reader.GetInt32(53), reader.GetFloat(54));
                        characters.Add(new Character(reader.GetGuid(0), reader.GetString(1), job, user, element, amulet, reader.GetInt32(6), reader.GetInt32(7), reader.GetFloat(8), reader.GetFloat(9), reader.GetFloat(10), reader.GetFloat(11), reader.GetInt32(12), reader.GetInt32(13), reader.GetInt32(14), reader.GetInt32(15), reader.GetInt32(16), reader.GetInt32(17), reader.GetInt32(18)));
                    }
            }
            return characters;
        }

        public List<Character> GetAllFromUser(Guid id)
        {
            List<Character> characters = new List<Character>();
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(
                  $"SELECT * FROM \"characters\" "
                + $"INNER JOIN \"jobs\" ON jobs.id=characters.jobid "
                + $"INNER JOIN \"users\" ON users.id=characters.userid "
                + $"INNER JOIN \"elements\" ON elements.id=characters.elementid "
                + $"INNER JOIN \"amulets\" ON amulets.id=characters.amuletid "
                + $"WHERE characters.userid='{id.ToString()}'"
                , conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        Job job = new Job(reader.GetGuid(19), reader.GetString(20), reader.GetString(21), reader.GetInt32(22), reader.GetInt32(23), reader.GetInt32(24), reader.GetInt32(25), reader.GetInt32(26), reader.GetFloat(27), reader.GetFloat(28), reader.GetFloat(29), reader.GetFloat(30), reader.GetFloat(31), reader.GetInt32(32));
                        User user = new User(reader.GetGuid(33), reader.GetString(34), reader.GetString(35), reader.GetString(36), reader.GetString(37), reader.GetString(38));
                        Element element = new Element(reader.GetGuid(39), reader.GetString(40), reader.GetString(41), reader.GetFloat(42), reader.GetFloat(43), reader.GetFloat(44), reader.GetFloat(45));
                        Amulet amulet = new Amulet(reader.GetGuid(46), reader.GetString(47), reader.GetString(48), reader.GetFloat(49), reader.GetFloat(50), reader.GetFloat(51), reader.GetFloat(52), reader.GetInt32(53), reader.GetFloat(54));
                        characters.Add(new Character(reader.GetGuid(0), reader.GetString(1), job, user, element, amulet, reader.GetInt32(6), reader.GetInt32(7), reader.GetFloat(8), reader.GetFloat(9), reader.GetFloat(10), reader.GetFloat(11), reader.GetInt32(12), reader.GetInt32(13), reader.GetInt32(14), reader.GetInt32(15), reader.GetInt32(16), reader.GetInt32(17), reader.GetInt32(18)));
                    }
            }
            return characters;
        }

        public Character GetById(Guid id)
        {
            Character character = null;
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(
                  $"SELECT * FROM \"characters\" "
                + $"INNER JOIN \"jobs\" ON jobs.id=characters.jobid "
                + $"INNER JOIN \"users\" ON users.id=characters.userid "
                + $"INNER JOIN \"elements\" ON elements.id=characters.elementid "
                + $"INNER JOIN \"amulets\" ON amulets.id=characters.amuletid "
                + $"WHERE characters.id='{id.ToString()}'"
                , conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        Job job = new Job(reader.GetGuid(19), reader.GetString(20), reader.GetString(21), reader.GetInt32(22), reader.GetInt32(23), reader.GetInt32(24), reader.GetInt32(25), reader.GetInt32(26), reader.GetFloat(27), reader.GetFloat(28), reader.GetFloat(29), reader.GetFloat(30), reader.GetFloat(31), reader.GetInt32(32));
                        User user = new User(reader.GetGuid(33), reader.GetString(34), reader.GetString(35), reader.GetString(36), reader.GetString(37), reader.GetString(38));
                        Element element = new Element(reader.GetGuid(39), reader.GetString(40), reader.GetString(41), reader.GetFloat(42), reader.GetFloat(43), reader.GetFloat(44), reader.GetFloat(45));
                        Amulet amulet = new Amulet(reader.GetGuid(46), reader.GetString(47), reader.GetString(48), reader.GetFloat(49), reader.GetFloat(50), reader.GetFloat(51), reader.GetFloat(52), reader.GetInt32(53), reader.GetFloat(54));
                        character = new Character(reader.GetGuid(0), reader.GetString(1), job, user, element, amulet, reader.GetInt32(6), reader.GetInt32(7), reader.GetFloat(8), reader.GetFloat(9), reader.GetFloat(10), reader.GetFloat(11), reader.GetInt32(12), reader.GetInt32(13), reader.GetInt32(14), reader.GetInt32(15), reader.GetInt32(16), reader.GetInt32(17), reader.GetInt32(18));
                    }
            }
            return character;
        }

        public Guid Insert(Character character)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand($"INSERT INTO \"characters\" VALUES('{character.id.ToString()}', '{character.name}', '{character.job.id.ToString()}', '{character.user.id.ToString()}', '{character.element.id.ToString()}', '{character.amulet.id.ToString()}', '{character.amuletLevel}', '{character.amuletExperience}', '{character.hp}', '{character.strength}', '{character.agility}', '{character.intelligence}', '{character.battlesNumber}', '{character.victorysNumber}', '{character.losesNumber}', '{character.battleTimeInSeconds}', '{character.xp}', '{character.xpToUp}', '{character.level}')", conn))
                    cmd.ExecuteNonQuery();
            }
            return character.id;
        }

        public BaseRes Remove(Guid id)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand($"DELETE FROM \"characters\" WHERE id='{id.ToString()}'", conn))
                    cmd.ExecuteNonQuery();
            }
            return new BaseRes("Character removed");
        }

        public BaseRes Update(Character character)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand($"UPDATE \"characters\" SET amuletExperience='{character.amuletExperience}', amuletLevel='{character.amuletLevel}', hp='{character.hp}', strenght='{character.strength}', agility='{character.agility}', intelligence='{character.intelligence}', xp='{character.xp}', level='{character.level}', xpToUp='{character.xpToUp}', victorysNumber='{character.victorysNumber}', losesNumber='{character.losesNumber}', battlesNumber='{character.battlesNumber}', battleTimeInSeconds='{character.battleTimeInSeconds}' WHERE id='{character.id.ToString()}'", conn))
                    cmd.ExecuteNonQuery();
            }
            return new BaseRes("Character updated");
        }
    }
}