using Api.Resources;
using AutoMapper;
using Core.Services;
using Infra.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class MediaItemsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IMediaService _mediaService;

        public MediaItemsController(IUnitOfWork unitOfWork, IMediaService mediaService, IMapper mapper) 
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _mediaService = mediaService ?? throw new ArgumentNullException(nameof(mediaService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }   

        [HttpGet]
        public async Task<IActionResult> ListAsync()
        {
            var entities = await _unitOfWork.MediaItemRepository.GetAllAsync();

            var model = _mapper.Map<List<MediaItemResource>>(entities);

            return Ok(model);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var entity = await _unitOfWork.MediaItemRepository.GetByIdAsync(id);
            if (entity == null)
                return NotFound();

            return Ok(entity);
        }
    }
}