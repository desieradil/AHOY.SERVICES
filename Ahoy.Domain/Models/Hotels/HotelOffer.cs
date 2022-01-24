using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahoy.Domain.Models.Hotels
{
    public class HotelOffer
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string CheckInDate { get; set; }
        public string CheckOutDate { get; set; }
        public string RateCode { get; set; }
        public int RoomQuantity { get; set; }
    }
}
