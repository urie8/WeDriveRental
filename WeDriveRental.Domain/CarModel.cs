using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeDriveRental.Domain
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Model { get; set; } = null!;
        public string Brand { get; set; } = null!;
        public decimal SekPrice { get; set; }
        public bool IsBooked { get; set; }
        public List<BookingModel> Bookings { get; set; } = new();
    }
}
