using BakeryProject.CQRSPattern.Commands;
using BakeryProject.CQRSPattern.Commands.Slider;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers.slider
{
    public class UpdateSliderCommandHandler
    {
        private readonly SaleContext _saleContext;

        public UpdateSliderCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public void Handle(UpdateSliderCommand command)
        {
            var values = _saleContext.Sliders.Find(command.SliderID);
            values.ImageUrl = command.ImageUrl;
            _saleContext.SaveChanges();
        }
    }
}
