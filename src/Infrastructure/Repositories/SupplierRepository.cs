using CEH.Domain.Models.Suppliers;
using CEH.Domain.Services.Suppliers;
using Domain.Commons;
using Infrastructure.Persistence.EntityFramework;

namespace CEH.Infrastructure.Repositories;
public class SupplierRepository : ISupplierRepository
{
    private readonly ApplicationDbContext _applicationDbContext;

    public IUnitOfWork UnitOfWork => throw new NotImplementedException();

    public SupplierRepository(
        ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext ?? throw new ArgumentNullException(nameof(applicationDbContext));
    }

    public Task<Supplier> AddSupplier(Supplier supplier)
    {
        _applicationDbContext.Suppliers.Add(supplier);
        _applicationDbContext.SaveChanges();
        return Task.FromResult(supplier);
    }
}
