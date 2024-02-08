using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEH.Domain.Models.Products;
using Domain.Commons;

namespace CEH.Domain.Models.Suppliers;
public class SupplierProduct : AuditableEntity
{
    public int SupplierId { get; set; }
    public virtual Supplier Supplier { get; set; }
    public int ProductId { get; set; }
    public virtual Product Product { get; set; }
}
