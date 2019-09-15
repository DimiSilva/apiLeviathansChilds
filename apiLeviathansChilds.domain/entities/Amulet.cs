using System;

namespace apiLeviathansChilds.domain.entities
{
    public class Amulet
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public float hpMultiplier { get; set; }
        public float strengthMultiplier { get; set; }
        public float agilityMultiplier { get; set; }
        public int baseXpToUp { get; set; }
        public float xpToUpMultiplier { get; set; }
    }
}