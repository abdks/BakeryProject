using BakeryProject.CQRSPattern.Results.TwoPage;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers.TwoPage
{
    public class GetTwoPageQueryHandler
    {
        private readonly SaleContext _saleContext;

        public GetTwoPageQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public List<GetTwoPageQueryResult> Handle()
        {
            var values = _saleContext.TwoPages.Select(x => new GetTwoPageQueryResult
            {
               TwoPageID = x.TwoPageID,
               Description = x.Description,
               NameSurname = x.NameSurname,
               Image = x.Image,
               Title = x.Title,
               Unvan = x.Unvan,
            }).ToList();
            return values;
        }
    }
}
