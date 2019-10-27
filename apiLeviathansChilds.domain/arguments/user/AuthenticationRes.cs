using System;
using apiLeviathansChilds.domain.entities;
using apiLeviathansChilds.domain.interfaces.arguments;

namespace apiLeviathansChilds.domain.arguments.user
{
    public class AuthenticationRes : IResponse
    {
        public string id { get; private set; }
        public string emailAdress { get; private set; }
        public string firstName { get; private set; }

        public AuthenticationRes(string id, string emailAdress, string firstName)
        {
            this.id = id;
            this.emailAdress = emailAdress;
            this.firstName = firstName;
        }

        public static explicit operator AuthenticationRes(User user) => new AuthenticationRes(user.id.ToString(), user.email.adress, user.name.firstName);
    }
}