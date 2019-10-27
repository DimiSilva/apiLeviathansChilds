using apiLeviathansChilds.domain.interfaces.arguments;

namespace apiLeviathansChilds.domain.arguments.character
{
    public class RemoveCharacterRes : IResponse
    {
        public string message { get; private set; }
        public RemoveCharacterRes()
        {
            this.message = "Character removed";
        }
    }
}