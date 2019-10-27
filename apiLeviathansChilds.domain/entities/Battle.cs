using System;

namespace apiLeviathansChilds.domain.entities
{
    public class Battle : EntityBase
    {
        public DateTime date { get; private set; }
        public Guid character1 { get; private set; }
        public Guid character2 { get; private set; }
        public int durationInSeconds { get; private set; }
        public string victorious { get; private set; }
    }
}