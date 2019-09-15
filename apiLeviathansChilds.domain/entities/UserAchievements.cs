using System;

namespace apiLeviathansChilds.domain.entities
{
    public class UserAchievements
    {
        public Guid id { get; set; }
        public Guid achievement { get; set; }
        public Guid user { get; set; }
    }
}