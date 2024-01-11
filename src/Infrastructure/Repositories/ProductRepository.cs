using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEH.Domain.Models.Products;
using CEH.Domain.Services.Products;
using Domain.Commons;
using Infrastructure.Persistence.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace CEH.Infrastructure.Repositories;
public class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _applicationDbContext;

    public IUnitOfWork UnitOfWork => throw new NotImplementedException();

    public ProductRepository(
        ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext ?? throw new ArgumentNullException(nameof(applicationDbContext));
    }
    public async Task<List<ProductCategory>> AllCategoriesToListAsync()
    {
        return await _applicationDbContext
            .ProductCategories.AsNoTracking().ToListAsync();
    }

    public async Task<List<ProductSubCategory>> SubCategoriesToListAsync(int productCategoryId)
    {
        return await _applicationDbContext
            .ProductSubCategories
            .Where(x => x.ProductCategoryId == productCategoryId)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<List<ProductCategory>> CategoriesToListAsync()
    {
        return await _applicationDbContext
            .ProductCategories
            .Include(x => x.ProductSubCategories)
            .AsNoTracking()
            .ToListAsync();
    }

    
}
