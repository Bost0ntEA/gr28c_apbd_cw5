using Zadanie5.Controllers;

namespace Zadanie5.EndPoints;

public static class AnimalEndpoints
{
    public static void MapAnimalEndpoints(this WebApplication app)
    {
        // GET
        app.MapGet("animalsGet", () =>
        {
            AnimalController ac = new AnimalController();
        });

        // GET - id
        app.MapGet("animalsGetById/{id}", (int id) =>
        {
            return Results.Ok();
        });

        // POST
        app.MapPost("animalsPost", () =>
        {
            return Results.Created();
        });
    }
}