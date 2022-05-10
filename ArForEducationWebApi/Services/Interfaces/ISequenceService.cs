using ArForEducationWebApi.Domain;
using ArForEducationWebApi.Dto.Sequence;

namespace ArForEducationWebApi.Services.Interfaces;

public interface ISequenceService
{
    Task CreateAsync(CreateSequenceDto input);
    IEnumerable<Sequence> GetAll();
}