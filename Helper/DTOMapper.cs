using AutoMapper;
using GeoMapping.DTO;
using GeoMapping.Models;


namespace GeoMapping.Helper
{
    public class DTOMapper : Profile
    {
        public static IMapper mapper { get; set; }
        static DTOMapper()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Address, AddressDTO>();
                cfg.CreateMap<AddressDTO, Address>().ReverseMap().ForMember(o => o.Id, opt => opt.Ignore());
            });
            configuration.AssertConfigurationIsValid();
            mapper = configuration.CreateMapper();
        }
    }
}
