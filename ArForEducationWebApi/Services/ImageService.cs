using ArForEducationWebApi.Data;
using ArForEducationWebApi.Domain;
using ArForEducationWebApi.Dto.Image;
using ArForEducationWebApi.Services.Interfaces;
using AutoMapper;

namespace ArForEducationWebApi.Services;

public class ImageService : IImageService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    
    public ImageService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    
    public IEnumerable<ImageMetaDataDto> GetAll()
    {
        var images = _unitOfWork.ImageRepository.GetAll().Where(i => i.SequenceId == null);
        
        // Manually mapping here to avoid loading dataURLs from the database
        return images.Select(i => new ImageMetaDataDto
        {
            Created = i.Created,
            Id = i.Id,
            LastModified = i.LastModified,
            Name = i.Name
        });
    }

    public async Task<Image> CreateAsync(CreateImageDto input)
    {
        var newImage = _mapper.Map<Image>(input);
        newImage = await _unitOfWork.ImageRepository.InsertAsync(newImage);
        await _unitOfWork.SaveAsync();
        return newImage;
    }

    public Task<Image> GetAsync(long imageId)
    {
        return _unitOfWork.ImageRepository.GetByIdAsync(imageId);
    }
}