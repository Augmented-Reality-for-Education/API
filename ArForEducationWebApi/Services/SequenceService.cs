using ArForEducationWebApi.Data;
using ArForEducationWebApi.Domain;
using ArForEducationWebApi.Dto.Sequence;
using ArForEducationWebApi.Services.Interfaces;
using AutoMapper;

namespace ArForEducationWebApi.Services;

public class SequenceService : ISequenceService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public SequenceService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task CreateAsync(CreateSequenceDto input)
    {
        if (input.Images != null)
        {
            var newSequence = _mapper.Map<Sequence>(input);
            var sequence = await _unitOfWork.SequenceRepository.InsertAsync(newSequence);
            
            foreach (var img in input.Images)
            {
                var newImage = _mapper.Map<Image>(img);
                newImage.SequenceId = sequence.SequenceId;
                await _unitOfWork.ImageRepository.InsertAsync(newImage);
            }
            await _unitOfWork.SaveAsync();
        }
    }
}