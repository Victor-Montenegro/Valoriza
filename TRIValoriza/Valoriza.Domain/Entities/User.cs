using Valoriza.Domain.Entities.Base;

namespace Valoriza.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public bool Admin { get; private set; }
        public string Passworld { get; private set; }


        public User(string name, string email, bool admin)
        {
            Name = name;
            Email = email;
            Admin = admin;
        }

        public User SetName(string name)
        {
            Name = name;

            return this;
        }

        public User SetEmail(string email)
        {
            Email = email;

            return this;
        }

        public User EncryptPassworld(string passworld)
        {
            Passworld = passworld;

            return this;
        }
    }
}
