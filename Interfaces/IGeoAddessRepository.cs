using GeoMapping.DTO;
using GeoMapping.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMapping.Interfaces
{
    public interface IGeoAddressRepository
    {
        Task<List<Address>> GetAddressesList();
        Task<Address> AddAddress(Address _obj);    
    }
}
