using Valoriza.Core.Entities.Base;
using Valoriza.Core.Services.Security;

namespace Valoriza.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public bool Admin { get; private set; }
        public string Password { get; private set; }

        public User(string name, string email, bool admin)
        {
            Name = name;
            Email = email;
            Admin = admin;
        }

        public User EncryptPassword(string passworld, ICryptographyService cryptographyService)
        {
            string encryptedPassword = cryptographyService.GenerateEncryption(passworld);

            Password = encryptedPassword; 
            
            return this;
        }
    }
}
