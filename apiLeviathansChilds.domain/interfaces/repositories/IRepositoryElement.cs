using System;
using System.Collections.Generic;
using apiLeviathansChilds.domain.entities;

namespace apiLeviathansChilds.domain.interfaces.repositories
{
    public interface IRepositoryElement
    {
        List<Element> GetAll();
        Element GetById(Guid id);
    }
}