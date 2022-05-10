using ArForEducationWebApi.Dto.Image;

namespace ArForEducationWebApi.Dto.Sequence;

public class CreateSequenceDto
{
    public string? Name { get; set; }
    public List<CreateImageDto>? Images { get; set; }
}