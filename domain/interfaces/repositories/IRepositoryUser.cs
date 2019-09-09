using System;
using apiLeviathansChilds.domain.arguments.user;

namespace apiLeviathansChilds.domain.interfaces.repositories
{
    public interface IRepositoryUser
    {
        AuthenticationRes Authentication(AuthenticationReq request);

        Guid CreateUser(CreateUserReq request);
    }
}