
//
//TODO: Quid using Specification Pattern OR CQRS ?
//TODO: Quid using Ardalis.Endpoints ? .. check eShopOnWeb sample application
//TODO: Quid implementation of DDD .. Aggregates .. ??
//

using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.OpenApi.Models;
using MT.Api.Core.Domain;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddSingleton<IMovieService, MovieService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

#region WeatherForecast

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();

    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

#endregion

#region Movies

app.MapGet("/v1.0/movies", (IMovieService movieService) =>
    TypedResults.Ok(movieService.GetMovies()))
    .WithName("GetMovies")
    .WithOpenApi(x => new OpenApiOperation(x)
    {
        Summary = "Get Watchlists Movies",
        Description = "Returns information about all the movies on the watchlists.",
        Tags = new List<OpenApiTag> { new() { Name = "MovieTracker" } }
    });

app.MapGet("/v1.0/movies/{id}", Results<Ok<Movie>, NotFound> (IMovieService movieService, int id) =>
        movieService.GetMovie(id) is { } movie
            ? TypedResults.Ok(movie)
            : TypedResults.NotFound()
    )
    .WithName("GetMovieById")
    .WithOpenApi(x => new OpenApiOperation(x)
    {
        Summary = "Get Movie By Id",
        Description = "Returns information about selected movie from the watchlists.",
        Tags = new List<OpenApiTag> { new() { Name = "MovieTracker" } }
    });

#endregion

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}