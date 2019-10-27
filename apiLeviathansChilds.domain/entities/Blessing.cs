using System;

namespace apiLeviathansChilds.domain.entities
{
    public class Blessing : EntityBase
    {
        public string name { get; private set; }
        public string description { get; private set; }
        public int hpPlus { get; private set; }
        public int strengthPlus { get; private set; }
        public int agilityPlus { get; private set; }
        public int intelligencePlus { get; private set; }

        public Blessing(Guid id, string name, string description, int hpPlus, int strengthPlus, int agilityPlus, int intelligencePlus)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.hpPlus = hpPlus;
            this.strengthPlus = strengthPlus;
            this.agilityPlus = agilityPlus;
            this.intelligencePlus = intelligencePlus;
        }
    }
}