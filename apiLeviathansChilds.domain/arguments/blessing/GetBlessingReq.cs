using System;
using apiLeviathansChilds.domain.interfaces.arguments;

namespace apiLeviathansChilds.domain.arguments.blessing
{
    public class GetBlessingReq : IRequest
    {
        public string id { get; private set; }

        public GetBlessingReq(Guid id)
        {
            this.id = id.ToString();
        }
    }
}