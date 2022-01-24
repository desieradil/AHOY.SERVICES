using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahoy.Domain.Models.Hotels
{
   public class Stakeholder
    {
        public int Id { get; set; }
        public Name Name { get; set; }
        public Contact Contact { get; set; }
        public string HotelRewardsMember { get; set; }
    }
}
