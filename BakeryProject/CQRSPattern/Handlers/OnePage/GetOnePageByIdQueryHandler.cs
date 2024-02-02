using BakeryProject.CQRSPattern.Commands.OnePage;
using BakeryProject.CQRSPattern.Queries.OnePage;
using BakeryProject.CQRSPattern.Results.OnePage;
using BakeryProject.DAL.Context;
using Microsoft.CodeAnalysis;

namespace BakeryProject.CQRSPattern.Handlers.OnePage
{
    public class GetOnePageByIdQueryHandler
    {
        private readonly SaleContext _saleContext;

        public GetOnePageByIdQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public GetOnePageByIdQueryResult Handle(GetOnePageByIdQuery query)
        {
            var values = _saleContext.OnePages.Find(query.Id);
            return new GetOnePageByIdQueryResult
            {
               OnePageID = values.OnePageID,
               Image = values.Image,
               Title = values.Title,
               Description1 = values.Description1,
               Description2 = values.Description2,
            };

        }
    }
}
