using AutoMapper;
using DC = CoreAPI2.API.DataContracts;
using S = CoreAPI2.Services.Model;

namespace CoreAPI2.IoC.Configuration.AutoMapper.Profiles
{
    public class APIMappingProfile : Profile
    {
        public APIMappingProfile()
        {
            CreateMap<DC.User, S.User>().ReverseMap();
            CreateMap<DC.Adress, S.Adress>().ReverseMap();
        }
    }
}
