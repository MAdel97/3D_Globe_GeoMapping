using System.Collections.Generic;
using System.Reflection;

namespace GeoMapping.Models
{
    public  class Address
    {
       
        public int Id { get; set; }
        public string SiteName { get; set; }
        public int? Apartment { get; set; }
        public int? PostalCode { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        
         public string? Country { get; set; }
        public string? District { get; set; }

    }
}
