using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahoy.Domain.Models.Hotels
{
    public class Hotel
    {
        public string Type { get; set; }
        public string HotelId { get; set; }
        public string Name { get; set; }
        public string CityCode { get; set; }
        public string ChainCode { get; set; }
        public string BrandCode { get; set; }
        public string DupeId { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
    }
}
