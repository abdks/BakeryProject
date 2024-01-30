using BakeryProject.CQRSPattern.Commands;
using BakeryProject.CQRSPattern.Commands.Slider;
using BakeryProject.DAL.Context;
using BakeryProject.DAL.Entities;


namespace BakeryProject.CQRSPattern.Handlers.slider
{
    public class CreateSliderCommandHandler
    {
        private readonly SaleContext _saleContext;

        public CreateSliderCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public void Handle(CreateSliderCommand command)
        {
            _saleContext.Sliders.Add(new Slider
            {
                ImageUrl = command.ImageUrl,
            });
            _saleContext.SaveChanges();
        }
    }
}
