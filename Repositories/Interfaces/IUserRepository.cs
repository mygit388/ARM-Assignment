using ARM_Assignment.Entities;
using ARM_Assignment.Entities.Models;

namespace ARM_Assignment.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<ApplicationUser> GetUserByEmailAsync(string email);
        Task<bool> RegisterUserAsync(ApplicationUser user, string password);
        Task<bool> CheckPasswordAsync(ApplicationUser user, string password);
    }
}
