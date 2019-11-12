using System.Collections.Generic;
using apiLeviathansChilds.domain.arguments.blessing;

namespace apiLeviathansChilds.domain.interfaces.services
{
    public interface IServiceBlessing
    {
        IEnumerable<BlessingRes> GetAll();
        BlessingRes GetById(GetBlessingReq request);
    }
}