using GruppoGo.Features.Queries.Users.GetUsers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GruppoGo.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController(IMediator _mediator) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            _mediator.Send(new GetUsersQuery.Query());
            return Ok(new { Message = "Get all users" });
        }
    }
}
