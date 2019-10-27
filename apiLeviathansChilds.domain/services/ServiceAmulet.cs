using System;
using System.Collections.Generic;
using System.Linq;
using apiLeviathansChilds.domain.arguments.amulet;
using apiLeviathansChilds.domain.interfaces.repositories;
using apiLeviathansChilds.domain.interfaces.services;
using apiLeviathansChilds.domain.resources;
using prmToolkit.NotificationPattern;

namespace apiLeviathansChilds.domain.services
{
    public class ServiceAmulet : Notifiable, IServiceAmulet
    {
        private readonly IRepositoryAmulet _repositoryAmulet;
        public ServiceAmulet(IRepositoryAmulet repositoryAmulet)
        {
            _repositoryAmulet = repositoryAmulet;
        }

        public IEnumerable<AmuletRes> GetAll()
        {
            return _repositoryAmulet.GetAll().ToList().Select(amulet => (AmuletRes)amulet);
        }

        public AmuletRes GetById(GetAmuletReq request)
        {
            if (request == null)
                AddNotification("GetUserReq", Messages.X0_IS_OBRIGATORY("Request"));

            return (AmuletRes)_repositoryAmulet.GetById(Guid.Parse(request.id));
        }
    }
}