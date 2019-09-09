using System;
using apiLeviathansChilds.domain.arguments.user;
using apiLeviathansChilds.domain.interfaces.repositories;
using apiLeviathansChilds.domain.interfaces.services;

namespace apiLeviathansChilds.domain.services
{
    public class ServiceUser : IServiceUser
    {
        private readonly IRepositoryUser _repositoryUser;

        ServiceUser(IRepositoryUser repositoryUser)
        {
            _repositoryUser = repositoryUser;
        }

        public AuthenticationRes Authentication(AuthenticationReq request)
        {
            throw new NotImplementedException();
        }

        public CreateUserRes CreateUser(CreateUserReq request)
        {
            Guid id = _repositoryUser.CreateUser(request);
            return new CreateUserRes()
            {
                id = id,
                message = "User created"
            };
        }
    }
}