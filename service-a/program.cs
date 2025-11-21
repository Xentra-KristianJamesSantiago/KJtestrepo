var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello DevOps TEAM! test 2 21/11/2025");

app.Run();
