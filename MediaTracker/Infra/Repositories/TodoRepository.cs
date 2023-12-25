﻿using Core.Entities;
using Infra.Contexts;
using Infra.Repositories.Base;
using Infra.Repositories.Interfaces;

namespace Infra.Repositories
{
    public class TodoRepository : BaseRepository<Todo>, ITodoRepository
    {
        #region Properties

        private AppDbContext? AppDbContext => _dbContext as AppDbContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="dbContext">The Database Context</param>
        public TodoRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the top X incomplete Todo items.
        /// </summary>
        /// <param name="x">The maximum number of Todo items to return</param>
        /// <returns>A collection of Todo items</returns>
        public async Task<IEnumerable<Todo>> GetTopXIncompleteTodosAsync(int x)
        {
            return await GetManyAsync(
                filter: t => !t.Completed,
                orderBy: t => t.OrderBy(t => t.Title),
                top: x);
        }

        #endregion
    }
}