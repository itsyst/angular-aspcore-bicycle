using AutoMapper;
using Bicycle.Models;
using Bicycle.Controllers.Resources;

namespace Bicycle.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Make, MakeResource>().ReverseMap();
        CreateMap<Model, ModelResource>().ReverseMap();
    }
}
