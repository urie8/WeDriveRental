using WeDriveRental.Data;

namespace WeDriveRental.Domain
{
    public class BookingModel
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsCancelled { get; set; }
        public string UserId { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;
        public int CarId { get; set; }
        public CarModel Car { get; set; } = null!;
    }
}
