using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEH.Domain.Models.Products;
using CEH.Domain.Models.Suppliers;
using Domain.Commons;

namespace CEH.Domain.Services.Suppliers;
public interface ISupplierRepository : IRepository<Supplier>
{
    Task<Supplier> AddSupplier(Supplier supplier);
}
