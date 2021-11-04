using System;
using System.Collections.Generic;

#nullable disable

namespace Post_Office
{
    public partial class Client
    {
        public string Id { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public int ParcelId { get; set; }

        public bool Bonus { get; set; }

        
    }
}
