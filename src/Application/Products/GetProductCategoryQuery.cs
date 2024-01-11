using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEH.Domain.Models.Products;
using CEH.Domain.Services.Products;
using MediatR;

namespace CEH.Application.Products;
public class GetProductCategoryQuery : IRequest<List<ProductCategory>>
{
    public class GetProductCategoryHandler : IRequestHandler<GetProductCategoryQuery, List<ProductCategory>>
    {
        private readonly IProductRepository _productRepository;
        public GetProductCategoryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<ProductCategory>> Handle(GetProductCategoryQuery request, CancellationToken cancellationToken)
        {
            var itemList = await _productRepository.CategoriesToListAsync();

            return itemList;
        }
    }
}
