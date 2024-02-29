namespace WeDriveRental.Domain
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Model { get; set; } = null!;
        public string Brand { get; set; } = null!;
        public decimal SekPrice { get; set; }
        public List<BookingModel> Booking { get; set; } = new();
    }
}
