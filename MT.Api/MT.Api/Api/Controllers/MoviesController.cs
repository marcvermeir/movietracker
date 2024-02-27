using Core.Entities;
using Core.Interfaces;
using Core.Specification;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IGenericRepository<Movie> _repository;

        public MoviesController(IGenericRepository<Movie> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var movies = await _repository.GetAllAsync();
            
            return Ok(movies);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var movie = await _repository.GetByIdAsync(id);
            
            return Ok(movie);
        }

        [HttpGet("specify")]
        public async Task<IActionResult> Specify()
        {
            //var specification = new DeveloperWithAddressSpecification(3);
            var specification = new MovieByDirectorSpecification();
 
            //TODO: Quid refactoring the following as an ASYNC method ?
            var movies = _repository.FindWithSpecificationPattern(specification);
            
            return Ok(movies);
        }
    }
}