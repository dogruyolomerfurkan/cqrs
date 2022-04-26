namespace Core.Entities
{
    public class BaseEntity : Audit, ISoftDeleted
    {
        public bool IsDeleted { get; set; } = false;
    }
}