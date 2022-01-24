using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahoy.Domain.Models.Hotels
{
    public class HotelProduct_EstimatedRoomType
    {
        public string Category { get; set; }
        public int Beds { get; set; }
        public string BedType { get; set; }
    }
}
