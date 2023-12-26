using Core.Entities;
using Core.Repositories;
using Infra.Contexts;
using Infra.Repositories.Base;

namespace Infra.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        #region Constructor

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="dbContext">The Database Context</param>
        public UserRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        #endregion
    }
}