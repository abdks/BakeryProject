using BakeryProject.CQRSPattern.Results;
using BakeryProject.CQRSPattern.Results.Slider;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers.slider
{
    public class GetSliderQueryHandler
    {
        private readonly SaleContext _saleContext;

        public GetSliderQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public List<GetSliderQueryResult> Handle()
        {
            var values = _saleContext.Sliders.Select(x => new GetSliderQueryResult
            {
              SliderID = x.SliderID,
              ImageUrl = x.ImageUrl
            }).ToList();
            return values;
        }
    }
}
