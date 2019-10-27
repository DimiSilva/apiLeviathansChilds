using System.Collections.Generic;
using apiLeviathansChilds.domain.arguments.element;

namespace apiLeviathansChilds.domain.interfaces.services
{
    public interface IServiceElement
    {
        IEnumerable<ElementRes> GetAll();
        ElementRes GetById(GetElementReq request);
    }
}