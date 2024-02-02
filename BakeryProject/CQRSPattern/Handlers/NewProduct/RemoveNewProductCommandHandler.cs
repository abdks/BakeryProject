using BakeryProject.CQRSPattern.Commands.NewProduct;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers.NewProduct
{
    public class RemoveNewProductCommandHandler
    {
        private readonly SaleContext _saleContext;

        public RemoveNewProductCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public void Handle(RemoveNewProductCommand command)
        {
            var value = _saleContext.NewProducts.Find(command.Id);
            _saleContext.NewProducts.Remove(value);
            _saleContext.SaveChanges();
        }
    }
}
