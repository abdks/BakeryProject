using BakeryProject.CQRSPattern.Queries.NewProduct;
using BakeryProject.CQRSPattern.Results.NewProduct;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers.NewProduct
{
    public class GetNewProductByIdQueryHandler
    {
        private readonly SaleContext _saleContext;

        public GetNewProductByIdQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public GetNewProductByIdQueryResult Handle(GetNewProductByIdQuery query)
        {
            var values = _saleContext.NewProducts.Find(query.Id);
            return new GetNewProductByIdQueryResult
            {
              NewProductID = values.NewProductID,
              ProductName = values.ProductName,
              Description = values.Description,
              DescriptionBold = values.DescriptionBold,
              Image = values.Image
            };

        }
    }
}
