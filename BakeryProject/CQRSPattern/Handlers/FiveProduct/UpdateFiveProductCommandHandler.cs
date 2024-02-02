using BakeryProject.CQRSPattern.Commands.FiveProduct;
using BakeryProject.CQRSPattern.Commands.Main;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers.FiveProduct
{
    public class UpdateFiveProductCommandHandler
    {
        private readonly SaleContext _saleContext;
        public UpdateFiveProductCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public void Handle(UpdateFiveProductCommand command)
        {
            var values = _saleContext.FiveProducts.Find(command.fiveProductId);
            values.Name = command.Name;
            values.Image = command.Image;
            _saleContext.SaveChanges();
        }
    }
}
