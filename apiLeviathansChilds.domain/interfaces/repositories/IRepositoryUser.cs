using System;
using System.Collections.Generic;
using apiLeviathansChilds.domain.arguments;
using apiLeviathansChilds.domain.entities;

namespace apiLeviathansChilds.domain.interfaces.repositories
{
    public interface IRepositoryUser
    {
        Guid Insert(User user);
        List<User> GetAll();
        User GetById(Guid id);
        User GetByNick(string nick);
        BaseRes Update(User user);
        BaseRes Remove(Guid id);
    }
}