using System;
using System.Collections.Generic;
using apiLeviathansChilds.domain.arguments.user;
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

        [HttpPost]
        public CreateUserRes Post([FromBody] CreateUserReq req)
        {
            return _serviceUser.Insert(req);
        }

        [HttpPost("authentication")]
        public AuthenticationRes Post([FromBody] AuthenticationReq req)
        {
            return _serviceUser.Authentication(req);
        }

        [HttpPut("{id}")]
        public UpdateUserRes Put(Guid id, [FromBody] UpdateUserReq req)
        {
            req.SetId(id);
            return _serviceUser.Update(req);
        }

        [HttpDelete("{id}")]
        public RemoveUserRes Delete(Guid id)
        {
            var req = new RemoveUserReq(id);
            return _serviceUser.Remove(req);
        }
    }
}
