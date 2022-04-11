using ArForEducationWebApi.Domain;
using ArForEducationWebApi.Dto.Image;
using AutoMapper;

namespace ArForEducationWebApi.Utilities;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<CreateImageDto, Image>();
        CreateMap<Image, ImageMetaDataDto>();
    }
}