using ARM_Assignment.Entities;
using ARM_Assignment.Entities.Models;
using ARM_Assignment.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace ARM_Assignment.Repositories.Implementations
{
    // User Repository whcih implements methods of IUSerRepository
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public UserRepository(AppDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        //Get Userinformation using Email
        public async Task<ApplicationUser> GetUserByEmailAsync(string email) => await _userManager.FindByEmailAsync(email);
        //Register new user
        public async Task<bool> RegisterUserAsync(ApplicationUser user, string password)
        {
            var result = await _userManager.CreateAsync(user, password);
            return result.Succeeded;
        }

        public async Task<bool> CheckPasswordAsync(ApplicationUser user, string password)
        {
            return await _userManager.CheckPasswordAsync(user, password);
        }
    }
}
