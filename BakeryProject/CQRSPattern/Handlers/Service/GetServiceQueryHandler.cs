using BakeryProject.CQRSPattern.Results.Service;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers.Service
{
    public class GetServiceQueryHandler
    {
        private readonly SaleContext _saleContext;

        public GetServiceQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public List<GetServiceQueryResult> Handle()
        {
            var values = _saleContext.Services.Select(x => new GetServiceQueryResult
            {
                ServicesID = x.ServicesID,
                Description = x.Description,
                Title   = x.Title,
                Image = x.Image
            }).ToList();
            return values;
        }
    }
}
