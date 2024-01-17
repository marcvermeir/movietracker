using Core.Entities;
using Infra.Contexts;
using Infra.Repositories.Base;

namespace Infra.Repositories
{
    public class MediaItemRepository : BaseRepository<MediaItem>, IMediaItemRepository  
    {
        #region Constructor

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="dbContext">The Database Context</param>
        public MediaItemRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        #endregion
    }
}
