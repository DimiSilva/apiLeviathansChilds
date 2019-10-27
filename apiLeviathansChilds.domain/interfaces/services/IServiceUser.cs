using System.Collections.Generic;
using apiLeviathansChilds.domain.arguments.user;

namespace apiLeviathansChilds.domain.interfaces.services
{
    public interface IServiceUser
    {
        AuthenticationRes Authentication(AuthenticationReq request);
        IEnumerable<UserRes> GetAll();
        UserRes GetById(GetUserReq request);
        CreateUserRes Insert(CreateUserReq request);
        UpdateUserRes Update(UpdateUserReq request);
        RemoveUserRes Remove(RemoveUserReq request);
    }
}