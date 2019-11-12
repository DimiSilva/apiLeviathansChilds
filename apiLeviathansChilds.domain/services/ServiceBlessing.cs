using System;
using System.Collections.Generic;
using System.Linq;
using apiLeviathansChilds.domain.arguments.blessing;
using apiLeviathansChilds.domain.interfaces.repositories;
using apiLeviathansChilds.domain.interfaces.services;
using apiLeviathansChilds.domain.resources;
using prmToolkit.NotificationPattern;

namespace apiLeviathansChilds.domain.services
{
    public class ServiceBlessing : Notifiable, IServiceBlessing
    {
        private readonly IRepositoryBlessing _repositoryBlessing;
        public ServiceBlessing(IRepositoryBlessing repositoryBlessing)
        {
            _repositoryBlessing = repositoryBlessing;
        }

        public IEnumerable<BlessingRes> GetAll()
        {
            return _repositoryBlessing.GetAll().ToList().Select(blessing => (BlessingRes)blessing);
        }

        public BlessingRes GetById(GetBlessingReq request)
        {
            if (request == null)
                AddNotification("GetUserReq", Messages.X0_IS_OBRIGATORY("Request"));

            return (BlessingRes)_repositoryBlessing.GetById(Guid.Parse(request.id));
        }
    }
}