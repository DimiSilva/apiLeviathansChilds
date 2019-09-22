using System;
using apiLeviathansChilds.domain.extensions;
using apiLeviathansChilds.domain.resources;
using apiLeviathansChilds.domain.valueObjects;
using apiLeviathansChilds.domain.enums;
using prmToolkit.NotificationPattern;
using apiLeviathansChilds.domain.arguments.user;

namespace apiLeviathansChilds.domain.entities
{
    public class User : EntityBase
    {
        public RealName name { get; private set; }
        public string nick { get; private set; }
        public Email email { get; private set; }
        public string password { get; private set; }
        public EnumUserSituation status { get; private set; }

        public User(RealName name, string nick, Email email, string password)
        {
            this.name = name;
            this.nick = nick;
            this.email = email;
            this.password = password;
            this.status = EnumUserSituation.pending;

            new AddNotifications<User>(this)
                .IfNullOrEmpty(x => x.nick, Messages.INFORM_A_VALID_X0("nick"))
                .IfNullOrInvalidLength(x => x.password, 8, 20, Messages.INFORM_A_PASSWORD_WITH_X0_TO_X1_CHARACTERS("8", "20"));

            if (IsValid())
                this.password = password.ConvertToMD5();

            AddNotifications(email, name);
        }

        public User(string nick, string password)
        {
            this.nick = nick;
            this.password = password;
            this.status = EnumUserSituation.pending;

            new AddNotifications<User>(this)
                .IfNullOrEmpty(x => x.nick, Messages.INFORM_A_VALID_X0("nick"))
                .IfNullOrInvalidLength(x => x.password, 8, 20, Messages.INFORM_A_PASSWORD_WITH_X0_TO_X1_CHARACTERS("8", "20"));

            if (IsValid())
                this.password = password.ConvertToMD5();
        }

        public void Authenticate(AuthenticationReq data)
        {
            if (!(password == data.password.ConvertToMD5()))
                AddNotification("InvalidPassword", Messages.X0_INVALID("Password"));

            return;
        }

        public void Update(UpdateUserReq data)
        {
            RealName newName = null;
            if (data.firstName != null && data.lastName != null)
                newName = new RealName(data.firstName, data.lastName);

            else if (data.firstName != null)
                newName = new RealName(data.firstName, this.name.lastName);

            else if (data.lastName != null)
                newName = new RealName(this.name.firstName, data.lastName);

            else
            {
                AddNotification("update", Messages.X0_FAILED("User update"));
                return;
            }

            if (newName.IsInvalid())
            {
                AddNotifications(newName);
                return;
            }
            this.name = newName;
        }
    }
}