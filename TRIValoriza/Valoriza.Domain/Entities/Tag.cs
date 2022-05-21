using Valoriza.Domain.Entities.Base;

namespace Valoriza.Domain.Entities
{
    public class Tag : BaseEntity
    {
        public string Name { get; private set; }

        public Tag(string name)
        {
            Name = name;
        }

        public Tag SetName(string name)
        {
            Name = name;

            return this;
        }
    }
}
