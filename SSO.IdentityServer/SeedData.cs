using IdentityModel;
using Microsoft.AspNetCore.Identity;
using Serilog;
using SSO.IdentityServer.Areas.Identity.Data;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using SSO.IdentityServer.Data;

namespace SSO.IdentityServer;

public class SeedData
{
    public static void EnsureSeedData(WebApplication app)
    {
        using (var scope = app.Services
            .GetRequiredService<IServiceScopeFactory>().CreateScope())
        {
            var context = scope.ServiceProvider.GetService<SSOIdentityServerContext>();
            context.Database.Migrate();

            var userMgr = scope.ServiceProvider
                .GetRequiredService<UserManager<ApplicationUser>>();
            var yusuf = userMgr.FindByNameAsync("Yusuf").Result;
            if (yusuf == null)
            {
                yusuf = new ApplicationUser
                {
                    UserName = "Yusuf",
                    Email = "yusufnaheem1@gmail.com",
                    EmailConfirmed = true,
                };
                var result = userMgr.CreateAsync(yusuf, "P@ssword1").Result;
                if (!result.Succeeded)
                {
                    throw new Exception(result.Errors.First().Description);
                }

                result = userMgr.AddClaimsAsync(yusuf, new Claim[]{
                        new Claim("role", "PayingUser"),
                        new Claim(JwtClaimTypes.GivenName, "Yusuf"),
                        new Claim(JwtClaimTypes.FamilyName, "Naheem"),
                        new Claim(JwtClaimTypes.Email, "yusufnaheem1@gmail.com"),
                        new Claim("client", "client1"),
                        new Claim("country", "pk"),
                        }).Result;

                if (!result.Succeeded)
                {
                    throw new Exception(result.Errors.First().Description);
                }
                Log.Debug("Yusuf created");
            }
            else
            {
                Log.Debug("Yusuf already exists");
            }

            var david = userMgr.FindByNameAsync("David").Result;
            if (david == null)
            {
                david = new ApplicationUser
                {
                    UserName = "David",
                    Email = "david@someprovider.com",
                    EmailConfirmed = true
                };
                var result = userMgr.CreateAsync(david, "P@ssword1").Result;
                if (!result.Succeeded)
                {
                    throw new Exception(result.Errors.First().Description);
                }

                result = userMgr.AddClaimsAsync(david, new Claim[]{
                            new Claim("role", "FreeUser"),
                            new Claim(JwtClaimTypes.GivenName, "David"),
                            new Claim(JwtClaimTypes.FamilyName, "Flagg"),
                            new Claim(JwtClaimTypes.Email, "david@someprovider.com"),
                            new Claim("client", "client1"),
                            new Claim("country", "nl")
                        }).Result;
                if (!result.Succeeded)
                {
                    throw new Exception(result.Errors.First().Description);
                }
                Log.Debug("David created");
            }
            else
            {
                Log.Debug("David already exists");
            }

            var muhammad = userMgr.FindByNameAsync("Muhammad").Result;
            if (muhammad == null)
            {
                muhammad = new ApplicationUser
                {
                    UserName = "Muhammad",
                    Email = "muhammad@someprovider.com",
                    EmailConfirmed = true
                };
                var result = userMgr.CreateAsync(muhammad, "P@ssword1").Result;
                if (!result.Succeeded)
                {
                    throw new Exception(result.Errors.First().Description);
                }

                result = userMgr.AddClaimsAsync(muhammad, new Claim[]{
                    new Claim("role", "FreeUser"),
                    new Claim(JwtClaimTypes.GivenName, "Muhammad"),
                    new Claim(JwtClaimTypes.Email, "muhammad@someprovider.com"),
                    new Claim("client", "client2"),
                    new Claim("client", "clientblazor"),
                }).Result;
                if (!result.Succeeded)
                {
                    throw new Exception(result.Errors.First().Description);
                }
                Log.Debug("Muhammad created");
            }
            else
            {
                Log.Debug("Muhammad already exists");
            }
        }
    }
}
