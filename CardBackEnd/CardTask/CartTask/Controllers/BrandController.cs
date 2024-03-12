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
    public class BrandController : ControllerBase
    {
        private readonly IUnitOfwork _unitOfWork;
        IRepository<Brand> brandRepository;

        public BrandController(IUnitOfwork unitOfwork)
        {
            _unitOfWork = unitOfwork;
            brandRepository = new BrandRepository(_unitOfWork);
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Brand>>> GetBrands()
        {
            var Brands = await brandRepository.Get();
            return Brands;
        }

        [HttpPost]
        public async Task<ActionResult<Brand>> CreateBrand(Brand Brand)
        {
            var Brands = await brandRepository.Create(Brand);
            return Brands;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrand(int id)
        {
            var Brands = await brandRepository.Delete(id);
            return Brands;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBrand(int id, Brand Brand)
        {
            var Brands = await brandRepository.Update(id, Brand);
            return Brands;
        }
    }
}
