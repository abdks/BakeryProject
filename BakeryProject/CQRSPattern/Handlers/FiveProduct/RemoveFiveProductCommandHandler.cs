using BakeryProject.CQRSPattern.Commands.FiveProduct;
using BakeryProject.CQRSPattern.Commands.Main;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers.FiveProduct
{
    public class RemoveFiveProductCommandHandler
    {
        private readonly SaleContext _saleContext;

        public RemoveFiveProductCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public void Handle(RemoveFiveProductCommand command)
        {
            var value = _saleContext.FiveProducts.Find(command.Id);
            _saleContext.FiveProducts.Remove(value);
            _saleContext.SaveChanges();
        }
    }
}
