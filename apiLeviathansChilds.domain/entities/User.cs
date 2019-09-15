using System;
using apiLeviathansChilds.domain.resources;
using apiLeviathansChilds.domain.valueObjects;
using prmToolkit.NotificationPattern;

namespace apiLeviathansChilds.domain.entities
{
    public class User : Notifiable
    {
        public Guid id { get; set; }
        public RealName name { get; set; }
        public string nick { get; set; }
        public Email email { get; set; }
        public string password { get; set; }

        public User(string nick, Email email, string password)
        {
            this.nick = nick;
            this.email = email;
            this.password = password;

            new AddNotifications<User>(this)
                .IfNullOrEmpty(x => x.nick, Messages.INFORM_A_VALID_X0("nick"))
                .IfNullOrInvalidLength(x => x.password, 8, 20, Messages.INFORM_A_PASSWORD_WITH_X0_TO_X1_CHARACTERS("8", "20"));
        }
    }
}