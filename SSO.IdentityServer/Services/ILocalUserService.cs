using System.Security.Claims;
using SSO.IdentityServer.Entities;

namespace SSO.IdentityServer.Services;

public interface ILocalUserService
{
    Task<UserSecret> GetUserSecretAsync(string subject, string name);

    Task<bool> AddUserSecret(string subject, string name, string secret);

    Task<User> GetUserByEmailAsync(string email);

    Task AddExternalProviderToUser(
        string subject,
        string provider,
        string providerIdentityKey);

    Task<User> FindUserByExternalProviderAsync(
        string provider,
        string providerIdentityKey);

    public User AutoProvisionUser(string provider,
        string providerIdentityKey,
        IEnumerable<Claim> claims);

    Task<bool> IsUserActive(
        string subject);

    Task<bool> ValidateCredentialsAsync(
        string userName,
        string password);

    Task<User> GetUserByUserNameAsync(
        string userName);

    Task<IEnumerable<UserClaim>> GetUserClaimsBySubjectAsync(
        string subject);

    Task<User> GetUserBySubjectAsync(
        string subject);

    void AddUser
    (User userToAdd,
        string password);

    Task<bool> ActivateUserAsync(string securityCode);

    Task<bool> SaveChangesAsync();
}