using System;

namespace apiLeviathansChilds.domain.entities
{
    public class Achievement : EntityBase
    {
        public string name { get; private set; }
        public string description { get; private set; }

        public Achievement(Guid id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }
    }
}