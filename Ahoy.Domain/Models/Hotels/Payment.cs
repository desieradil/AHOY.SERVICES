using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahoy.Domain.Models.Hotels
{
    public class Payment
    {
        public string method { get; set; }
        public Card card { get; set; }
    }

    public class Card
    {
        public string vendorCode { get; set; }
        public string cardNumber { get; set; }
        public string expiryDate { get; set; }
    }
}
