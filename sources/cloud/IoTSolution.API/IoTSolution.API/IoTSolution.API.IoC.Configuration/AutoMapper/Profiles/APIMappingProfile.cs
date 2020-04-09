using AutoMapper;

using DCIoT = IoTSolution.API.API.DataContracts.IoT;
using SIoT = IoTSolution.API.Services.Model.IoT;

namespace IoTSolution.API.IoC.Configuration.AutoMapper.Profiles
{
    public class APIMappingProfile : Profile
    {
        public APIMappingProfile()
        {
            CreateMap<SIoT.Device, DCIoT.Device>().ReverseMap();
            CreateMap<SIoT.DeviceIoTSettings, DCIoT.DeviceIoTSettings>().ReverseMap();
            CreateMap<SIoT.Location, DCIoT.Location>().ReverseMap();
            CreateMap<SIoT.Tags, DCIoT.Tags>().ReverseMap();
            CreateMap<SIoT.Twins, DCIoT.Twins>().ReverseMap();
            CreateMap<SIoT.Properties, DCIoT.Properties>().ReverseMap();
        }
    }
}
