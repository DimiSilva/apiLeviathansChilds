using System;
using apiLeviathansChilds.domain.arguments.user;
using apiLeviathansChilds.domain.entities;

namespace apiLeviathansChilds.domain.interfaces.repositories
{
    public interface IRepositoryUser
    {
        AuthenticationRes Authentication(string nick, string emailAdress, string password);

        Guid CreateUser(User user);
    }
}