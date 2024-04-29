using TDT.Core.Entities;
using TDT.Data.Contexts;
using TDT.Data.Repositories.Base;
using TDT.Data.Repositories.Interfaces;

namespace TDT.Data.Repositories
{
    /// <summary>
    /// User Repository.
    /// </summary>
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