using Core.Entities;
using Infra.UnitOfWork.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        #region Readonlys

        //TODO: private readonly ILogger<TodosModel> _logger;
        private readonly IUnitOfWork _unitOfWork;

        #endregion

        #region Ctor

        public TodosController(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        #endregion

        #region Methods

        [HttpGet(Name = "GetTodos")]
        public async Task<IEnumerable<Todo>> Get()
        {
            return await _unitOfWork.TodoRepository.GetAllAsync();
        }

        #endregion
    }
}
