using System;
using apiLeviathansChilds.domain.interfaces.arguments;

namespace apiLeviathansChilds.domain.arguments.user
{
    public class RemoveUserReq : IRequest
    {
        public Guid id { get; private set; }

        public RemoveUserReq(Guid id)
        {
            this.id = id;
        }
    }
}