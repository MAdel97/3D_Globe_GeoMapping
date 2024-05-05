﻿namespace GeoMapping.DTO
{
    public class AddressDTO
    {
        public int Id { get; set; }
        public string SiteName { get; set; }
        public int Apartment { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public string? Country { get; set; }
        public string? District { get; set; }

    }
}
