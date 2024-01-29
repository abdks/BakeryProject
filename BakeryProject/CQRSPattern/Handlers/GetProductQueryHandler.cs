using BakeryProject.CQRSPattern.Results;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly SaleContext _saleContext;

        public GetProductQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public List<GetProductQueryResult> Handle()
        {
            var values = _saleContext.Products.Select(x => new GetProductQueryResult
            {
                Price = x.Price,
                ProductName = x.ProductName,
                ProductID = x.ProductID,
                Stock = x.Stock,
                CategoryID = x.CategoryID,
            }).ToList();
            return values;
        }
    }
}
