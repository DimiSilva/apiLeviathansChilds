using System;
using System.Collections.Generic;
using apiLeviathansChilds.domain.arguments;
using apiLeviathansChilds.domain.entities;

namespace apiLeviathansChilds.domain.interfaces.repositories
{
    public interface IRepositoryCharacter
    {
        Guid Insert(Character user);
        List<Character> GetAll();
        List<Character> GetAllFromUser(Guid id);
        Character GetById(Guid id);
        BaseRes Update(Character character);
        BaseRes Remove(Guid id);
    }
}