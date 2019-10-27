using System;
using apiLeviathansChilds.domain.interfaces.arguments;

namespace apiLeviathansChilds.domain.arguments.job
{
    public class GetJobReq : IRequest
    {
        public string id { get; private set; }

        public GetJobReq(Guid id)
        {
            this.id = id.ToString();
        }
    }
}