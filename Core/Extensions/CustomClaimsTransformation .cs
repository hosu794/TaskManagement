using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace Core.Extensions
{
    public class CustomClaimsTransformation : IClaimsTransformation
    {
        public Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
        {
            var identity = (ClaimsIdentity)principal.Identity;
            var isManagerClaim = identity.FindFirst("IsManager");
            if (isManagerClaim != null && isManagerClaim.Value == "True")
            {
                identity.AddClaim(new Claim(ClaimTypes.Role, "Manager"));
            }
            return Task.FromResult(principal);
        }
    }
}
