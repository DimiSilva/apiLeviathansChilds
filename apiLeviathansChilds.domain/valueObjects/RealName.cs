using apiLeviathansChilds.domain.resources;
using prmToolkit.NotificationPattern;

namespace apiLeviathansChilds.domain.valueObjects
{
    public class RealName : Notifiable
    {
        public string firstName { get; private set; }
        public string lastName { get; private set; }

        public RealName(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;

            new AddNotifications<RealName>(this)
                .IfNullOrInvalidLength(x => x.firstName, 3, 16, Messages.X0_NEED_TO_HAVE_BETWEEN_X1_TO_X2_CHARACTERS("First name", "3", "16"))
                .IfNullOrInvalidLength(x => x.lastName, 3, 16, Messages.X0_NEED_TO_HAVE_BETWEEN_X1_TO_X2_CHARACTERS("Last Name", "3", "16"));
        }

    }
}