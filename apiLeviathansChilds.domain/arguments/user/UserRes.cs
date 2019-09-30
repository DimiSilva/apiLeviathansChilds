using System;
using apiLeviathansChilds.domain.entities;
using apiLeviathansChilds.domain.interfaces.arguments;

namespace apiLeviathansChilds.domain.arguments.user
{
    public class UserRes : IResponse
    {
        public Guid id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string nick { get; set; }
        public string emailAdress { get; set; }

        public UserRes(Guid id, string firstName, string lastName, string nick, string emailAdress)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.nick = nick;
            this.emailAdress = emailAdress;
        }

        public static explicit operator UserRes(User user) => new UserRes(user.id, user.name.firstName, user.name.lastName, user.nick, user.email.adress);
    }
}