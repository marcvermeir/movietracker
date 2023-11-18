using Microsoft.AspNetCore.Mvc;

namespace AspNETCoreWebApi7.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ILogger<TaskController> _logger;

        public TaskController(ILogger<TaskController> logger)
        {
            _logger = logger;
        }

        // GET api/tasks
        [HttpGet]
        public ActionResult<IEnumerable<Models.Task>> Get()
        {
            return new List<Models.Task>();
        }

        // GET api/tasks/5
        [HttpGet("{id}")]
        public ActionResult<Models.Task> Get(int id) => new Models.Task("xxx");

        // POST api/tasks
        [HttpPost]
        public void Post([FromBody] Models.Task task) { }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(long id, [FromBody] Models.Task task) { }

        // DELETE api/tasks/5
        [HttpDelete("{id}")]
        public void Delete(long id) { }
    }
}
