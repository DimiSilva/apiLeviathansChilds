using System.Collections.Generic;
using apiLeviathansChilds.domain.arguments.job;

namespace apiLeviathansChilds.domain.interfaces.services
{
    public interface IServiceJob
    {
        IEnumerable<JobRes> GetAll();
        JobRes GetById(GetJobReq request);
    }
}