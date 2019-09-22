using System;
using System.Collections.Generic;
using System.Linq;
using apiLeviathansChilds.domain.entities;
using apiLeviathansChilds.domain.interfaces.repositories;
using Microsoft.EntityFrameworkCore;

namespace apiLeviathansChilds.infra.persistence.repositories
{
    public class RepositoryUser : RepositoryBase<User, Guid>, IRepositoryUser
    {
        protected readonly Context _context;

        public RepositoryUser(Context context) : base(context) { }
    }
}