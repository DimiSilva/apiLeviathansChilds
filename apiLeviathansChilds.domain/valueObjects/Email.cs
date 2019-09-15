using apiLeviathansChilds.domain.resources;
using prmToolkit.NotificationPattern;

namespace apiLeviathansChilds.domain.valueObjects
{
    public class Email : Notifiable
    {
        public string adress { get; private set; }

        public Email(string adress)
        {
            this.adress = adress;

            new AddNotifications<Email>(this)
            .IfNotEmail(x => x.adress, Messages.INFORM_A_VALID_X0("e-mail"));
        }
    }
}