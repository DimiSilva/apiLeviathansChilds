using System;

namespace apiLeviathansChilds.domain.entities
{
    public class Blessing
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int hpPlus { get; set; }
        public int strengthPlus { get; set; }
        public int agilityPlus { get; set; }
    }
}