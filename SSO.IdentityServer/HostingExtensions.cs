using Duende.IdentityServer;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Serilog;
using SSO.IdentityServer.DbContexts;
using SSO.IdentityServer.Services;
using System.Reflection;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using System.Security.Cryptography.X509Certificates;

namespace SSO.IdentityServer;

internal static class HostingExtensions
{
    public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
    {
        // configures IIS out-of-proc settings 
        builder.Services.Configure<IISOptions>(iis =>
        {
            iis.AuthenticationDisplayName = "Windows";
            iis.AutomaticAuthentication = false;
        });
        // ..or configures IIS in-proc settings
        builder.Services.Configure<IISServerOptions>(iis =>
        {
            iis.AuthenticationDisplayName = "Windows";
            iis.AutomaticAuthentication = false;
        });

        var azureCredential = new DefaultAzureCredential();

        builder.Services.AddDataProtection()
            .PersistKeysToAzureBlobStorage(
                new Uri(builder.Configuration["DataProtection:Keys"]),
                azureCredential)
            .ProtectKeysWithAzureKeyVault(
                new Uri(builder.Configuration["DataProtection:ProtectionKeyForKeys"]),
                azureCredential);

        var secretClient = new SecretClient(
            new Uri(builder.Configuration["KeyVault:RootUri"]),
            azureCredential);

        var secretResponse = secretClient.GetSecret(
            builder.Configuration["KeyVault:CertificateName"]);

        var signingCertificate = new X509Certificate2(
            Convert.FromBase64String(secretResponse.Value.Value),
            (string)null,
            X509KeyStorageFlags.MachineKeySet);

        // certificate in KeyVault: 
        //  - certificate resource (public key, metadata)
        //  - key resource (private key)
        //  - secret resource (full certificate)

        builder.Services.AddRazorPages();

        builder.Services.AddScoped<IPasswordHasher<Entities.User>,
            PasswordHasher<Entities.User>>();

        builder.Services.AddScoped<ILocalUserService, LocalUserService>();

        builder.Services.AddDbContext<IdentityDbContext>(options =>
        {
            options.UseSqlServer(
                builder.Configuration
                    .GetConnectionString("IdentityDBConnectionString"));
        });

        var migrationsAssembly = typeof(Program).GetTypeInfo()
            .Assembly.GetName().Name;

        builder.Services.AddIdentityServer(options =>
            {
                // https://docs.duendesoftware.com/identityserver/v6/fundamentals/resources/api_scopes#authorization-based-on-scopes
                options.EmitStaticAudienceClaim = true;
            })
            .AddProfileService<LocalUserProfileService>()
            //.AddInMemoryIdentityResources(Config.IdentityResources)
            //.AddInMemoryApiScopes(Config.ApiScopes)
            //.AddInMemoryClients(Config.Clients);
            .AddConfigurationStore(options =>
            {
                options.ConfigureDbContext = optionsBuilder =>
                    optionsBuilder.UseSqlServer(
                        builder.Configuration
                            .GetConnectionString("IdentityServerDBConnectionString"),
                        sqlOptions => sqlOptions
                            .MigrationsAssembly(migrationsAssembly));
            }).AddConfigurationStoreCache()
            .AddOperationalStore(options =>
            {
                options.ConfigureDbContext = optionsBuilder =>
                    optionsBuilder.UseSqlServer(builder.Configuration
                            .GetConnectionString("IdentityServerDBConnectionString"),
                        sqlOptions => sqlOptions
                            .MigrationsAssembly(migrationsAssembly));
                options.EnableTokenCleanup = true;
            })
            .AddSigningCredential(signingCertificate);

        builder.Services
            .AddAuthentication()
            .AddOpenIdConnect("AAD", "Azure Active Directory", options =>
            {
                options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;
                options.Authority = "https://login.microsoftonline.com/47ebb02b-1114-43a9-aec8-1c5493356c69/v2.0";
                options.ClientId = "76249b42-a328-4250-ac05-8507110d0cb5";
                options.ClientSecret = "Mz28Q~I3VIwJnfyklV4KNB01x~s8Yh52sh9elbCh";
                options.ResponseType = "code";
                options.CallbackPath = new PathString("/signin-aad/");
                options.SignedOutCallbackPath = new PathString("/signout-aad/");
                options.Scope.Add("email");
                options.Scope.Add("offline_access");
                options.SaveTokens = true;
            });

        builder.Services.AddAuthentication()
            .AddFacebook("Facebook",
                options =>
                {
                    options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;
                    options.AppId = "1120946446010255";
                    options.AppSecret = "932da2a6ca6467d93c342829e60bc723";
                });

        return builder.Build();
    }
    
    public static WebApplication ConfigurePipeline(this WebApplication app)
    { 
        app.UseSerilogRequestLogging();
    
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseStaticFiles();
        app.UseRouting();

        app.UseIdentityServer();

        app.UseAuthorization();
        app.MapRazorPages().RequireAuthorization();

        return app;
    }
}
