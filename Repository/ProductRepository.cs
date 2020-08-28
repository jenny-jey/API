using System.Collections.Generic;
using ProductService.DAL;
using System.Linq;

namespace ProductService.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _context;
        public ProductRepository(ProductContext context)
        {
            this._context = context;
        }
        //ProductContext _context = new ProductContext();

        public IEnumerable<Products> GetAllProducts()
        {
             IEnumerable<Products> product = from p in _context.Products select new Products
                                            {ProductId = p.ProductId,
                                            ProductName = p.ProductName,
                                            ProductCode = p.ProductCode,
                                            ReleaseDate = p.ReleaseDate,
                                            Price = p.Price,
                                            StarRating = p.StarRating,
                                            Description = p.Description,
                                            ImageUrl = p.ImageUrl };

            return product;
        }
    }
}