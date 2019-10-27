using System;
using apiLeviathansChilds.domain.interfaces.arguments;

namespace apiLeviathansChilds.domain.arguments.character
{
    public class UpdateCharacterReq : IRequest
    {
        public string id { get; private set; }
        public int amuletExperience { get; set; }
        public int battlesNumber { get; set; }
        public int victorysNumber { get; set; }
        public int losesNumber { get; set; }
        public int battleTimeInSeconds { get; set; }
        public int xp { get; set; }

        public UpdateCharacterReq(int amuletExperience, int battlesNumber, int victorysNumber, int losesNumber, int battleTimeInSeconds, int xp)
        {
            this.amuletExperience = amuletExperience;
            this.battlesNumber = battlesNumber;
            this.victorysNumber = victorysNumber;
            this.losesNumber = losesNumber;
            this.battleTimeInSeconds = battleTimeInSeconds;
            this.xp = xp;
        }
        public void SetId(Guid id)
        {
            this.id = id.ToString();
        }
    }
}