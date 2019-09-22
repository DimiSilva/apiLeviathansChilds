using System;
using apiLeviathansChilds.domain.entities;
using apiLeviathansChilds.domain.interfaces.arguments;

namespace apiLeviathansChilds.domain.arguments.user
{
    public class AuthenticationRes : IResponse
    {
        Guid id;
        string emailAdress;
        string firstName;
        string status;

        public AuthenticationRes(Guid id, string emailAdress, string firstName, string status)
        {
            this.id = id;
            this.emailAdress = emailAdress;
            this.firstName = firstName;
            this.status = status;
        }

        public static explicit operator AuthenticationRes(User user) => new AuthenticationRes(user.id, user.email.adress, user.name.firstName, user.status.ToString());
    }
}