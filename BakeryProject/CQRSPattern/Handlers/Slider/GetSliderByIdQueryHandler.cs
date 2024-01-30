using BakeryProject.CQRSPattern.Queries;
using BakeryProject.CQRSPattern.Queries.Slider;
using BakeryProject.CQRSPattern.Results;
using BakeryProject.CQRSPattern.Results.Slider;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers.slider
{
    public class GetSliderByIdQueryHandler
    {
        private readonly SaleContext _saleContext;

        public GetSliderByIdQueryHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
     
        public GetSliderByIdQueryResult Handle(GetSliderByIdQuery query)
        {
            var values = _saleContext.Sliders.Find(query.Id);
            return new GetSliderByIdQueryResult
            {
                SliderID = values.SliderID,
                ImageUrl = values.ImageUrl
            };

        }

     
    }
}
