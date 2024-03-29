﻿namespace Infra.Repositories.Base
{
    using System.Linq.Expressions;

    public interface IBaseRepository<T> where T : class
    {
        #region Methods

        Task<T> AddAsync(T entity);
        Task DeleteAsync(T entity);
        Task DeleteManyAsync(Expression<Func<T, bool>> filter);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(long id);
        Task<IEnumerable<T>> GetManyAsync(Expression<Func<T, bool>>? filter = null,
                                          Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
                                          int? top = null,
                                          int? skip = null,
                                          params string[] includeProperties);
        Task UpdateAsync(T entity);

        #endregion
    }
}