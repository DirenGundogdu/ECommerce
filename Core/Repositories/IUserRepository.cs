using Core.Entities;

namespace Core.Repositories;

public interface IUserRepository : IRepositories<User>
{
    Task<User> GetUserWithOrdersAsync(string userId);
}
