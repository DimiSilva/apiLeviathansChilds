using apiLeviathansChilds.domain.interfaces.arguments;

namespace apiLeviathansChilds.domain.arguments.user
{
    public class AuthenticationReq : IRequest
    {
        public string nick { get; set; }
        public string password { get; set; }
    }
}