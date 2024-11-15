using Microsoft.AspNetCore.Identity;

namespace BookingApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<ApplicationUserGymClass> AttendingUsers { get; set; } = new List<ApplicationUserGymClass>();
    }
}
