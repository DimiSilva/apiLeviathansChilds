using System;
using apiLeviathansChilds.domain.entities;
using apiLeviathansChilds.domain.interfaces.arguments;

namespace apiLeviathansChilds.domain.arguments.user
{
    public class GetUserReq : IRequest
    {
        public GetUserReq(Guid id)
        {
            this.id = id;
        }

        public Guid id { get; set; }
    }
}