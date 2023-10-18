namespace SSO.IdentityServer.Entities;

public interface IConcurrencyAware
{
    string ConcurrencyStamp { get; set; }
}