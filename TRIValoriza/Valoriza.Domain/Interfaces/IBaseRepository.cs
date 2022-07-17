using System;
using Valoriza.Core.Entities.Base;

namespace Valoriza.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        public void Create(T entity);

        public void Update(T entity);

        public void Delete(long id);
    }
}