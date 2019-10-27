using System;
using System.Collections.Generic;
using apiLeviathansChilds.domain.arguments.character;
using apiLeviathansChilds.domain.arguments.user;

namespace apiLeviathansChilds.domain.interfaces.services
{
    public interface IServiceCharacter
    {
        IEnumerable<CharacterRes> GetAll();
        IEnumerable<CharacterRes> GetAllFromUser(GetAllFromUserReq request);
        CharacterRes GetById(GetCharacterReq request);
        CreateCharacterRes Insert(CreateCharacterReq request);
        UpdateCharacterRes Update(UpdateCharacterReq request);
        RemoveCharacterRes Remove(RemoveCharacterReq request);
    }
}