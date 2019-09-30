using System;
using apiLeviathansChilds.domain.interfaces.arguments;

namespace apiLeviathansChilds.domain.arguments.user
{
    public class UpdateUserReq : IRequest
    {
        public Guid id { get; private set; }
        public string firstName { get; private set; }
        public string lastName { get; private set; }

        public UpdateUserReq(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public void SetId(Guid id)
        {
            this.id = id;
        }
    }
}