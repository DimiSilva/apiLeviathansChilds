using System;
using apiLeviathansChilds.domain.interfaces.arguments;

namespace apiLeviathansChilds.domain.arguments.amulet
{
    public class GetAmuletReq : IRequest
    {
        public string id { get; private set; }

        public GetAmuletReq(Guid id)
        {
            this.id = id.ToString();
        }
    }
}