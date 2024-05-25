using Microsoft.EntityFrameworkCore;
using VeryComplexApp.Api.Infrastructure;

namespace VeryComplexApp.Api.Middlewares;

public class MigrationMiddleware
{
    private readonly RequestDelegate _next;

    public MigrationMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext httpContext, IServiceProvider serviceProvider)
    {
        var scope = serviceProvider.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<ComplexDbContext>();
        await context.Database.MigrateAsync();

        await _next.Invoke(httpContext);
    }
}