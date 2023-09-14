// Handling dependency injection
var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
}

// Handling request pipeline
var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}