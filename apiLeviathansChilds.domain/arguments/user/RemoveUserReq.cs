using System;
using apiLeviathansChilds.domain.interfaces.arguments;

namespace apiLeviathansChilds.domain.arguments.user
{
    public class RemoveUserReq : IRequest
    {
        public Guid id { get; set; }
    }
}