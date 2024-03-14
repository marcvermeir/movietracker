using BookTracker.data.Repositories.Interfaces;

namespace BookTracker.data.UnitOfWork.Interfaces
{
    /// <summary>
    /// Unit of Work Interface.
    /// </summary>
    public interface IUnitOfWork : IAsyncDisposable
    {
        #region Properties

        IAuthorRepository AuthorRepository { get; }
        IBookRepository BookRepository { get; }

        #endregion

        #region Methods

        Task CompleteAsync();

        #endregion
    }
}