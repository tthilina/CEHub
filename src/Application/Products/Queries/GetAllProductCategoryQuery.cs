using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEH.Domain.Models.Products;
using CEH.Domain.Services.Products;
using MediatR;

namespace CEH.Application.Products.Queries;
public class GetAllProductCategoryQuery : IRequest<List<ProductCategory>>
{
    public class GetAllProductCategoryQueryHandler : IRequestHandler<GetAllProductCategoryQuery, List<ProductCategory>>
    {
        private readonly IProductRepository _productRepository;
        public GetAllProductCategoryQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<ProductCategory>> Handle(GetAllProductCategoryQuery request, CancellationToken cancellationToken)
        {
            var itemList = await _productRepository.AllCategoriesToListAsync();

            return itemList;
        }
    }
}
