using System;

namespace apiLeviathansChilds.domain.entities
{
    public class Element : EntityBase
    {
        public string name { get; private set; }
        public string description { get; private set; }
        public float hpMultiplier { get; private set; }
        public float strengthMultiplier { get; private set; }
        public float agilityMultiplier { get; private set; }
        public float intelligenceMultiplier { get; private set; }

        public Element(Guid id, string name, string description, float hpMultiplier, float strengthMultiplier, float agilityMultiplier, float intelligenceMultiplier)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.hpMultiplier = hpMultiplier;
            this.strengthMultiplier = strengthMultiplier;
            this.agilityMultiplier = agilityMultiplier;
            this.intelligenceMultiplier = intelligenceMultiplier;
        }
    }
}