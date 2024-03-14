using BookTracker.core.Entities;
using BookTracker.data.Contexts;
using BookTracker.data.Repositories.Base;
using BookTracker.data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookTracker.data.Repositories
{
    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
    {
        #region Properties

        private BTDbContext? bTDbContext => _dbContext as BTDbContext;

        #endregion

        #region Ctor

        public AuthorRepository(DbContext dbContext) : base(dbContext)
        {
        }

        #endregion
    }
}
