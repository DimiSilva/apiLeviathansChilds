using System;
using apiLeviathansChilds.domain.interfaces.arguments;

namespace apiLeviathansChilds.domain.arguments.character
{
    public class RemoveCharacterReq : IRequest
    {
        public string id { get; private set; }
        public RemoveCharacterReq(Guid id)
        {
            this.id = id.ToString();
        }
    }
}