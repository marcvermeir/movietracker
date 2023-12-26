using Core.Entities;
using Core.Services;
using Core.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        #region Readonlys

        //TODO: private readonly ILogger<TodosModel> _logger;
        /// <summary>
        /// / private readonly IUnitOfWork _unitOfWork; 
        /// </summary>
        private readonly ITodoService _todoService;

        #endregion

        #region Ctor

        public TodosController(ITodoService todoService) 
        {
            //// _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _todoService = todoService ?? throw new ArgumentNullException(nameof(todoService));
        }

        #endregion

        #region Methods

        /* 
        [HttpGet(Name = "GetTodos")]
        public async Task<IEnumerable<Todo>> GetAsync()
        {
            return await _unitOfWork.TodoRepository.GetAllAsync();
        }
        */

        [HttpGet(Name = "GetTodos4User")]
        public async Task<IEnumerable<Todo>> Get4UserAsync()
        {
            //TODO: get the id of the current user
            return await _todoService.GetTodos4UserAsync(userId: 1);
        }
        
        #endregion
    }
}
