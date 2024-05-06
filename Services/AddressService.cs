using GeoMapping.DTO;
using GeoMapping.Models;
using GeoMapping.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace GeoMapping.Services
{
    public class AddressService : IAddressService
    {
        private readonly HttpClient httpClient;

        public AddressService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<AddressDTO>> GetAddresses()
        {
            return await httpClient.GetFromJsonAsync<AddressDTO[]>("geomapping/getaddresses");
        }
    }
}