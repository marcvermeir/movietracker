using Core.Entities;
using Infra.Repositories.Base.Interfaces;

namespace Infra.Repositories.Interfaces
{
    public interface ITodoRepository : IBaseRepository<Todo>
    {
        #region Methods

        Task<IEnumerable<Todo>> GetTopXIncompleteTodosAsync(int x);

        #endregion
    }
}