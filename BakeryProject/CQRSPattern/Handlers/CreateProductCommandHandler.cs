using BakeryProject.CQRSPattern.Commands;
using BakeryProject.DAL.Context;
using BakeryProject.DAL.Entities;
using System.Runtime.InteropServices;

namespace BakeryProject.CQRSPattern.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly SaleContext _saleContext;

        public CreateProductCommandHandler(SaleContext saleContext)
        {
            _saleContext = saleContext;
        }
        public void Handle(CreateProductCommand command)
        {
            _saleContext.Products.Add(new Product
            {
                CategoryID = command.CategoryID,
                ProductName = command.ProductName,
                Price = command.Price,
                Stock = command.Stock
            });
            _saleContext.SaveChanges();
        }
    }
}
