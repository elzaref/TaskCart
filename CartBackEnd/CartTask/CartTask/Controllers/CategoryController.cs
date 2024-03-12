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

    public class CategoryController : ControllerBase
    {
        private readonly IUnitOfwork _unitOfWork;
        IRepository<Category> categoryRepository;

        public CategoryController(IUnitOfwork unitOfwork)
        {
            _unitOfWork = unitOfwork;
            categoryRepository = new CategoryRepository(_unitOfWork);
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            var categories = await categoryRepository.Get();
            return categories;
        }

        [HttpPost]
        public async Task<ActionResult<Category>> CreateCategory(Category category)
        {
            var categories = await categoryRepository.Create(category);
            return categories;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var categories = await categoryRepository.Delete(id);
            return categories;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(int id, Category category)
        {
            var categories = await categoryRepository.Update(id, category);
            return categories;
        }
    }
}
