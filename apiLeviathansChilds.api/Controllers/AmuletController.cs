using System;
using System.Collections.Generic;
using apiLeviathansChilds.domain.arguments.amulet;
using apiLeviathansChilds.domain.interfaces.services;
using Microsoft.AspNetCore.Mvc;

namespace apiLeviathansChilds.api.Controllers
{
    [Route("api/[controller]")]
    public class AmuletController : ControllerBase
    {
        private readonly IServiceAmulet _serviceAmulet;
        public AmuletController(IServiceAmulet serviceAmulet)
        {
            _serviceAmulet = serviceAmulet;
        }

        [HttpGet]
        public IEnumerable<AmuletRes> Get()
        {
            return _serviceAmulet.GetAll();
        }

        [HttpGet("{id}")]
        public AmuletRes Get(Guid id)
        {
            var req = new GetAmuletReq(id);
            return _serviceAmulet.GetById(req);
        }
    }
}
