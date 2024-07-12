using Microsoft.AspNetCore.Http;
using System.IdentityModel.Tokens.Jwt;

namespace Core.Extensions
{
    public class ManagerAuthorizationMiddleware
    {
        private readonly RequestDelegate _next;

        public ManagerAuthorizationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var endpoint = context.GetEndpoint();
            if (endpoint?.Metadata?.GetMetadata<ManagerOnlyAttribute>() != null)
            {
                var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
                if (string.IsNullOrEmpty(token))
                {
                    context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                    await context.Response.WriteAsync("No token provided.");
                    return;
                }

                var isManager = false;
                try
                {
                    var handler = new JwtSecurityTokenHandler();
                    var jsonToken = handler.ReadToken(token) as JwtSecurityToken;

                    var isManagerClaim = jsonToken?.Claims.FirstOrDefault(claim => claim.Type == "IsManager");
                    isManager = isManagerClaim != null && bool.TryParse(isManagerClaim.Value, out bool result) && result;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error parsing token: {ex.Message}");
                    context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                    await context.Response.WriteAsync("Invalid token.");
                    return;
                }

                if (!isManager)
                {
                    context.Response.StatusCode = StatusCodes.Status403Forbidden;
                    await context.Response.WriteAsync("Access denied. Manager rights required.");
                    return;
                }
            }

            await _next(context);
        }
    }

    public class ManagerOnlyAttribute : Attribute { }
}
