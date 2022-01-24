using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahoy.Domain.Models.Hotels
{
    public class HotelList
    {
       public List<HotelModel> data { get; set; }
    }

    public class HotelModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IataCode { get; set; }
        public string SubType { get; set; }
        public int Relevance { get; set; }
        public string Type { get; set; }
        public List<string> HotelIds { get; set; }
        public Address Address { get; set; }
        public GeoCode GeoCode { get; set; }
    }

    public class Address
    {
        public string CityName { get; set; }
        public string CountryCode { get; set; }
    }
    public class GeoCode
    {
        public float Latitude { get; set; }
        public float Longitude { get; set; }
    }
}
