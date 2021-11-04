using System;
using System.Collections.Generic;

#nullable disable

namespace Post_Office
{
    public partial class Parcel
    {
        public int Id { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public string AdressId { get; set; }
    }
}
