
using GeoMapping.BLL;
using GeoMapping.DTO;
using GeoMapping.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMapping.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GeoMappingController : ControllerBase
    {
        private GeoMappingBLL geoMappingBLL =null;

        private readonly ILogger<GeoMappingController> _logger;

        public GeoMappingController(ILogger<GeoMappingController> logger)
        {
            geoMappingBLL = new GeoMappingBLL();
            _logger = logger;
        }

        [HttpPost("AddAddress")]
        
        public  async Task<Address> AddAddress([FromBody] AddressDTO addressDTO)
        {
            
            return await geoMappingBLL.AddAddress(addressDTO);
        }
        [HttpGet("GetAddresses")]
        public async Task<List<AddressDTO>>GetAddresses()
        {
           
         return await geoMappingBLL.GetAddresses();
        }
      
     
    }
}
