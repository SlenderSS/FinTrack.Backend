using CSharpFunctionalExtensions;
using FinTrack.Api.Repository.Interfaces;
using FinTrack.Api.Services.Interfaces;
using FinTrack.Models;
using Microsoft.EntityFrameworkCore;

namespace FinTrack.Api.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }
        public Task<Result<User>> AuthorizationAsync(string login, string password)
        {
            throw new NotImplementedException();
        }

        public Task<Result> ChangePasswordAsync(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<Result> RegisterUserAsync(string username, string password)
        {
            if (await _userRepository.IsItemExistsAsync(username))
                return Result.Failure("The user with the same username already exists");

            var userCreate = new User { Name = username, Password = password };
            var isSuccess = await _userRepository.CreateAsync(userCreate);
            if (isSuccess)
                return Result.Success();
            else
                return Result.Failure("Something went wrong while saving");
        }

        public async Task<Result<User>> GetUserById(int userId)
        {
            var user = await _userRepository.GetItemAsync(userId);
            if (user == null)
                return Result.Failure<User>("User is not exists");

            return user;
        }

        public async Task<Result> DeleteUserAccount(User user)
        {
            var isSuccess = await _userRepository.DeleteAsync(user);
            if (isSuccess)
                return Result.Success("Deleting was successful");
            else 
                return Result.Failure("Something went wrong while deleting account");
        }


    }
}
