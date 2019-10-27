using System;
using System.Collections.Generic;
using System.Linq;
using apiLeviathansChilds.domain.arguments.job;
using apiLeviathansChilds.domain.interfaces.repositories;
using apiLeviathansChilds.domain.interfaces.services;
using apiLeviathansChilds.domain.resources;
using prmToolkit.NotificationPattern;

namespace apiLeviathansChilds.domain.services
{
    public class ServiceJob : Notifiable, IServiceJob
    {
        private readonly IRepositoryJob _repositoryJob;
        public ServiceJob(IRepositoryJob repositoryJob)
        {
            _repositoryJob = repositoryJob;
        }

        public IEnumerable<JobRes> GetAll()
        {
            return _repositoryJob.GetAll().ToList().Select(job => (JobRes)job);
        }

        public JobRes GetById(GetJobReq request)
        {
            if (request == null)
                AddNotification("GetUserReq", Messages.X0_IS_OBRIGATORY("Request"));

            return (JobRes)_repositoryJob.GetById(Guid.Parse(request.id));
        }
    }
}