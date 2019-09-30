using apiLeviathansChilds.domain.interfaces.arguments;

namespace apiLeviathansChilds.domain.arguments.user
{
    public class CreateUserReq : IRequest
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string nick { get; set; }
        public string emailAdress { get; set; }
        public string password { get; set; }

        public CreateUserReq(string firstName, string lastName, string nick, string emailAdress, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.nick = nick;
            this.emailAdress = emailAdress;
            this.password = password;
        }
    }
}