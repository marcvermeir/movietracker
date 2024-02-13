using Infra.Repositories;

namespace Infra.UnitOfWork
{
    /// <summary>
    /// Unit of Work Interface.
    /// </summary>
    public interface IUnitOfWork : IAsyncDisposable
    {
        #region Properties

        IMediaItemRepository MediaItemRepository { get; }

        #endregion

        #region Methods

        Task CompleteAsync();

        #endregion
    }
}