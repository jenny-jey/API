using System.Collections.Generic;
using ProductService.DAL;

namespace ProductService.Repository
{
    public interface IProductRepository
    {
         IEnumerable<Products> GetAllProducts();
    }
}