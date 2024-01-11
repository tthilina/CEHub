using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEH.Domain.Models.Products;
using Domain.Commons;

namespace CEH.Domain.Services.Products;
public interface IProductRepository : IRepository<ProductCategory>, IRepository<ProductSubCategory>
{
    Task<List<ProductCategory>> CategoriesToListAsync();
    Task<List<ProductSubCategory>> SubCategoriesToListAsync(int productCategoryId);
    Task<List<ProductCategory>> AllCategoriesToListAsync();
}
