using System;
using apiLeviathansChilds.domain.arguments.character;

namespace apiLeviathansChilds.domain.entities
{
    public class Character : EntityBase
    {
        public string name { get; private set; }
        public Job job { get; private set; }
        public User user { get; private set; }
        public Element element { get; private set; }
        public Amulet amulet { get; private set; }
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

        public Character(Guid id, string name, Job job, User user, Element element, Amulet amulet, int amuletLevel, int amuletExperience, float hp, float strength, float agility, float intelligence, int battlesNumber, int victorysNumber, int losesNumber, int battleTimeInSeconds, int xp, int xpToUp, int level)
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

        public Character(string name, Job job, User user, Element element, Amulet amulet)
        {
            this.name = name;
            this.job = job;
            this.user = user;
            this.element = element;
            this.amulet = amulet;
            this.amuletLevel = 1;
            this.amuletExperience = 0;
            this.hp = job.baseHp * element.hpMultiplier * amulet.hpMultiplier;
            this.strength = job.baseStrength * element.strengthMultiplier * amulet.strengthMultiplier;
            this.agility = job.baseAgility * element.agilityMultiplier * amulet.agilityMultiplier;
            this.intelligence = job.baseIntelligence * element.intelligenceMultiplier * amulet.intelligenceMultiplier;
            this.battlesNumber = 0;
            this.victorysNumber = 0;
            this.losesNumber = 0;
            this.battleTimeInSeconds = 0;
            this.xp = 0;
            this.xpToUp = job.baseXpToUp;
            this.level = 1;
        }

        public void Update(UpdateCharacterReq updateRequest){
            if(updateRequest.amuletExperience > amulet.baseXpToUp){
                this.amuletExperience = updateRequest.amuletExperience % amulet.baseXpToUp;
                for(int i = 0; i < Math.Abs((updateRequest.amuletExperience / amulet.baseXpToUp)); i++)
                {
                    this.amuletLevel += 1;
                    this.hp *= amulet.hpMultiplier;
                    this.strength *= amulet.strengthMultiplier;
                    this.agility *= amulet.agilityMultiplier;
                    this.intelligence *= amulet.intelligenceMultiplier;
                }
            }
            else
                this.amuletExperience = updateRequest.amuletExperience;
            
            if(updateRequest.xp > xpToUp){
                this.xp = updateRequest.xp % xpToUp;
                for(int i = 0; i < Math.Abs(updateRequest.xp / xpToUp); i++)
                {
                    this.level += 1;
                    this.xpToUp += 10;
                    this.hp *= (job.hpMultiplier * element.hpMultiplier);
                    this.strength *= (job.strengthMultiplier * element.strengthMultiplier);
                    this.agility *= (job.agilityMultiplier * element.agilityMultiplier);
                    this.intelligence *= (job.intelligenceMultiplier * element.intelligenceMultiplier);
                }
            }
            else
                this.xp = updateRequest.xp;
            
            this.victorysNumber = updateRequest.victorysNumber;
            this.losesNumber = updateRequest.losesNumber;
            this.battlesNumber = updateRequest.battlesNumber;
            this.battleTimeInSeconds = updateRequest.battleTimeInSeconds;
            
        }
    }
}