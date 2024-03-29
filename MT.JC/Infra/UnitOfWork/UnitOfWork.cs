﻿using Infra.Contexts;
using Infra.Repositories;

namespace Infra.UnitOfWork
{
    /// <summary>
    /// Encapsulates all repository transactions.
    /// </summary>
    /// <remarks>
    /// Constructor.
    /// </remarks>
    /// <param name="dbContext">The Database Context</param>
    public class UnitOfWork(MTDbContext dbContext) : IUnitOfWork
    {
        #region Properties

        private IMediaItemRepository? _mediaItemRepository;
        public IMediaItemRepository MediaItemRepository => _mediaItemRepository ?? (_mediaItemRepository = new MediaItemRepository(_dbContext));

        #endregion

        #region Readonlys

        private readonly MTDbContext _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));

        #endregion

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