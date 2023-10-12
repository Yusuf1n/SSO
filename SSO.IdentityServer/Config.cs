using Duende.IdentityServer;
using Duende.IdentityServer.Models;

namespace SSO.IdentityServer;

public static class Config
{
    public static IEnumerable<IdentityResource> IdentityResources =>
        new IdentityResource[]
        { 
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResource("roles", "Your role(s)", 
                new [] { "role"})
        };

    public static IEnumerable<ApiScope> ApiScopes =>
        new ApiScope[]
            { };

    public static IEnumerable<Client> Clients =>
        new Client[]
        {
            new Client()
            {
                ClientName = "SSO",
                ClientId = "ssoclient",
                AllowedGrantTypes = GrantTypes.Code,
                RedirectUris =
                {
                    "https://localhost:7151/signin-oidc",
                    "https://localhost:7152/signin-oidc"
                },
                PostLogoutRedirectUris = 
                {
                    "https://localhost:7151/signout-callback-oidc",
                    "https://localhost:7152/signout-callback-oidc"
                },
                AllowedScopes =
                {
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Profile,
                    "roles"
                },
                ClientSecrets =
                {
                    new Secret("secret".Sha256())
                },
                RequireConsent = true
            },
            //new Client()
            //{
            //ClientName = "SSO2",
            //ClientId = "ssoclient2",
            //AllowedGrantTypes = GrantTypes.Code,
            //RedirectUris =
            //{
            //"https://localhost:7152/signin-oidc"
            //},
            //PostLogoutRedirectUris =
            //{
            //"https://localhost:7152/signout-callback-oidc"
            //},
            //AllowedScopes =
            //{
            //IdentityServerConstants.StandardScopes.OpenId,
            //IdentityServerConstants.StandardScopes.Profile,
            //"roles"
            //},
            //ClientSecrets =
            //{
            //new Secret("secret2".Sha256())
            //},
            //RequireConsent = true
            //}
        };
}