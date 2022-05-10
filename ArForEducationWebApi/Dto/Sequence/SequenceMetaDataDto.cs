using ArForEducationWebApi.Domain;
using ArForEducationWebApi.Dto.Image;

namespace ArForEducationWebApi.Dto.Sequence;

public class SequenceMetaDataDto : EntityBase
{
    public string? Name { get; set; }
    public IEnumerable<ImageMetaDataDto> Images { get; set; }
}