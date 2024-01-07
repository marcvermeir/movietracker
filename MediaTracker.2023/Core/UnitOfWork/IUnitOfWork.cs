using Core.Repositories;

namespace Core.UnitOfWork
{
    /// <summary>
    /// Unit of Work Interface.
    /// </summary>
    public interface IUnitOfWork : IAsyncDisposable
    {
        #region Properties

        ITodoRepository TodoRepository { get; }
        IUserRepository UserRepository { get; }

        #endregion

        #region Methods

        Task CompleteAsync();

        #endregion
    }
}