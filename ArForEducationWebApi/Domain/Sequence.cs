namespace ArForEducationWebApi.Domain;

public class Sequence : EntityBase
{
    public long SequenceId { get; set; }
    public string? Name { get; set; }
}