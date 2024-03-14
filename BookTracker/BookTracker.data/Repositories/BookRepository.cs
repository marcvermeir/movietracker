using BookTracker.core.Entities;
using BookTracker.data.Contexts;
using BookTracker.data.Repositories.Base;
using BookTracker.data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTracker.data.Repositories
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        #region Properties

        private BTDbContext? bTDbContext => _dbContext as BTDbContext;

        #endregion

        #region Ctor

        public BookRepository(DbContext dbContext) : base(dbContext)
        {
        }

        #endregion
    }
}
