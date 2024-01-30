using BakeryProject.CQRSPattern.Commands;
using BakeryProject.CQRSPattern.Commands.Slider;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers.slider
{
    public class RemoveSliderCommandHandler
    {
        private readonly SaleContext _saleContext;

        public RemoveSliderCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }

        public void Handle(RemoveSliderCommand command)
        {
            var value = _saleContext.Sliders.Find(command.Id);
            _saleContext.Sliders.Remove(value);
            _saleContext.SaveChanges();
        }
    }
}
