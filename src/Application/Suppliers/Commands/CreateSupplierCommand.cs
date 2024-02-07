using CEH.Domain.Models.Products;
using CEH.Domain.Models.Suppliers;
using CEH.Domain.Models.Suppliers.DTOs;
using CEH.Domain.Services.Products;
using CEH.Domain.Services.Suppliers;
using MediatR;

namespace CEH.Application.Suppliers.Commands;
public class CreateSupplierCommand : IRequest<Supplier>
{
    public SupplierDTO Supplier { get; set; }
}

internal class CreateSupplierCommandHandler : IRequestHandler<CreateSupplierCommand, Supplier>
{
    private readonly ISupplierRepository _supplierRepository;
    private readonly IProductRepository _productRepository;
    public CreateSupplierCommandHandler(ISupplierRepository supplierRepository, IProductRepository productRepository)
    {
        _supplierRepository = supplierRepository;
        _productRepository = productRepository;
    }

    public async Task<Supplier> Handle(CreateSupplierCommand request, CancellationToken cancellationToken)
    {
        List<SupplierProduct> supplierProduct = new List<SupplierProduct>();

        if (request.Supplier.Products.Count > 0) 
        {
            foreach (var item in request.Supplier.Products)
            {
                var newProduct = await _productRepository.AddProduct(new Product()
                { 
                    ProductCategoryId = item.ProductCategoryId,
                    ProductSubCategoryId= item.ProductSubCategoryId,
                    Name = item.Name,
                    Description = item.Description
                });
                supplierProduct.Add(new SupplierProduct() { ProductId = newProduct.Id });
            }
        }
        
        var newSupplier =  await _supplierRepository.AddSupplier(new Supplier() 
        { 
            ProvinceId = request.Supplier.ProvinceId,
            DistrictId = request.Supplier.DistrictId,
            CityId = request.Supplier.CityId,
            Name = request.Supplier.Name,
            ContactNumber1 = request.Supplier.ContactNumber1,
            ContactNumber2 = request.Supplier.ContactNumber1,
            Email = request.Supplier.Email,
            IsRegisteredBusiness = request.Supplier.IsRegisteredBusiness,
            BusinessType = request.Supplier.BusinessType,
            IsQualityCertified = request.Supplier.IsQualityCertified,
            QualityCertificates = request.Supplier.QualityCertificates,
            IsExporting = request.Supplier.IsExporting,
            IsReadyToExport = request.Supplier.IsReadyToExport,
            SupplierProducts= supplierProduct
        });

        return newSupplier;
    }
}
