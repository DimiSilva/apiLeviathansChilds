using apiLeviathansChilds.domain.interfaces.arguments;

namespace apiLeviathansChilds.domain.arguments.character
{
    public class UpdateCharacterRes : IResponse
    {
        public string message { get; private set; }
        public UpdateCharacterRes()
        {
            this.message = "Character updated";
        }
    }
}