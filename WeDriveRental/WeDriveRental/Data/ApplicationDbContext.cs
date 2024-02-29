using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WeDriveRental.Domain;

namespace WeDriveRental.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<CarModel> Cars { get; set; }
        public DbSet<BookingModel> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<CarModel>().HasData(
            new CarModel()
            {
                Id = 1,
                Brand = "Mercedes",
                Model = "Mercedes-Benz C-Class",
                SekPrice = 1000
            },
            new CarModel()
            {
                Id = 2,
                Brand = "Audi",
                Model = "Audi RS6",
                SekPrice = 1500
            },

            new CarModel()
            {
                Id = 3,
                Brand = "Audi",
                Model = "Audi RSQ8",
                SekPrice = 2000
            },

            new CarModel()
            {
                Id = 4,
                Brand = "Koenigsegg",
                Model = "koenigsegg Agera",
                SekPrice = 3000
            },
            new CarModel()
            {
                Id = 5,
                Brand = "Mercedes",
                Model = "Mercedes G63 AMG",
                SekPrice = 2500
            }
            );

            //builder.Entity<BookingModel>(b =>
            //b.HasKey(e => e.Id));

            //builder.Entity<ApplicationUser>(b => b.HasMany(u => u.Bookings).WithOne());
        }
    }

}
