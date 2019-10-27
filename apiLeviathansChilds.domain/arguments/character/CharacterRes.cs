using System;
using apiLeviathansChilds.domain.entities;
using apiLeviathansChilds.domain.interfaces.arguments;

namespace apiLeviathansChilds.domain.arguments.character
{
    public class CharacterRes : IResponse
    {
        public string id { get; private set; }
        public string name { get; private set; }
        public string job { get; private set; }
        public string user { get; private set; }
        public string element { get; private set; }
        public string amulet { get; private set; }
        public int amuletLevel { get; private set; }
        public int amuletExperience { get; private set; }
        public float hp { get; private set; }
        public float strength { get; private set; }
        public float agility { get; private set; }
        public float intelligence { get; private set; }
        public int battlesNumber { get; private set; }
        public int victorysNumber { get; private set; }
        public int losesNumber { get; private set; }
        public int battleTimeInSeconds { get; private set; }
        public int xp { get; private set; }
        public int xpToUp { get; private set; }
        public int level { get; private set; }

        public CharacterRes(string id, string name, string job, string user, string element, string amulet, int amuletLevel, int amuletExperience, float hp, float strength, float agility, float intelligence, int battlesNumber, int victorysNumber, int losesNumber, int battleTimeInSeconds, int xp, int xpToUp, int level)
        {
            this.id = id;
            this.name = name;
            this.job = job;
            this.user = user;
            this.element = element;
            this.amulet = amulet;
            this.amuletLevel = amuletLevel;
            this.amuletExperience = amuletExperience;
            this.hp = hp;
            this.strength = strength;
            this.agility = agility;
            this.intelligence = intelligence;
            this.battlesNumber = battlesNumber;
            this.victorysNumber = victorysNumber;
            this.losesNumber = losesNumber;
            this.battleTimeInSeconds = battleTimeInSeconds;
            this.xp = xp;
            this.xpToUp = xpToUp;
            this.level = level;
        }

        public static explicit operator CharacterRes(Character character)
        {
            return new CharacterRes(
character.id.ToString()
, character.name
, character.job.id.ToString()
, character.user.id.ToString()
, character.element.id.ToString()
, character.amulet.id.ToString()
, character.amuletLevel
, character.amuletExperience
, character.hp
, character.strength
, character.agility
, character.intelligence
, character.battlesNumber
, character.victorysNumber
, character.losesNumber
, character.battleTimeInSeconds
, character.xp
, character.xpToUp
, character.level
);
        }
    }
}