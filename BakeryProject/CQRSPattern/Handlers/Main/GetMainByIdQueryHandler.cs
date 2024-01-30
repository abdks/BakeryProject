
using BakeryProject.CQRSPattern.Queries.Main;
using BakeryProject.CQRSPattern.Results.Main;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers.Main
{
    public class GetMainByIdQueryHandler
    { 
        private readonly SaleContext _saleContext;

        public GetMainByIdQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public GetMainByIdQueryResult Handle(GetMainByIdQuery query)
        {
            var values = _saleContext.Mains.Find(query.Id);
            return new GetMainByIdQueryResult
            {
               MainID = values.MainID,
               Title1 = values.Title1,
               Title2 = values.Title2
            };

        }
    }
}
