using ECommerce.Core.Entities;

namespace ECommerce.Entities.Concrete
{
    public class Category : IEntity
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public List<Product> Products { get; set; }
        public List<Brand> Brands { get; set; }
        public string CategoryImage { get; set; }
        public bool Status { get; set; }
    }
}
