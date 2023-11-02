namespace Domain.Commons;

public abstract class AuditableEntity : Entity
{
    public DateTimeOffset CreatedDate { get; set; } = DateTime.UtcNow;

    public int? CreatedBy { get; set; }

    public DateTimeOffset LastModifiedDate { get; set; } = DateTime.UtcNow;

    public int? LastModifiedBy { get; set; }
}
