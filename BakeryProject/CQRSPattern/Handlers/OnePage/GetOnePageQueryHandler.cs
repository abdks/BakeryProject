using BakeryProject.CQRSPattern.Results.OnePage;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers.OnePage
{
    public class GetOnePageQueryHandler
    {
        private readonly SaleContext _saleContext;

        public GetOnePageQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public List<GetOnePageQueryResult> Handle()
        {
            var values = _saleContext.OnePages.Select(x => new GetOnePageQueryResult
            {
               OnePageID = x.OnePageID,
               Title = x.Title,
               Image = x.Image,
               Description1 = x.Description1,
               Description2 = x.Description2,
            }).ToList();
            return values;
        }
    }
}
