using System;
using System.Collections.Generic;
using apiLeviathansChilds.domain.entities;

namespace apiLeviathansChilds.domain.interfaces.repositories
{
    public interface IRepositoryBlessing
    {
        List<Blessing> GetAll();
        Blessing GetById(Guid id);
    }
}