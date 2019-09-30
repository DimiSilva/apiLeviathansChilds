using System;
using apiLeviathansChilds.domain.entities;
using apiLeviathansChilds.domain.interfaces.arguments;
using apiLeviathansChilds.domain.resources;

namespace apiLeviathansChilds.domain.arguments.user
{
    public class UpdateUserRes : IResponse
    {
        public string message { get; private set; }

        public UpdateUserRes()
        {
            message = Messages.X0_SUCCESSFULLY_UPDATED("User");
        }
    }
}