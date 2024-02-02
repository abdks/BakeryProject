using BakeryProject.CQRSPattern.Results.NewProduct;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers.NewProduct
{
    public class GetNewProductQueryHandler
    {
        private readonly SaleContext _saleContext;

        public GetNewProductQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public List<GetNewProductQueryResult> Handle()
        {
            var values = _saleContext.NewProducts.Select(x => new GetNewProductQueryResult
            {
                NewProductID = x.NewProductID,
                ProductName = x.ProductName,
                Description = x.Description,
                DescriptionBold = x.DescriptionBold,
                Image = x.Image
            }).ToList();
            return values;
        }
    }
}
