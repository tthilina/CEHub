using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEH.Domain.Models.Products;

namespace CEH.Domain.Models.Suppliers.DTOs;
public class SupplierProductDTO
{
    public int SupplierId { get; set; }
    public int ProductId { get; set; }
}
