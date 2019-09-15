using System;

namespace apiLeviathansChilds.domain.entities
{
    public class Element
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public float hpMultiplier { get; set; }
        public float strengthMultiplier { get; set; }
        public float agilityMultiplier { get; set; }
    }
}