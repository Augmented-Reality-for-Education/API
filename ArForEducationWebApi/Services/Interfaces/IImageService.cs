using ArForEducationWebApi.Domain;
using ArForEducationWebApi.Dto.Image;

namespace ArForEducationWebApi.Services.Interfaces;

public interface IImageService
{
    IEnumerable<ImageMetaDataDto> GetAll();
    Task<Image> CreateAsync(CreateImageDto input);
    Task<Image> GetAsync(long imageId);
}