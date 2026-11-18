var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/generate", (Common.Request request) =>
{
    if (request.minValue > request.maxValue)
        return Results.BadRequest("Минимум больше максимума");

    Random random = new Random();

    int result = random.Next(
        request.minValue,
        request.maxValue + 1
    );

    return Results.Ok(result);
});

app.Run("http://localhost:5000");