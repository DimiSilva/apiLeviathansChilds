using System;

namespace apiLeviathansChilds.domain.entities
{
    public class Requirement
    {
        public Guid id { get; set; }
        public string requirement { get; set; }
        public int value { get; set; }
    }
}