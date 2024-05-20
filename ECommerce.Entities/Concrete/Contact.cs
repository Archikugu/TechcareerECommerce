using ECommerce.Core.Entities;

namespace ECommerce.Entities.Concrete
{
    public class Contact : IEntity
    {
        public int ContactID { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
