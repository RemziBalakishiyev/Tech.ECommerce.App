using Tech.Entity.Concrete.Common;

namespace Tech.Entity.Concrete.Products;

public class Product:BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; }= string.Empty;
    public double Price { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; } = new Category();
    public ICollection<Order>  Orders { get; set; } =  new HashSet<Order>();
}
