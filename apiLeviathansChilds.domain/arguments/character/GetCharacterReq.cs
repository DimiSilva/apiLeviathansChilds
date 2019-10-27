using System;
using apiLeviathansChilds.domain.interfaces.arguments;

namespace apiLeviathansChilds.domain.arguments.character
{
    public class GetCharacterReq : IRequest
    {
        public string id { get; private set; }

        public GetCharacterReq(Guid id)
        {
            this.id = id.ToString();
        }
    }
}