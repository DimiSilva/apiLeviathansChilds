using System;
using System.Collections.Generic;
using apiLeviathansChilds.domain.entities;

namespace apiLeviathansChilds.domain.interfaces.repositories
{
    public interface IRepositoryAmulet
    {
        List<Amulet> GetAll();
        Amulet GetById(Guid id);
    }
}