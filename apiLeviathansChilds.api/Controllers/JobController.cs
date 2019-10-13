using System;
using System.Collections.Generic;
using apiLeviathansChilds.domain.arguments.job;
using apiLeviathansChilds.domain.interfaces.services;
using Microsoft.AspNetCore.Mvc;

namespace apiLeviathansChilds.api.Controllers
{
    [Route("api/[controller]")]
    public class JobController : ControllerBase
    {
        private readonly IServiceJob _serviceJob;
        public JobController(IServiceJob serviceJob)
        {
            _serviceJob = serviceJob;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_serviceJob.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult Get(Guid id)
        {
            var req = new GetJobReq(id);
            return Ok(_serviceJob.GetById(req));
        }
    }
}
