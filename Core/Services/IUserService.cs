using Core.Entities;

namespace Core.Services;

public interface IUserService
{
    Task<User> GetUserWithOrdersAsync(string userId);
}