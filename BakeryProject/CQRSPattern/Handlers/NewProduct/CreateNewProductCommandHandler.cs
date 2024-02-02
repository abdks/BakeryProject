using BakeryProject.CQRSPattern.Commands.NewProduct;
using BakeryProject.DAL.Context;

namespace BakeryProject.CQRSPattern.Handlers.NewProduct
{
    public class CreateNewProductCommandHandler
    {
        private readonly SaleContext _saleContext;

        public CreateNewProductCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public void Handle(CreateNewProductCommand command)
        {
            _saleContext.NewProducts.Add(new DAL.Entities.NewProduct
            {
              ProductName = command.ProductName,
              Description = command.Description,
              DescriptionBold = command.DescriptionBold,
              Image = command.Image
            });
            _saleContext.SaveChanges();
        }
    }
}
