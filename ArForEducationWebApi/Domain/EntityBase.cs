namespace ArForEducationWebApi.Domain
{
    public abstract class EntityBase
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
    }
}
