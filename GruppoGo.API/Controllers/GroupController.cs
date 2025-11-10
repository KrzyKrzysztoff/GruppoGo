using GruppoGo.Features.Queries.Users.GetUsers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GruppoGo.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupController(IMediator _mediator) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetGroups()
        {
            var groups = _mediator.Send(new GetUsersQuery.Query());

            return Ok(groups);
        }
    }
}
