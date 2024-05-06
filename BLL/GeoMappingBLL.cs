using GeoMapping.DTO;
using GeoMapping.Helper;
using GeoMapping.Interfaces;
using GeoMapping.Models;
using GeoMapping.Repositories;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeoMapping.BLL
{
    public class GeoMappingBLL : DTOMapper
    {
        private IGeoAddressRepository repository = null;
        private readonly IConfiguration _configuration;
        public GeoMappingBLL()
        {

            this.repository = new GeoMappingRepository();
        }

        public async Task<Address> AddAddress(AddressDTO addressDTO)
        {
            var obj = DTOMapper.mapper.Map<Address>(addressDTO);

            return await repository.AddAddress(obj);


        }
        public async Task<List<AddressDTO>> GetAddresses()
        {
            var addresses = await repository.GetAddressesList();

            var objDTO = DTOMapper.mapper.Map<List<AddressDTO>>(addresses);
            return objDTO;
        }



    }
}

