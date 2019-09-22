using apiLeviathansChilds.domain.interfaces.arguments;

namespace apiLeviathansChilds.domain.arguments.user
{
    public class CreateUserReq : IRequest
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string nick { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}