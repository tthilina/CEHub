namespace Domain.Commons;

public interface IRepository<T>
{
    IUnitOfWork UnitOfWork { get; }
}
