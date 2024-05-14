using CSharpFunctionalExtensions;
using FinTrack.Models;

namespace FinTrack.Api.Services.Interfaces
{
    public interface IUserService
    {
        Task<Result> RegisterUserAsync(string username, string login, string password);
        Task<Result<User>> AuthorizationAsync(string login, string password);
        Task<Result> ChangePasswordAsync(User user);
    }
}
