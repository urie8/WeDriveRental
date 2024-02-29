using Microsoft.AspNetCore.Identity;
using WeDriveRental.Domain;

namespace WeDriveRental.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public List<BookingModel> Bookings { get; set; } = new();
    }

}
