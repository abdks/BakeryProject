using BakeryProject.CQRSPattern.Commands.FiveProduct;
using BakeryProject.CQRSPattern.Commands.Main;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers.FiveProduct
{
    public class CreateFiveProductCommandHandler
    {
        private readonly SaleContext _saleContext;

        public CreateFiveProductCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public void Handle(CreateFiveProductCommand command)
        {
            _saleContext.FiveProducts.Add(new DAL.Entities.FiveProduct
            {
               Name = command.Name,
               Image = command.Image
            });
            _saleContext.SaveChanges();
        }
    }
}
