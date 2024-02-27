using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeDriveRental.Domain
{
    public class BookingModel
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }
        public bool IsCancelled { get; set; }
        public int CarId { get; set; }
        public CarModel Car { get; set; }
    }
}
