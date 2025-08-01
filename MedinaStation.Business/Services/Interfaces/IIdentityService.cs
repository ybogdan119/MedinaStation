namespace MedinaStation.Business.Services.Interfaces;

public interface IIdentityService
{
    Task<string?> RegisterAsync(string username, string password, string role);
    Task<string?> LoginAsync(string username, string password);
}