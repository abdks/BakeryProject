using BakeryProject.CQRSPattern.Results.FiveProduct;
using BakeryProject.CQRSPattern.Results.Main;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers.FiveProduct
{
    public class GetFiveProductQueryHandler
    {
        private readonly SaleContext _saleContext;

        public GetFiveProductQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public List<GetFiveProductQueryResult> Handle()
        {
            var values = _saleContext.FiveProducts.Select(x => new GetFiveProductQueryResult
            {
              fiveProductId = x.fiveProductId,
              Name = x.Name,
              Image = x.Image
            }).ToList();
            return values;
        }
    }
}
