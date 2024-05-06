using GeoMapping.DTO;
using GeoMapping.Models;
using System.Runtime.CompilerServices;

namespace GeoMapping.Services
{
    public interface IAddressService
    {
        Task<IEnumerable<AddressDTO>> GetAddresses();
  

    }
}
