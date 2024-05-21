using Tech.BusinessLogic.TAbstract;
using Tech.DataAccess.Abstract.Products;

namespace Tech.BusinessLogic.TConcrete
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        
       
    }
}
