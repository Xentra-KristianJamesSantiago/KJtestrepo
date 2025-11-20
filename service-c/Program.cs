var app = WebApplication.CreateBuilder(args).Build();
app.MapGet("/", () => new {
    service = "C",
    number = Random.Shared.Next(1, 100)
});
app.Run();
