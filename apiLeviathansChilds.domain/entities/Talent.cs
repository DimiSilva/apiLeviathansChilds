using System;

namespace apiLeviathansChilds.domain.entities
{
    public class Talent
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int baseHp { get; set; }
        public int baseStrength { get; set; }
        public int baseAgility { get; set; }
        public int baseXpToUp { get; set; }
        public float xpToUpMultiplier { get; set; }
        public float hpMultiplier { get; set; }
        public float strengthMultiplier { get; set; }
        public float agilityMultiplier { get; set; }
        public int levelToBlessing { get; set; }
    }
}