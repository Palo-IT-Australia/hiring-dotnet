namespace Wallboard.Middleware;

public static class MiddlewareExtensions
{
    public static IApplicationBuilder UseCustomAuthMiddleware(
        this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<CustomAuthMiddleware>();
    }
}