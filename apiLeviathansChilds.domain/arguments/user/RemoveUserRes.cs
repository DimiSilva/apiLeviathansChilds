using apiLeviathansChilds.domain.interfaces.arguments;
using apiLeviathansChilds.domain.resources;

namespace apiLeviathansChilds.domain.arguments.user
{
    public class RemoveUserRes : IResponse
    {
        public string message { get; private set; }

        public RemoveUserRes()
        {
            this.message = Messages.X0_SUCCESSFULLY_REMOVED("User");
        }
    }
}