using System.Net;

namespace Wallboard.Middleware;

public class CustomAuthMiddleware 
{
    private readonly RequestDelegate _next;
    private const string SpecialAuthHeader = "special-auth";
    private const string SpecialAuthString = "sillystring";

    public CustomAuthMiddleware(RequestDelegate next) {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        var specialAuthHeader = context.Request.Headers
            .FirstOrDefault(x => x.Key == SpecialAuthHeader);
        if (context.Request.Method == WebRequestMethods.Http.Post && specialAuthHeader.Value != SpecialAuthString)
        {
            return;
        }
        await _next(context);
    } 
}