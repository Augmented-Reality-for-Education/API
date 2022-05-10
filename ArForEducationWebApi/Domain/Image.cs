using System.ComponentModel.DataAnnotations.Schema;

namespace ArForEducationWebApi.Domain;

public class Image : EntityBase
{
    public string? Name { get; set; }
    public string? DataUrl { get; set; }
    [ForeignKey("Sequence")]
    public long? SequenceId { get; set; }
}