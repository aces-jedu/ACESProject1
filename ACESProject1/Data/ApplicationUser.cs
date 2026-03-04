using Microsoft.AspNetCore.Identity;

namespace ACESProject1.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public int IsActive { get; set; } = 0;
    }

}
