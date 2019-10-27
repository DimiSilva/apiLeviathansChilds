using System;
using apiLeviathansChilds.domain.interfaces.arguments;

namespace apiLeviathansChilds.domain.arguments.element
{
    public class GetElementReq : IRequest
    {
        public string id { get; private set; }

        public GetElementReq(Guid id)
        {
            this.id = id.ToString();
        }
    }
}