using GruppoGo.Common.DTOs.Accounts;
using GruppoGo.Features.Accounts.Commands;
using MediatR;
using Microsoft.AspNetCore.Identity.Data;

namespace GruppoGo.API.Modules
{
    public static class AuthenticateEndpoints
    {
        public static void MapAuthenticateEndpoints(this WebApplication app)
        {
            app.MapPost("/api/signin", async (LoginDto logindto, IMediator mediator) =>
            {
                var result = await mediator.Send(new AuthenticateUserCommand.Command(logindto));
                return Results.Ok(result);
            })
            .WithTags("Authenticate");
        }
    }
}
