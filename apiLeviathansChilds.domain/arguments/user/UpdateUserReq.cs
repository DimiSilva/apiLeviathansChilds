using System;
using apiLeviathansChilds.domain.interfaces.arguments;

namespace apiLeviathansChilds.domain.arguments.user
{
    public class UpdateUserReq : IRequest
    {
        public Guid id { get; set; }

        public string firstName { get; private set; }

        public string lastName { get; private set; }
    }
}