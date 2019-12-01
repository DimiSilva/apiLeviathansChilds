using System;
using System.Collections.Generic;
using apiLeviathansChilds.domain.arguments.character;
using apiLeviathansChilds.domain.interfaces.services;
using Microsoft.AspNetCore.Mvc;

namespace apiLeviathansChilds.api.Controllers
{
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly IServiceCharacter _serviceCharacter;
        public CharacterController(IServiceCharacter serviceCharacter)
        {
            _serviceCharacter = serviceCharacter;
        }

        [HttpGet("user/{id}")]
        public IEnumerable<CharacterRes> GetAllForUser(Guid id)
        {
            var req = new GetAllFromUserReq(id);
            return _serviceCharacter.GetAllFromUser(req);
        }

        [HttpGet]
        public IEnumerable<CharacterRes> GetAll()
        {
            return _serviceCharacter.GetAll();
        }

        [HttpGet("{id}")]
        public CharacterRes GetById(Guid id)
        {
            var req = new GetCharacterReq(id);
            return _serviceCharacter.GetById(req);
        }

        [HttpPost]
        public CreateCharacterRes Insert([FromBody] CreateCharacterReq req)
        {
            return _serviceCharacter.Insert(req);
        }

        [HttpPut("{id}")]
        public UpdateCharacterRes Update(Guid id, [FromBody] UpdateCharacterReq req)
        {
            req.SetId(id);
            return _serviceCharacter.Update(req);
        }

        [HttpDelete("{id}")]
        public RemoveCharacterRes Remove(Guid id)
        {
            var req = new RemoveCharacterReq(id);
            return _serviceCharacter.Remove(req);
        }
    }
}
