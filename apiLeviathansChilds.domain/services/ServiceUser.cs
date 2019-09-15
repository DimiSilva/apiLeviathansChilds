using System;
using apiLeviathansChilds.domain.arguments.user;
using apiLeviathansChilds.domain.entities;
using apiLeviathansChilds.domain.interfaces.repositories;
using apiLeviathansChilds.domain.interfaces.services;
using apiLeviathansChilds.domain.resources;
using apiLeviathansChilds.domain.valueObjects;
using prmToolkit.NotificationPattern;

namespace apiLeviathansChilds.domain.services
{
    public class ServiceUser : Notifiable, IServiceUser
    {
        private readonly IRepositoryUser _repositoryUser;

        // public ServiceUser(IRepositoryUser repositoryUser)
        // {
        //     _repositoryUser = repositoryUser;
        // }

        public AuthenticationRes Authentication(AuthenticationReq request)
        {
            if (request == null)
                throw new Exception(Messages.X0_IS_OBRIGATORY("Request"));

            var email = new Email(request.emailAdress);
            var user = new User(request.nick, email, request.password);

            AddNotifications(user, email);

            if (user.IsInvalid())
            {
                return null;
            }
            return new AuthenticationRes();
            // var response = _repositoryUser.Authentication(user.nick, user.email.adress, user.password);
            // return response;

        }

        public CreateUserRes CreateUser(CreateUserReq request)
        {
            //testes apagar
            User user = new User("teste", new Email(request.email), request.password);

            Guid id = _repositoryUser.CreateUser(user);
            return new CreateUserRes()
            {
                id = id,
                message = "User created"
            };
        }
    }
}