using System;
using prmToolkit.NotificationPattern;

namespace apiLeviathansChilds.domain.entities
{
    public abstract class EntityBase : Notifiable
    {
        public Guid id { get; private set; }
        protected EntityBase()
        {
            id = Guid.NewGuid();
        }
    }
}