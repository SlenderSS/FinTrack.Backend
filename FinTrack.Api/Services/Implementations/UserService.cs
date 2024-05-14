using CSharpFunctionalExtensions;
using FinTrack.Api.Services.Interfaces;
using FinTrack.Models;

namespace FinTrack.Api.Services.Implementations
{
    public class UserService : IUserService
    {
        public Task<Result<User>> AuthorizationAsync(string login, string password)
        {
            throw new NotImplementedException();
        }

        public Task<Result> ChangePasswordAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<Result> RegisterUserAsync(string username, string login, string password)
        {
            throw new NotImplementedException();
        }
    }
}
