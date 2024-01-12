using Core.Entities;
using Core.Services;
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
            _todoService = todoService ?? throw new ArgumentNullException(nameof(todoService));
        }

        #endregion

        #region Methods

        /*  //TODO: ??? quid implementation of multiple GET methods ???
        [HttpGet(Name = "GetAllTodos")]
        public async Task<IEnumerable<Todo>> GetAllAsync()
        {
            return await _todoService.GetTodosAsync();
        }
        */

        [HttpGet(Name = "Get4User")]
        public async Task<IEnumerable<Todo>> Get4UserAsync()
        {
            //TODO: get the id of the current user
            //TODO: var user = (WindowsIdentity)context.User.Identity!;


            return await _todoService.GetTodos4UserAsync(userId: 1);
        }

        [HttpPost(Name = "Post")]
        public async Task<Todo> PostAsync(Todo todo)
        {
            //TODO: quid checking if todo == valid ???
            //TODO: quid checking if todo already exists ???

            return await _todoService.AddTodoAsync(todo);
        }

        //TODO: >>> add Update (= HttpPut) & Delete (= HttpDelete) methods 4 Todo(s
        //>>> https://positiwise.com/blog/web-api-for-crud-operations-in-net-6

        #endregion
    }
}
