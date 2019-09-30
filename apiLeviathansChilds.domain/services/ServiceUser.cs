using System;
using System.Collections.Generic;
using System.Linq;
using apiLeviathansChilds.domain.arguments;
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
        public ServiceUser(IRepositoryUser repositoryUser)
        {
            _repositoryUser = repositoryUser;
        }

        public AuthenticationRes Authentication(AuthenticationReq request)
        {
            if (request == null)
            {
                AddNotification("AuthenticationReq", Messages.X0_IS_OBRIGATORY("Request"));
                return null;
            }
            User user = _repositoryUser.GetByNick(request.nick);
            if (user == null)
            {
                AddNotification("UserNotFound", Messages.X0_NOT_FOUND("User"));
                return null;
            }

            user.Authenticate(request);
            AddNotifications(user);

            if (this.IsInvalid())
            {
                return null;
            }

            return (AuthenticationRes)user;
        }

        public CreateUserRes Insert(CreateUserReq request)
        {
            if (request == null)
                AddNotification("CreateUserReq", Messages.X0_IS_OBRIGATORY("Request"));

            var name = new RealName(request.firstName, request.lastName);
            string nick = request.nick;
            var email = new Email(request.emailAdress);
            string password = request.password;
            var user = new User(name, nick, email, password);

            AddNotifications(user);

            if (this.IsInvalid())
                return null;

            Guid userId = _repositoryUser.Insert(user);
            return (CreateUserRes)userId;
        }

        public UserRes GetById(GetUserReq request)
        {
            if (request == null)
                AddNotification("GetUserReq", Messages.X0_IS_OBRIGATORY("Request"));

            return (UserRes)_repositoryUser.GetById(request.id);
        }

        public IEnumerable<UserRes> GetAll()
        {
            return _repositoryUser.GetAll().ToList().Select(user => (UserRes)user);
        }

        public RemoveUserRes Remove(RemoveUserReq request)
        {
            if (request == null)
            {
                AddNotification("RemoveUserReq", Messages.X0_IS_OBRIGATORY("Request"));
                return null;
            }
            User user = _repositoryUser.GetById(request.id);
            if (user == null)
            {
                AddNotification("UserNotFound", Messages.X0_NOT_FOUND("User"));
                return null;
            }

            _repositoryUser.Remove(user.id);
            return new RemoveUserRes();
        }

        public UpdateUserRes Update(UpdateUserReq request)
        {
            if (request == null)
            {
                AddNotification("UpdateUserReq", Messages.X0_IS_OBRIGATORY("Request"));
                return null;
            }

            User user = _repositoryUser.GetById(request.id);

            if (user == null)
            {
                AddNotification("user", Messages.X0_NOT_FOUND("User"));
                return null;
            }

            user.Update(request);
            AddNotifications(user);
            if (IsInvalid())
            {
                return null;
            }
            _repositoryUser.Update(user);
            return new UpdateUserRes();
        }
    }
}