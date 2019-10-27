using System;
using System.Collections.Generic;
using apiLeviathansChilds.domain.entities;

namespace apiLeviathansChilds.domain.interfaces.repositories
{
    public interface IRepositoryJob
    {
        List<Job> GetAll();
        Job GetById(Guid id);
    }
}