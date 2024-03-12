using CartTask.Core.Models;
using CartTask.DataBase;

namespace CartTask.Core.Repo
{
    
    public class BrandRepository : RepositoryBase<Brand>
    {
        public BrandRepository(IUnitOfwork unitOfwork) : base(unitOfwork)
        {
        }
    }
}
