using Core.Entities;
using Infra.Contexts;
using Infra.Repositories.Base;
using Infra.Repositories.Interfaces;

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