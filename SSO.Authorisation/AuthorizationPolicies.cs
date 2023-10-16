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
        
        public static AuthorizationPolicy CanAccessClient2Application()
        {
            return new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .RequireClaim("client", "client2")
                .Build();
        }
        
        public static AuthorizationPolicy CanAccessClient1Application()
        {
            return new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .RequireClaim("client", "client1")
                .Build();
        }
    }
}