using System.Collections.Generic;
using apiLeviathansChilds.domain.arguments.amulet;

namespace apiLeviathansChilds.domain.interfaces.services
{
    public interface IServiceAmulet
    {
        IEnumerable<AmuletRes> GetAll();
        AmuletRes GetById(GetAmuletReq request);
    }
}