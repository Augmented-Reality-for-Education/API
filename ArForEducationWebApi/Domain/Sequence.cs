using System.ComponentModel.DataAnnotations;

namespace ArForEducationWebApi.Domain;

public class Sequence : EntityBase
{
    public string? Name { get; set; }
    public List<Image> Images { get; set; }
}