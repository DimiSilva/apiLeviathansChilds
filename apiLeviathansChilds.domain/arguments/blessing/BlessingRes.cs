using System;
using apiLeviathansChilds.domain.entities;
using apiLeviathansChilds.domain.interfaces.arguments;

namespace apiLeviathansChilds.domain.arguments.blessing
{
    public class BlessingRes : IResponse
    {
        public string id { get; private set; }
        public string name { get; private set; }
        public string description { get; private set; }

        public BlessingRes(string id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }

        public static explicit operator BlessingRes(Blessing amulet) { return new BlessingRes(amulet.id.ToString(), amulet.name, amulet.description); }
    }
}