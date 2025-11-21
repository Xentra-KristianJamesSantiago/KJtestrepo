var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello DevOps TEAM! 21/11/2025");

app.Run();
