using Microsoft.AspNetCore.Authorization;

namespace SSO.Authorization
{
    public class AuthorizationPolicies
    {
        public static AuthorizationPolicy CanAccessUsersScreen()
        {
            return new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .RequireClaim("country", "pk")
                .RequireRole("PayingUser")
                .Build();
        }
    }
}