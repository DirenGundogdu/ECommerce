using Microsoft.AspNetCore.Identity;

namespace Core.Entities;

public class User : IdentityUser
{
    public ICollection<Order> Orders { get; set; }
}