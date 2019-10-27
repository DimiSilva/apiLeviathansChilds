using System;

namespace apiLeviathansChilds.domain.arguments.character
{
    public class GetAllFromUserReq
    {
        public Guid id { get; private set; }

        public GetAllFromUserReq(Guid id)
        {
            this.id = id;
        }

    }
}