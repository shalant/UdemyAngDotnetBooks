var builder = WebApplication.CreateBuilder(args);

// add services
builder.Services.AddControllers();

var app = builder.Build();

// add mapping
app.MapControllers();

app.MapGet("/", () =>
{
    return Results.Redirect("/api/books");
});

app.Run();
