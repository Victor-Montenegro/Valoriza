using Valoriza.Domain.Entities;

namespace Valoriza.Domain.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        public User GetUserByEmail(string email);

        public User GetUserByName(string name);
    }
}