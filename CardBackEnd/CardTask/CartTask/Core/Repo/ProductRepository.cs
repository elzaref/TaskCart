using CartTask.Core.Models;
using CartTask.DataBase;
using System.Net;
using System.Security.Policy;

namespace CartTask.Core.Repo
{
    public class ProductRepository : RepositoryBase<Product>
    {
        public ProductRepository(IUnitOfwork unitOfwork) : base(unitOfwork)
        {
        }
    }
    
}
