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
                new [] { "role"}),
            new IdentityResource("country", "The country you're living in",
            new List<string>() { "country"}),
            new IdentityResource("clients", "Applications you're able to access",
            new List<string>() { "client"})
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
                AllowOfflineAccess = true,
                UpdateAccessTokenClaimsOnRefresh = true,
                AccessTokenLifetime = 60,
                // AuthorizationCodeLifetime = ...
                // IdentityTokenLifetime = ...
                RedirectUris =
                {
                    "https://localhost:7151/signin-oidc",
                    "https://localhost:7152/signin-oidc",
                    "https://localhost:7153/signin-oidc"
                },
                PostLogoutRedirectUris = 
                {
                    "https://localhost:7151/signout-callback-oidc",
                    "https://localhost:7152/signout-callback-oidc",
                    "https://localhost:7153/signout-callback-oidc"
                },
                AllowedScopes =
                {
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Profile,
                    "roles",
                    "country",
                    "clients"
                },
                ClientSecrets =
                {
                    new Secret("secret".Sha256())
                },
                RequireConsent = true
            },
            new Client()
            {
                ClientName = "Demo",
                ClientId = "democlient",
                AllowedGrantTypes = GrantTypes.Code,
                RedirectUris =
                {
                    "https://localhost:7151/signin-oidc",
                    "https://localhost:7152/signin-oidc",
                    "https://localhost:7153/signin-oidc"
                },
                PostLogoutRedirectUris = 
                {
                    "https://localhost:7151/signout-callback-oidc",
                    "https://localhost:7152/signout-callback-oidc",
                    "https://localhost:7153/signout-callback-oidc"
                },
                AllowedScopes =
                {
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Profile,
                    "clients"
                },
                ClientSecrets =
                {
                    new Secret("demo".Sha256())
                },
                RequireConsent = true
            }
        };
}