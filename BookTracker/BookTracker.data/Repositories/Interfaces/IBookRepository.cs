using BookTracker.core.Entities;
using BookTracker.data.Repositories.Base.Interfaces;

namespace BookTracker.data.Repositories.Interfaces
{
    public interface IBookRepository : IBaseRepository<Book>
    {
    }
}