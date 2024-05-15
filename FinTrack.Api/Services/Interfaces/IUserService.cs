using CSharpFunctionalExtensions;
using FinTrack.Models;

namespace FinTrack.Api.Services.Interfaces
{
    public interface IUserService
    {
        Task<Result> RegisterUserAsync(string username, string password);
        Task<Result<User>> AuthorizationAsync(string login, string password);
        Task<Result> ChangePasswordAsync(User user);
        Task<Result> DeleteUserAccount(User user);
        Task<Result<User>> GetUserById(int userId);


    }
}
