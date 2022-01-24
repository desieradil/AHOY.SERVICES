using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahoy.Domain.Models.Hotels
{
    public class HotelProduct_RoomDetails
    {
        public string Type { get; set; }
        public HotelProduct_EstimatedRoomType TypeEstimated { get; set; }
        public QualifiedFreeText Description { get; set; }
    }
}
