using System;
using apiLeviathansChilds.domain.entities;
using apiLeviathansChilds.domain.interfaces.arguments;

namespace apiLeviathansChilds.domain.arguments.element
{
    public class ElementRes : IResponse
    {
        public string id { get; private set; }
        public string name { get; private set; }
        public string description { get; private set; }
        public float hpMultiplier { get; private set; }
        public float strengthMultiplier { get; private set; }
        public float agilityMultiplier { get; private set; }
        public float intelligenceMultiplier { get; private set; }

        public ElementRes(Guid id, string name, string description, float hpMultiplier, float strengthMultiplier, float agilityMultiplier, float intelligenceMultiplier)
        {
            this.id = id.ToString();
            this.name = name;
            this.description = description;
            this.hpMultiplier = hpMultiplier;
            this.strengthMultiplier = strengthMultiplier;
            this.agilityMultiplier = agilityMultiplier;
            this.intelligenceMultiplier = intelligenceMultiplier;
        }

        public static explicit operator ElementRes(Element element) { return new ElementRes(element.id, element.name, element.description, element.hpMultiplier, element.strengthMultiplier, element.agilityMultiplier, element.intelligenceMultiplier); }
    }
}