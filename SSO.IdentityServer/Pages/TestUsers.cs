using System.Security.Claims;
using Duende.IdentityServer.Test;
using IdentityModel;

public class TestUsers
{
    public static List<TestUser> Users
    {
        get
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "d860efca-22d9-47fd-8249-791ba61b07c7",
                    Username = "David",
                    Password = "password",

                    Claims = new List<Claim>
                    {
                        new Claim("role", "FreeUser"),
                        new Claim(JwtClaimTypes.GivenName, "David"),
                        new Claim(JwtClaimTypes.FamilyName, "Flagg"),
                        new Claim("country", "nl"),
                        new Claim("client", "client1")
                    }
                },
                new TestUser
                {
                    SubjectId = "b7539694-97e7-4dfe-84da-b4256e1ff5c7",
                    Username = "Yusuf",
                    Password = "password",
                    
                    Claims = new List<Claim>
                    {
                        new Claim("role", "PayingUser"),
                        new Claim(JwtClaimTypes.GivenName, "Yusuf"),
                        new Claim(JwtClaimTypes.FamilyName, "Naheem"),
                        new Claim("country", "pk"),
                        new Claim("client", "client1")
                    }
                },
                new TestUser
                {
                    SubjectId = "e7ea84c8-b140-4e56-85a8-b0df8b4b4fc6",
                    Username = "Muhammad",
                    Password = "password",

                    Claims = new List<Claim>
                    {
                        new Claim(JwtClaimTypes.GivenName, "Muhammad"),
                        new Claim("client", "client2")
                    }
            }
            };
        }
    }
}