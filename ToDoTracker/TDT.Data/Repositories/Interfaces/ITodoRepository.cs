using TDT.Core.Entities;
using TDT.Data.Repositories.Base.Interfaces;

namespace TDT.Data.Repositories.Interfaces
{
    /// <summary>
    /// Todo Repository Interface.
    /// </summary>
    public interface ITodoRepository : IBaseRepository<Todo>
    {
        #region Methods

        Task<IEnumerable<Todo>> GetTopXIncompleteTodosAsync(int x);

        #endregion
    }
}