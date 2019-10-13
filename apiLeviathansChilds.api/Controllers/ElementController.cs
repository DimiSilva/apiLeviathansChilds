using System;
using System.Collections.Generic;
using apiLeviathansChilds.domain.arguments.element;
using apiLeviathansChilds.domain.interfaces.services;
using Microsoft.AspNetCore.Mvc;

namespace apiLeviathansChilds.api.Controllers
{
    [Route("api/[controller]")]
    public class ElementController : ControllerBase
    {
        private readonly IServiceElement _serviceElement;
        public ElementController(IServiceElement serviceElement)
        {
            _serviceElement = serviceElement;
        }

        [HttpGet]
        public IEnumerable<ElementRes> Get()
        {
            return _serviceElement.GetAll();
        }

        [HttpGet("{id}")]
        public ElementRes Get(Guid id)
        {
            var req = new GetElementReq(id);
            return _serviceElement.GetById(req);
        }
    }
}
