using Core.Entities;

namespace Core.Services
{
    public interface IMediaService
    {
        //TODO: refactor this as a PagedResult ..
        Task<IEnumerable<MediaItem>> GetAllMediaItemsAsync();
    }
}