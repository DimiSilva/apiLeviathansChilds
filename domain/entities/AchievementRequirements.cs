using System;

namespace apiLeviathansChilds.domain.entities
{
    public class AchievementRequirements
    {
        public Guid id { get; set; }
        public Guid achievement { get; set; }
        public Guid requirement { get; set; }
    }
}