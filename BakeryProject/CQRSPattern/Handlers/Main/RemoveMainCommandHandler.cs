using BakeryProject.CQRSPattern.Commands.Main;
using BakeryProject.CQRSPattern.Commands.Slider;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers.Main
{
    public class RemoveMainCommandHandler
    {
        private readonly SaleContext _saleContext;

        public RemoveMainCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public void Handle(RemoveMainCommand command)
        {
            var value = _saleContext.Mains.Find(command.Id);
            _saleContext.Mains.Remove(value);
            _saleContext.SaveChanges();
        }
    }
}
