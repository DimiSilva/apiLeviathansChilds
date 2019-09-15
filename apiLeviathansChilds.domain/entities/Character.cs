using System;

namespace apiLeviathansChilds.domain.entities
{
    public class Character
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public Guid talent { get; set; }
        public Guid user { get; set; }
        public Guid element { get; set; }
        public Guid amulet { get; set; }
        public int amuletLevel { get; set; }
        public int amuletExperience { get; set; }
        public float hp { get; set; }
        public float strength { get; set; }
        public float agility { get; set; }
        public int kills { get; set; }
        public int battlesNumber { get; set; }
        public int victorysNumber { get; set; }
        public int losesNumber { get; set; }
        public int battleTimeInSeconds { get; set; }
        public int xp { get; set; }
        public int xpToUp { get; set; }
        public int level { get; set; }
    }
}