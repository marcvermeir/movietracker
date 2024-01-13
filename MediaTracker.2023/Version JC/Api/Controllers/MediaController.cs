using Api.Resources;
using AutoMapper;
using Core.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class MediaController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public MediaController(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;   
        }

        [HttpGet(Name = "GetAllUsers")]
        public async Task<IEnumerable<UserResource>> GetAllUsersAsync()
        {
            var result = await _uow.UserRepository.GetAllAsync();


            return _mapper.Map<IEnumerable<UserResource>>(result);
        }
    }
}