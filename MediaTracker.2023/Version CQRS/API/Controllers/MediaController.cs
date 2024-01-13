using API.Entities;
using API.Handlers.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace API.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class MediaController : ApiController
    {
        private readonly ISender _mediator;

        public MediaController(ISender mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [ProducesErrorResponseType(typeof(ErrorOr.ErrorOr<User>))]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetUserByIdQuery(id);
            var result = await _mediator.Send(query);

            return result.Match(resp => StatusCode((int)HttpStatusCode.OK, resp), errors => Problem(errors));
        }
    }
}