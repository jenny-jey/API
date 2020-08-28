using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProductService.DAL;
using ProductService.Repository;

namespace ProductService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ProductsController: ControllerBase
    {
          private readonly IProductRepository _repo;

        public ProductsController(IProductRepository repo)
        {
            this._repo = repo;
        }
        // public ProductsController()
        // {
        //     _repo = new ProductRepository(new ProductContext());
        // }
        [HttpGet]
        [Produces("application/json")]
        public IEnumerable<Products> Get()
        {
            return _repo.GetAllProducts();
        }

    }
}