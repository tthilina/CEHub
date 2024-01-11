using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEH.Application.Locations.Queries;
using CEH.Domain.Models.Products;
using CEH.Domain.Services.Products;
using MediatR;

namespace CEH.Application.Products;
public class GetProductSubCategoryQuery : IRequest<List<ProductSubCategory>>
{
    public int productCategoryId { get; set; }
}

internal class GetProductSubCategoryQueryHandler : IRequestHandler<GetProductSubCategoryQuery, List<ProductSubCategory>>
{
    private readonly IProductRepository _productRepository;
    public GetProductSubCategoryQueryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<List<ProductSubCategory>> Handle(GetProductSubCategoryQuery request, CancellationToken cancellationToken)
    {
        var itemList = await _productRepository.SubCategoriesToListAsync(request.productCategoryId);

        return itemList;
    }
}
