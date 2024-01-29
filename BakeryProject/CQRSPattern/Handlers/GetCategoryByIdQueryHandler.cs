using BakeryProject.CQRSPattern.Queries;
using BakeryProject.CQRSPattern.Results;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly SaleContext _saleContext;

        public GetCategoryByIdQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public GetCategoryByIdQueryResult Handle(GetCategoryByIdQuery query)
        {
            var values = _saleContext.Categories.Find(query.Id);
            return new GetCategoryByIdQueryResult
            {
                CategoryID = values.CategoryID,
                CategoryName = values.CategoryName
            };

        }
    }

}
