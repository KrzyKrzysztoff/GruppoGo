using FluentValidation;
using GruppoGo.Common.DTOs;
using GruppoGo.Common.Reponses;
using GruppoGo.Features.Queries.Users.GetUsers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace GruppoGo.API.Modules
{
    public static class UsersEndpoints
    {
        public static void MapUsersEndpoints(this WebApplication app)
        {
            app.MapGet("/api/users", async (int? page, int? size, 
                IMediator mediator,
                [FromServices] IValidator<GetUsersRequest> validator) =>
            {
                var getUsersRequest = new GetUsersRequest(size, page);
                
                var validationResult = await validator.ValidateAsync(getUsersRequest);
                if (!validationResult.IsValid)
                {
                    return Results.BadRequest(validationResult.Errors);
                }

                var query = new GetUsersQuery.Query(getUsersRequest);
                var result = await mediator.Send(query);

                return Results.Ok(new ApiReponse<UserDto>(result));
            })
            .WithTags("Users")
            .WithName("GetUsers")
            .WithSummary("Get a paginated list of users")
            .WithDescription("Retrieves a paginated list of users from the system.")
            .Produces<ApiReponse<UserDto>>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status400BadRequest);
        }
    }
}
