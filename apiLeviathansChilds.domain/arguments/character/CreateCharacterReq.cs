using apiLeviathansChilds.domain.interfaces.arguments;

namespace apiLeviathansChilds.domain.arguments.character
{
    public class CreateCharacterReq : IRequest
    {
        public string name { get; private set; }
        public string job { get; private set; }
        public string user { get; private set; }
        public string element { get; private set; }
        public string amulet { get; private set; }

        public CreateCharacterReq(string name, string job, string user, string element, string amulet)
        {
            this.name = name;
            this.job = job;
            this.user = user;
            this.element = element;
            this.amulet = amulet;
        }
    }
}