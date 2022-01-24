using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahoy.Domain.Models.Hotels
{

    public class Guest
    {
        public Name name { get; set; }
        public Contact contact { get; set; }
    }
    public class Name
    {
        public string title { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }

    public class Contact
    {
        public string phone { get; set; }
        public string email { get; set; }
    }
}
