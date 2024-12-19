using Core.Entities;

namespace Core.Services;

public interface IOrderService
{
        Task<IEnumerable<Order>> GetOrdersByUserIdAsync(string userId);

}