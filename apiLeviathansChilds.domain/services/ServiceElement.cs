using System;
using System.Collections.Generic;
using System.Linq;
using apiLeviathansChilds.domain.arguments.element;
using apiLeviathansChilds.domain.interfaces.repositories;
using apiLeviathansChilds.domain.interfaces.services;
using apiLeviathansChilds.domain.resources;
using prmToolkit.NotificationPattern;

namespace apiLeviathansChilds.domain.services
{
    public class ServiceElement : Notifiable, IServiceElement
    {
        private readonly IRepositoryElement _repositoryElement;
        public ServiceElement(IRepositoryElement repositoryElement)
        {
            _repositoryElement = repositoryElement;
        }

        public ElementRes GetById(GetElementReq request)
        {
            if (request == null)
                AddNotification("GetUserReq", Messages.X0_IS_OBRIGATORY("Request"));

            return (ElementRes)_repositoryElement.GetById(Guid.Parse(request.id));
        }

        IEnumerable<ElementRes> IServiceElement.GetAll()
        {
            return _repositoryElement.GetAll().ToList().Select(amulet => (ElementRes)amulet);
        }
    }
}