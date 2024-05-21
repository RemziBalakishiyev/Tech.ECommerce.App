using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tech.BusinessLogic.Dtos;
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
