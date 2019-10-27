using System;

namespace apiLeviathansChilds.domain.entities
{
    public class Amulet : EntityBase
    {
        public string name { get; private set; }
        public string description { get; private set; }
        public float hpMultiplier { get; private set; }
        public float strengthMultiplier { get; private set; }
        public float agilityMultiplier { get; private set; }
        public float intelligenceMultiplier { get; private set; }
        public int baseXpToUp { get; private set; }
        public float xpToUpMultiplier { get; private set; }

        public Amulet(Guid id, string name, string description, float hpMultiplier, float strengthMultiplier, float agilityMultiplier, float intelligenceMultiplier, int baseXpToUp, float xpToUpMultiplier)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.hpMultiplier = hpMultiplier;
            this.strengthMultiplier = strengthMultiplier;
            this.agilityMultiplier = agilityMultiplier;
            this.intelligenceMultiplier = intelligenceMultiplier;
            this.baseXpToUp = baseXpToUp;
            this.xpToUpMultiplier = xpToUpMultiplier;
        }
    }
}