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
    public class UserController : ControllerBase
    {
        private readonly IServiceUser _serviceUser;

        public UserController(IServiceUser serviceUser)
        {
            _serviceUser = serviceUser;
        }

        [HttpGet]
        public IEnumerable<UserRes> Get()
        {
            return _serviceUser.GetAll();
        }

        [HttpGet("{id}")]
        public UserRes Get(Guid id)
        {
            var req = new GetUserReq(id);
            return _serviceUser.GetById(req);
        }

        // POST api/values
        [HttpPost]
        public CreateUserRes Post([FromBody] CreateUserReq req)
        {
            Console.WriteLine(req.firstName);
            // var req = new CreateUserReq(firstName, lastName, nick, emailAdress, password);
            return _serviceUser.Insert(req);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public UpdateUserRes Put(Guid id, [FromBody] UpdateUserReq req)
        {
            req.SetId(id);
            return _serviceUser.Update(req);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public RemoveUserRes Delete(Guid id)
        {
            var req = new RemoveUserReq(id);
            return _serviceUser.Remove(req);
        }
    }
}
