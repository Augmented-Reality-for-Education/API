using ArForEducationWebApi.Domain;
using ArForEducationWebApi.Dto.Image;

namespace ArForEducationWebApi.Services.Interfaces;

public interface IImageService
{
    public IEnumerable<Image> GetAll();
    public Task<Image> CreateAsync(CreateImageDto input);
}