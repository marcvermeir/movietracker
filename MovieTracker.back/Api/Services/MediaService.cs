using Core.Entities;
using Core.Services;
using Infra.UnitOfWork;

namespace Api.Services
{
    public class MediaService : IMediaService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MediaService(IUnitOfWork unitOfWork) 
        { 
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));    
        }

        public Task<IEnumerable<MediaItem>> GetAllMediaItemsAsync()
        {
            var result = _unitOfWork.MediaItemRepository.GetAllAsync();

            return result;
        }
    }
}