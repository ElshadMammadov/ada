var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hellofsdfdfsdadsadasdasdasdd World!");

app.Run();
