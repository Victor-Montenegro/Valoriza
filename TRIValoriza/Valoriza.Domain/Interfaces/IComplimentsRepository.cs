using System.Collections.Generic;
using Valoriza.Domain.Entities;

namespace Valoriza.Domain.Interfaces
{
    public interface IComplimentsRepository : IBaseRepository<Compliments>
    {
        public Compliments GetComplimentsByUserSender(string userSender);

        public Compliments GetComplimentsByUserReceiver(string userReceiver);

        public ICollection<Compliments> GetComplimentsByTagId(long tagId);
    }
}