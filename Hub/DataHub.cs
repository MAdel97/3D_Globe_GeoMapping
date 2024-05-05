using GeoMapping.DTO;
using GeoMapping.Models;
using Microsoft.AspNetCore.SignalR;
using GeoMapping.Hub;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SignalRDemo.Hub
{
    public class DataHub : Hub<IDataHubClient>
    {
        public async Task SendStocksToUser(List<AddressDTO> data)
        {                                                                                                   
            await Clients.All.SendAddressesToTable(data);
        }
    }
}