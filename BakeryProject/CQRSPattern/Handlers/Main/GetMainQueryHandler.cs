using BakeryProject.CQRSPattern.Results.Main;
using BakeryProject.CQRSPattern.Results.Slider;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers.Main
{
    public class GetMainQueryHandler
    {
        private readonly SaleContext _saleContext;

        public GetMainQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public List<GetMainQueryResult> Handle()
        {
            var values = _saleContext.Mains.Select(x => new GetMainQueryResult
            {
                MainID = x.MainID,
                Title1 = x.Title1,
                Title2 = x.Title2
            }).ToList();
            return values;
        }
    }
}
