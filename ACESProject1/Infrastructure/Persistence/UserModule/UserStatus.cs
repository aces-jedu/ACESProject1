using ACESProject1.Data;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace ACESProject1.Infrastructure.Persistence.UserModule
{
    public class UserStatus
    {
        private readonly UserManager<ApplicationUser> UserModule;

        public UserStatus(UserManager<ApplicationUser> userManager)
        {
            UserModule = userManager;
        }

        // Set Active (1)
        public async Task SetUserActiveAsync(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return;

            var user = await UserModule.FindByEmailAsync(email);

            if (user is null)
                return;

            if (user.IsActive != 1)
            {
                user.IsActive = 1;
                await UserModule.UpdateAsync(user);
            }
        }

        // Set Inactive (0)
        public async Task SetUserInactiveAsync(ClaimsPrincipal principal)
        {
            var user = await UserModule.GetUserAsync(principal);

            if (user is null)
                return;

            if (user.IsActive != 0)
            {
                user.IsActive = 0;
                await UserModule.UpdateAsync(user);
            }
        }
    }
}