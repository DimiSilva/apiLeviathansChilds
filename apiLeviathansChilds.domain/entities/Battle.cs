using System;

namespace apiLeviathansChilds.domain.entities
{
    public class Battle
    {
        public Guid id { get; set; }
        public DateTime date { get; set; }
        public Guid character1 { get; set; }
        public Guid character2 { get; set; }
        public int durationInSeconds { get; set; }
        public string victorious { get; set; }
    }
}