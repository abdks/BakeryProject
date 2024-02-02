using BakeryProject.CQRSPattern.Queries.TwoPage;
using BakeryProject.CQRSPattern.Results.TwoPage;
using BakeryProject.DAL.Context;
using Microsoft.CodeAnalysis;

namespace BakeryProject.CQRSPattern.Handlers.TwoPage
{
    public class GetTwoPageByIdQueryHandler
    {
        private readonly SaleContext _saleContext;

        public GetTwoPageByIdQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public GetTwoPageByIdQueryResult Handle(GetTwoPageByIdQuery query)
        {
            var values = _saleContext.TwoPages.Find(query.Id);
            return new GetTwoPageByIdQueryResult
            {
             TwoPageID= values.TwoPageID,
             Description = values.Description,
             Title = values.Title,
             NameSurname = values.NameSurname,
             Image = values.Image,
             Unvan = values.Unvan
            };

        }
    }
}
