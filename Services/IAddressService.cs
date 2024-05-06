using GeoMapping.DTO;
using GeoMapping.Models;

namespace GeoMapping.Services
{
    public interface IAddressService
    {
        Task<IEnumerable<AddressDTO>> GetAddresses();
    }
}
