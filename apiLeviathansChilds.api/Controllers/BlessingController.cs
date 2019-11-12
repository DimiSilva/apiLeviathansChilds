using System;
using System.Collections.Generic;
using apiLeviathansChilds.domain.arguments.blessing;
using apiLeviathansChilds.domain.interfaces.services;
using Microsoft.AspNetCore.Mvc;

namespace apiLeviathansChilds.api.Controllers
{
    [Route("api/[controller]")]
    public class BlessingController : ControllerBase
    {
        private readonly IServiceBlessing _serviceBlessing;
        public BlessingController(IServiceBlessing serviceBlessing)
        {
            _serviceBlessing = serviceBlessing;
        }

        [HttpGet]
        public IEnumerable<BlessingRes> Get()
        {
            return _serviceBlessing.GetAll();
        }

        [HttpGet("{id}")]
        public BlessingRes Get(Guid id)
        {
            var req = new GetBlessingReq(id);
            return _serviceBlessing.GetById(req);
        }
    }
}
