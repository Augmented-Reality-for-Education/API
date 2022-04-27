namespace ArForEducationWebApi.Dto.Sequence;
using ArForEducationWebApi.Dto.Image;

public class CreateSequenceDto
{
    public string? Name { get; set; }
    public List<CreateImageDto>? Images { get; set; }
}