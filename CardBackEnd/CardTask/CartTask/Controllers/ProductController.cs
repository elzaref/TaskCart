using CartTask.Core.Models;
using CartTask.Core.Repo;
using CartTask.DataBase;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CartTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]

    public class ProductController : ControllerBase
    {
        private readonly IUnitOfwork _unitOfWork;
        IRepository<Product> productRepository;

        public ProductController(IUnitOfwork unitOfwork)
        {
            _unitOfWork = unitOfwork;
            productRepository = new ProductRepository(_unitOfWork);
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> Getproducts()
        {
            var products = await productRepository.Get();
            return products;
        }

        [HttpPost]
        public async Task<ActionResult<Product>> Createproduct(Product product)
        {
            var products = await productRepository.Create(product);
            return products;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteproduct(int id)
        {
            var products = await productRepository.Delete(id);
            return products;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Updateproduct(int id, Product product)
        {
            var products = await productRepository.Update(id, product);
            return products;
        }
    }
}
