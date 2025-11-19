using FluentValidation;
using GruppoGo.Common.DTOs.Users;
using GruppoGo.Common.Reponses;
using GruppoGo.Features.Queries.Users.GetUsers;
using GruppoGo.Features.Users.Queries.GetUsers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace GruppoGo.API.Modules
{
    public static class UsersEndpoints
    {
        public static void MapUsersEndpoints(this WebApplication app)
        {
           app.MapGet("/api/user/{id}", async(Guid id, IMediator mediator) =>
            {
                //var query = new GetUserByIdQuery.Query(id);
                //var result = await mediator.Send(query);
                //if (result == null)
                //{
                //    return Results.NotFound();
                //}
                return Results.Ok();
            }).WithTags("Users")
            .WithName("GetUserById")
            .WithSummary("Get a paginated list of users")
            .WithDescription("Retrieves a paginated list of users from the system.")
            .Produces<ApiResponse<UserDto>>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status400BadRequest);

            app.MapGet("/api/users", async (int page, int size, 
                IMediator mediator,
                [FromServices] IValidator<GetUsersRequest> validator) =>
            {

                //  var validationResult = await validator.ValidateAsync(getUsersRequest); middleware

                //if (!validationResult.IsValid) middleware
                //{
                //    var errors = string
                //    .Join(", ", validationResult
                //    .Errors
                //    .Select(e => $"{e.PropertyName} {e.ErrorMessage}")
                //    .ToList());

                //    return Results.BadRequest(new ApiReponse<GetUsersRequest>(null, Status: "ValidationError", errors));
                //}

                var getUsersRequest = new GetUsersRequest(size, page);

                var query = new GetUsersQuery.Query(getUsersRequest);
                var result = await mediator.Send(query);

                return Results.Ok(result);
            })
            .WithTags("Users")
            .WithName("GetUsers")
            .WithSummary("Get a paginated list of users")
            .WithDescription("Retrieves a paginated list of users from the system.")
            .Produces<ApiResponse<UserDto>>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status400BadRequest);
        }
    }
}
