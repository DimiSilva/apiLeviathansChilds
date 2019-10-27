using System;

namespace apiLeviathansChilds.domain.entities
{
    public class Requirement : EntityBase
    {
        public string requirement { get; private set; }
        public int value { get; private set; }
    }
}