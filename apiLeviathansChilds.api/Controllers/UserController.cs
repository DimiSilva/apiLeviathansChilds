using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiLeviathansChilds.domain.arguments.user;
using apiLeviathansChilds.domain.entities;
using apiLeviathansChilds.domain.interfaces.repositories;
using apiLeviathansChilds.domain.interfaces.services;
using Microsoft.AspNetCore.Mvc;

namespace apiLeviathansChilds.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IServiceUser _serviceUser;

        public UserController(IServiceUser serviceUser)
        {
            _serviceUser = serviceUser;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<UserRes>> Get()
        {
            return _serviceUser.GetUsers().ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
