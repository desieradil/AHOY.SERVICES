using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahoy.Domain.Models.Hotels
{
    public class HotelOffers
    {
        public HotelOffers()
        {
            Offers = new List<HotelOffer>();
        }
        public string Type { get; set; }
        public Hotel Hotel { get; set; }
        public bool Available { get; set; }
        public string Self { get; set; }
        public List<HotelOffer> Offers { get; set; }
    }
}
