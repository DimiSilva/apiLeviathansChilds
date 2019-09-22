using System.Collections;
using System.Collections.Generic;
using apiLeviathansChilds.domain.arguments;
using apiLeviathansChilds.domain.arguments.user;
using apiLeviathansChilds.domain.entities;

namespace apiLeviathansChilds.domain.interfaces.services
{
    public interface IServiceUser
    {
        AuthenticationRes Authentication(AuthenticationReq request);

        IEnumerable<UserRes> GetUsers();

        UserRes GetUser(GetUserReq request);

        CreateUserRes CreateUser(CreateUserReq request);

        UpdateUserRes UpdateUser(UpdateUserReq request);

        BaseRes RemoveUser(RemoveUserReq request);
    }
}