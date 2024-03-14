using BookTracker.data.Contexts;
using BookTracker.data.Repositories;
using BookTracker.data.Repositories.Interfaces;
using BookTracker.data.UnitOfWork.Interfaces;

namespace BookTracker.data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Properties

        private AuthorRepository _authorRepository;
        public IAuthorRepository AuthorRepository => _authorRepository ?? (_authorRepository = new AuthorRepository(_dbContext));

        private BookRepository _bookRepository;
        public IBookRepository BookRepository => _bookRepository ?? (_bookRepository = new BookRepository(_dbContext));

        #endregion

        #region Readonlys

        private readonly BTDbContext _dbContext;

        #endregion

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="dbContext">The Database Context</param>
        public UnitOfWork(BTDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        #region Methods

        /// <summary>
        /// Completes the unit of work, saving all repository changes to the underlying data-store.
        /// </summary>
        /// <returns><see cref="Task"/></returns>
        public async Task CompleteAsync() => await _dbContext.SaveChangesAsync();

        #endregion

        #region Implements IDisposable

        #region Private Dispose Fields

        private bool _disposed;

        #endregion

        /// <summary>
        /// Cleans up any resources being used.
        /// </summary>
        /// <returns><see cref="ValueTask"/></returns>
        public async ValueTask DisposeAsync()
        {
            await DisposeAsync(true);

            // Take this object off the finalization queue to prevent 
            // finalization code for this object from executing a second time.
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Cleans up any resources being used.
        /// </summary>
        /// <param name="disposing">Whether or not we are disposing</param>
        /// <returns><see cref="ValueTask"/></returns>
        protected virtual async ValueTask DisposeAsync(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Dispose managed resources.
                    await _dbContext.DisposeAsync();
                }

                // Dispose any unmanaged resources here...

                _disposed = true;
            }
        }

        #endregion
    }
}