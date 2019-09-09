using System;
using apiLeviathansChilds.domain.valueObjects;

namespace apiLeviathansChilds.domain.entities
{
    public class User
    {
        public Guid id { get; set; }
        public RealName name { get; set; }
        public string nick { get; set; }
        public Email email { get; set; }
        public string password { get; set; }
    }
}