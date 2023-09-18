using PoolBreakfast.Api.Services.Breakfasts;

// Handling services/ dependency injection
var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    builder.Services.AddBreakfastService();
}

// Handling request pipeline
var app = builder.Build();
{
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}