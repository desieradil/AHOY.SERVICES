using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahoy.Domain.Models.Hotels
{

    public class Booking
    {
        public BookingModel data { get; set; }
    }

    public class BookingModel
    {
        public string offerId { get; set; }
        public List<Guest> guests { get; set; }
        public List<Payment> payments { get; set; }

    }
}
