using System;
using apiLeviathansChilds.domain.entities;
using apiLeviathansChilds.domain.interfaces.arguments;
using apiLeviathansChilds.domain.resources;

namespace apiLeviathansChilds.domain.arguments.user
{
    public class CreateUserRes : IResponse
    {
        public Guid id { get; set; }
        public string message { get; set; }

        public CreateUserRes(Guid id, string message)
        {
            this.id = id;
            this.message = message;
        }

        public static explicit operator CreateUserRes(Guid id) => new CreateUserRes(id, Messages.X0_SUCCESSFULLY_CREATED("User"));
    }
}