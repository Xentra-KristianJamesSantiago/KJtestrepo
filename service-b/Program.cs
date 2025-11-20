var app = WebApplication.CreateBuilder(args).Build();
app.MapGet("/", () => new { service = "B", status = "OK" });
app.Run();
