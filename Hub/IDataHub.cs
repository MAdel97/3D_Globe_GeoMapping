using GeoMapping.DTO;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeoMapping.Hub
{
    public interface IDataHubClient
    {
        Task SendAddressesToTable (List<AddressDTO> addressDTOs);
    }
}

