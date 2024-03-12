using Microsoft.EntityFrameworkCore;

namespace CartTask.DataBase
{
    public interface IUnitOfwork : IDisposable
    {
        DbContext Context { get; }
        public Task SaveChangesAsync();
    }
}
