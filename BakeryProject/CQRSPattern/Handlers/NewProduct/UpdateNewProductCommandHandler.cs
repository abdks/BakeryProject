using BakeryProject.CQRSPattern.Commands.NewProduct;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers.NewProduct
{
    public class UpdateNewProductCommandHandler
    {
        private readonly SaleContext _saleContext;
        public UpdateNewProductCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public void Handle(UpdateNewProductCommand command)
        {
            var values = _saleContext.NewProducts.Find(command.NewProductID);
          values.ProductName = command.ProductName;
            values.DescriptionBold = command.DescriptionBold;
            values.Description = command.Description;
            values.Image = command.Image;
            _saleContext.SaveChanges();
        }
    }
}
