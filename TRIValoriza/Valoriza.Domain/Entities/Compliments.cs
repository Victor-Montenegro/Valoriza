using Valoriza.Domain.Entities.Base;

namespace Valoriza.Domain.Entities
{
    public class Compliments : BaseEntity 
    {
        public long UserSender { get; private set; }
        public long UserReceiver { get; private set; }
        public long TagId { get; private set; }
        public string Message { get; private set; }

        public Compliments(long userSender, long userReceiver, long tagId, string message)
        {
            UserSender = userSender;
            UserReceiver = userReceiver;
            TagId = tagId;
            Message = message;
        }
    }
}
