using Infra.Repositories.Interfaces;

namespace Infra.UnitOfWork.Interfaces
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