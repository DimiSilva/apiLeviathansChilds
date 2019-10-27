using System;
using apiLeviathansChilds.domain.interfaces.arguments;

namespace apiLeviathansChilds.domain.arguments.character
{
    public class CreateCharacterRes : IResponse
    {
        public string id { get; private set; }
        public string message { get; private set; }

        public CreateCharacterRes(string id)
        {
            this.id = id;
            this.message = "Character created";
        }

        public static explicit operator CreateCharacterRes(Guid characterId) { return new CreateCharacterRes(characterId.ToString()); }
    }
}