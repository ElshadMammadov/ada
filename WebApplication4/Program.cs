var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hellofsdfdfsdasdsadasdasffg v fdfdadsadasdasdasdd World!");

app.Run();
