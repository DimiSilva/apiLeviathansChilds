using System;
using System.Collections.Generic;
using System.Linq;
using apiLeviathansChilds.domain.arguments.character;
using apiLeviathansChilds.domain.arguments.user;
using apiLeviathansChilds.domain.entities;
using apiLeviathansChilds.domain.interfaces.repositories;
using apiLeviathansChilds.domain.interfaces.services;
using apiLeviathansChilds.domain.resources;
using apiLeviathansChilds.domain.valueObjects;
using prmToolkit.NotificationPattern;

namespace apiLeviathansChilds.domain.services
{
    public class ServiceCharacter : Notifiable, IServiceCharacter
    {
        private readonly IRepositoryCharacter _repositoryCharacter;
        private readonly IRepositoryElement _repositoryElement;
        private readonly IRepositoryJob _repositoryJob;
        private readonly IRepositoryUser _repositoryUser;
        private readonly IRepositoryAmulet _repositoryAmulet;

        public ServiceCharacter(IRepositoryCharacter repositoryCharacter, IRepositoryElement repositoryElement, IRepositoryJob repositoryJob, IRepositoryUser repositoryUser, IRepositoryAmulet repositoryAmulet)
        {
            _repositoryCharacter = repositoryCharacter;
            _repositoryElement = repositoryElement;
            _repositoryJob = repositoryJob;
            _repositoryUser = repositoryUser;
            _repositoryAmulet = repositoryAmulet;
        }

        public IEnumerable<CharacterRes> GetAll()
        {
            return _repositoryCharacter.GetAll().ToList().Select(character => (CharacterRes)character);
        }

        public IEnumerable<CharacterRes> GetAllFromUser(GetAllFromUserReq request)
        {
            return _repositoryCharacter.GetAllFromUser(request.id).ToList().Select(character => (CharacterRes)character);
        }

        public CharacterRes GetById(GetCharacterReq request)
        {
            if (request == null)
                AddNotification("GetCharacterReq", Messages.X0_IS_OBRIGATORY("Request"));

            return (CharacterRes)_repositoryCharacter.GetById(Guid.Parse(request.id));
        }

        public CreateCharacterRes Insert(CreateCharacterReq request)
        {
            if (request == null)
                AddNotification("CreateCharacterReq", Messages.X0_IS_OBRIGATORY("Request"));

            Element element = _repositoryElement.GetById(Guid.Parse(request.element));
            Job job = _repositoryJob.GetById(Guid.Parse(request.job));
            Amulet amulet = _repositoryAmulet.GetById(Guid.Parse(request.amulet));
            User user = _repositoryUser.GetById(Guid.Parse(request.user));

            Character character = new Character(request.name, job, user, element, amulet);

            if (this.IsInvalid())
                return null;

            Guid characterId = _repositoryCharacter.Insert(character);
            return (CreateCharacterRes)characterId;
        }

        public RemoveCharacterRes Remove(RemoveCharacterReq request)
        {
                        if (request == null)
            {
                AddNotification("RemoveCharacterReq", Messages.X0_IS_OBRIGATORY("Request"));
                return null;
            }
            Character character = _repositoryCharacter.GetById(Guid.Parse(request.id));
            if (character == null)
            {
                AddNotification("CharacterNotFound", Messages.X0_NOT_FOUND("Character"));
                return null;
            }

            _repositoryCharacter.Remove(character.id);
            return new RemoveCharacterRes();
        }

        public UpdateCharacterRes Update(UpdateCharacterReq request)
        {
            if (request == null)
            {
                AddNotification("UpdateCharacterReq", Messages.X0_IS_OBRIGATORY("Request"));
                return null;
            }

            Character character = _repositoryCharacter.GetById(Guid.Parse(request.id));

            if (character == null)
            {
                AddNotification("user", Messages.X0_NOT_FOUND("User"));
                return null;
            }

            character.Update(request);
            AddNotifications(character);
            if (IsInvalid())
                return null;
            _repositoryCharacter.Update(character);
            return new UpdateCharacterRes();
        }
    }
}