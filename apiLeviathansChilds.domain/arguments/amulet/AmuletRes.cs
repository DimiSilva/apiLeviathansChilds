using System;
using apiLeviathansChilds.domain.entities;
using apiLeviathansChilds.domain.interfaces.arguments;

namespace apiLeviathansChilds.domain.arguments.amulet
{
    public class AmuletRes : IResponse
    {
        public string id { get; private set; }
        public string name { get; private set; }
        public string description { get; private set; }
        public float hpMultiplier { get; private set; }
        public float strengthMultiplier { get; private set; }
        public float agilityMultiplier { get; private set; }
        public float intelligenceMultiplier { get; private set; }
        public int baseXpToUp { get; private set; }
        public float xpToUpMultiplier { get; private set; }

        public AmuletRes(string id, string name, string description, float hpMultiplier, float strengthMultiplier, float agilityMultiplier, float intelligenceMultiplier, int baseXpToUp, float xpToUpMultiplier)
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

        public static explicit operator AmuletRes(Amulet amulet) { return new AmuletRes(amulet.id.ToString(), amulet.name, amulet.description, amulet.hpMultiplier, amulet.strengthMultiplier, amulet.agilityMultiplier, amulet.intelligenceMultiplier, amulet.baseXpToUp, amulet.xpToUpMultiplier); }
    }
}