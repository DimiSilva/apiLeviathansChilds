using System;
using apiLeviathansChilds.domain.interfaces.arguments;

namespace apiLeviathansChilds.domain.arguments.user
{
    public class CreateUserRes : IResponse
    {
        public Guid id { get; set; }
        public string message { get; set; }
    }
}