using Core.Entities;

namespace Core.Repositories;

public interface IOrderRepository : IRepositories<Order>
{
    Task<IEnumerable<Order>> GetOrdersByUserIdAsync(string userId);
}