using CartTask.Core.Models;
using CartTask.DataBase;

namespace CartTask.Core.Repo
{
    public class CategoryRepository : RepositoryBase<Category>
    {
        public CategoryRepository(IUnitOfwork unitOfwork) : base(unitOfwork)
        {
        }
    }
}
