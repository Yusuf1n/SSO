using SSO.IdentityServer.Entities;

namespace SSO.IdentityServer.Services;

public interface ILocalUserService
{
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