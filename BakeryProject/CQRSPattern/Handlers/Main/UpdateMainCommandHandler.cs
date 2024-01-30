using BakeryProject.CQRSPattern.Commands.Main;
using BakeryProject.CQRSPattern.Commands.Slider;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers.Main
{
    public class UpdateMainCommandHandler
    {
        private readonly SaleContext _saleContext;

        public UpdateMainCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public void Handle(UpdateMainCommand command)
        {
            var values = _saleContext.Mains.Find(command.MainID);
            values.Title1 = command.Title1;
            values.Title2 = command.Title2;
            _saleContext.SaveChanges();
        }
    }
}
