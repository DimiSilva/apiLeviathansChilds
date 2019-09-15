using apiLeviathansChilds.domain.arguments.user;

namespace apiLeviathansChilds.domain.interfaces.services
{
    public interface IServiceUser
    {
        AuthenticationRes Authentication(AuthenticationReq request);

        CreateUserRes CreateUser(CreateUserReq request);
    }
}