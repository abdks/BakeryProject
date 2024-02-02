using BakeryProject.CQRSPattern.Queries.Service;
using BakeryProject.CQRSPattern.Results.Service;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers.Service
{
    public class GetServiceByIdQueryHandler
    {
        private readonly SaleContext _saleContext;

        public GetServiceByIdQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public GetServiceByIdQueryResult Handle(GetServiceByIdQuery query)
        {
            var values = _saleContext.Services.Find(query.Id);
            return new GetServiceByIdQueryResult
            {
                ServicesID = values.ServicesID,
                Title = values.Title,
                Description = values.Description,
                Image = values.Image
            };

        }
    }
}
