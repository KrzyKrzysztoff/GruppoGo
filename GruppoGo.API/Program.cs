using GruppoGo.API.Modules;
using GruppoGo.Common;
using GruppoGo.Common.DTOs.Accounts;
using GruppoGo.Features;
using GruppoGo.Infrastructure;
using GruppoGo.Infrastructure.Seed;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// custom DI
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddFeatures();
builder.Services.AddCommon();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<JwtOptions>(builder.Configuration.GetSection("JwtSettings"));

// 1. Dodaj politykę CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazorClient",
        policy =>
        {
            policy.WithOrigins("https://localhost:7221") // adres Twojego Blazor WebAssembly
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

var app = builder.Build();

// 2. Włącz CORS
app.UseCors("AllowBlazorClient");
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    using (var scope = app.Services.CreateScope())
    {
        var seeder = scope.ServiceProvider.GetRequiredService<DbSeed>();
        await seeder.SeedAsync();
    }

    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapUsersEndpoints();
app.MapAuthenticateEndpoints();
app.Run();
