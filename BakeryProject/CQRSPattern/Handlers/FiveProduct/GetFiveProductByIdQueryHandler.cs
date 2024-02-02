using BakeryProject.CQRSPattern.Queries.FiveProduct;
using BakeryProject.CQRSPattern.Queries.Main;
using BakeryProject.CQRSPattern.Results.FiveProduct;
using BakeryProject.CQRSPattern.Results.Main;
using BakeryProject.DAL.Context;
using Microsoft.CodeAnalysis;

namespace BakeryProject.CQRSPattern.Handlers.FiveProduct
{
    public class GetFiveProductByIdQueryHandler
    {
        private readonly SaleContext _saleContext;

        public GetFiveProductByIdQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public GetFiveProductByIdQueryResult Handle(GetFiveProductByIdQuery query)
        {
            var values = _saleContext.FiveProducts.Find(query.Id);
            return new GetFiveProductByIdQueryResult
            {
               fiveProductId = values.fiveProductId,
               Name = values.Name,
               Image = values.Image
            };

        }
    }
}
